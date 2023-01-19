using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MasterData_Manager
{
    public class Sql_Manager
    {
        private SqlConnection m_Sql_Connection = new SqlConnection();
        private SqlCommand m_Sql_Command = null;
        private enum DataType { dataSet_type, dataTable_type, string_type};

        public bool Sql_Connect(string connectionString)
        {
            try
            {
                m_Sql_Connection.ConnectionString = connectionString;
                m_Sql_Connection.Open();

                m_Sql_Command = new SqlCommand();
                m_Sql_Command.Connection = m_Sql_Connection;

                return true;
            }
            catch (Exception ex)
            {
                m_Sql_Connection.Close();

                return false;
            }
        }
        public bool Sql_Disconnect()
        {
            try
            {
                m_Sql_Connection.Close();
                m_Sql_Command = null;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public dynamic Sql_Execute_Search(int nStep, params string[] arrstrParam)
        {
            dynamic result_data = null;
            switch (nStep)
            {
                case 1:
                    result_data = ExecuteSql(DataType.dataTable_type, Get_Step1_Query(arrstrParam[0]));
                    break;
                case 2:
                    result_data = ExecuteSql(DataType.dataTable_type, Get_Step2_Query(arrstrParam));
                    break;
                case 3:
                    break;
                case 4:
                    result_data = ExecuteSql(DataType.dataTable_type, Get_Step4_Query());
                    break;
            }

            return result_data;
        }

        public string Sql_Execute_Update(int nStep, params string[] arrstrParam)
        {
            string result_data = string.Empty;
            switch (nStep)
            {
                case 1:                    
                    break;
                case 2:
                    result_data = ExecuteSql(DataType.string_type, Get_Step2_Query(arrstrParam, false));
                    break;
                case 3:
                    break;
                case 4:
                    result_data = ExecuteSql(DataType.string_type, Get_Step4_Query(arrstrParam, false));
                    break;
            }


            return result_data;
        }

        private dynamic ExecuteSql(DataType dataType, string strQuery)
        {
            m_Sql_Command.CommandText = strQuery;
            try
            {
                SqlDataAdapter sd = new SqlDataAdapter(m_Sql_Command);
                DataSet ds = new DataSet();
                sd.Fill(ds, "Result");

                switch(dataType)
                {
                    case DataType.dataSet_type:
                        {
                            return ds;
                        }
                    case DataType.dataTable_type:
                        {
                            if (ds.Tables.Count > 0)
                                return ds.Tables[0];
                            else
                                return null;
                        }
                    case DataType.string_type:
                        {
                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                                return ds.Tables[0].Rows[0][0].ToString();
                            else
                                return "";
                        }
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            { 
                return null;
            }
        }

        private string Get_Step1_Query(string param)
        {
            string strQuery = @"
SELECT OBJECT_NAME(object_id) as SP_Name, OBJECT_DEFINITION(object_id) as SP_Content
FROM sys.procedures 
WHERE OBJECT_DEFINITION(object_id) LIKE '%@PREV_DB_NAME%'
ORDER BY OBJECT_NAME(object_id)
";
            return strQuery.Replace("@PREV_DB_NAME", param);
        }

        private string Get_Step2_Query(string[] param = null, bool bSearch = true)
        {
            string strQuery = string.Empty;
            if (bSearch)
            {
                strQuery = @"
DECLARE @plant_cd nvarchar(50) = ''
SELECT @plant_cd = plant_cd
  FROM plant
 WHERE main_yn = 'Y'

CREATE TABLE #TEMP (parameter_code nvarchar(50), parameter_value nvarchar(50), remark nvarchar(200))
INSERT INTO #TEMP (parameter_code, parameter_value, remark)
SELECT parameter_code, parameter_value, parameter_remark
  FROM parameter
 WHERE UPPER(parameter_code) in (@PARAMETER)
   AND sys_plant_cd = @plant_cd

SELECT *
  FROM #TEMP

DROP TABLE #TEMP
";
                strQuery = strQuery.Replace("@PARAMETER", param[0]);
            }
            else
            {
                strQuery = @"
DECLARE @plant_cd nvarchar(50) = ''
SELECT @plant_cd = plant_cd
  FROM plant
 WHERE main_yn = 'Y'

IF NOT EXISTS (select * from parameter where parameter_code = '@PARAMETER_CODE')
BEGIN
    INSERT INTO parameter (parameter_code, parameter_value, parameter_remark, sys_plant_cd)
         VALUES ('@PARAMETER_CODE', '@PARAMETER_VALUE', '@REMARK', @plant_cd)
END
ELSE
BEGIN    
         UPDATE parameter
            SET parameter_value = '@PARAMETER_VALUE'
          WHERE parameter_code = '@PARAMETER_CODE'
            AND sys_plant_cd = @plant_cd
END

SELECT @@ROWCOUNT
";
                strQuery = strQuery.Replace("@PARAMETER_CODE", param[0]);
                strQuery = strQuery.Replace("@PARAMETER_VALUE", param[1]);
                strQuery = strQuery.Replace("@REMARK", param[2]);
            }

            return strQuery;
        }

        private string Get_Step4_Query(string[] param = null, bool bSearch = true)
        {
            string strQuery = string.Empty;
            if (bSearch)
            {
                strQuery = @"
SELECT 'Y' as 'check', TABLE_NAME as table_name, '' as condition_name, '' as condition_value
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
ORDER BY TABLE_NAME
";
            }
            else
            {
                strQuery = @"
DELETE @TABLE_NAME
";
                if (param[1] != string.Empty)
                {
                    strQuery = string.Format("{0}WHERE @CONDITION_NAME NOT IN (@CONDITION_VALUE)", strQuery);
                    strQuery = strQuery.Replace("@CONDITION_NAME", param[1]);
                    strQuery = strQuery.Replace("@CONDITION_VALUE", param[2]);
                }
                strQuery = string.Format("{0}\r\nDBCC CHECKIDENT(@TABLE_NAME, RESEED, 0)", strQuery);
                strQuery = strQuery.Replace("@TABLE_NAME", param[0]);
                strQuery = string.Format("{0}\r\n\r\nSELECT @@ROWCOUNT", strQuery);
            }
            return strQuery;
        }
    }
}