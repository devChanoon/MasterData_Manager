using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Data;

namespace MasterData_Manager
{
    public class Init_Manager
    {
        public Database INIT_DB = new Database();
        public Step INIT_STEP = new Step();

        public void Initialize()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(System.Windows.Forms.Application.StartupPath, "Init"));
            FileInfo[] files = directoryInfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].Name.ToUpper().Contains("DB_CONFIG"))
                {
                    INIT_DB.Initialize_DB_Config(files[i].FullName);
                }
                else if (files[i].Name.ToUpper().Contains("STEP"))
                {   
                    INIT_STEP.InitializeStep(files[i].FullName, files[i].Name.ToUpper().Contains("STEP2") ? 2 : 3);
                }
            }
        }

        public class Database
        {
            private string mFile_Path = string.Empty;
            public string DB_Address = string.Empty;
            public string DB_Name = string.Empty;
            private string mEncrypt_ID = string.Empty;
            private string mEncrypt_Password = string.Empty;

            public string ID
            {
                get { return Decrypt(mEncrypt_ID, "ZR"); }
                set { mEncrypt_ID = Encrypt(value, "ZR"); }
            }
            public string Password 
            {
                get { return Decrypt(mEncrypt_Password, "ZR"); }
                set { mEncrypt_Password = Encrypt(value, "ZR"); } 
            }

            private string Decrypt(string cipherText, string Password)
            {
                try
                {
                    byte[] cipherBytes = Convert.FromBase64String(cipherText);
                    var pdb = new PasswordDeriveBytes(Password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65,
                                                                    0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                                                                   });

                    byte[] decryptedData = Decrypt(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
                    return Encoding.Unicode.GetString(decryptedData);
                }
                catch (FormatException e)
                {
                    return "입력된 값이 정상적으로 암호화 되지 않은 값 입니다 : " + e.Message;
                }
            }
            private byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
            {
                var ms = new MemoryStream();

                Rijndael alg = Rijndael.Create();
                alg.Key = Key;
                alg.IV = IV;
                var cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);

                cs.Write(cipherData, 0, cipherData.Length);
                cs.Close();
                byte[] decryptedData = ms.ToArray();

                return decryptedData;
            }
            private byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
            {
                var ms = new MemoryStream();
                Rijndael alg = Rijndael.Create();
                alg.Key = Key;
                alg.IV = IV;
                var cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);

                cs.Write(clearData, 0, clearData.Length);
                cs.Close();
                byte[] encryptedData = ms.ToArray();

                return encryptedData;
            }
            private string Encrypt(string clearText, string Password)
            {
                byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

                var pdb = new PasswordDeriveBytes(Password, new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                                                                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                                                                });
                byte[] encryptedData = Encrypt(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
                return Convert.ToBase64String(encryptedData);
            }

            public void Initialize_DB_Config(string target_file_path)
            {
                mFile_Path = target_file_path;

                StreamReader sr = new StreamReader(mFile_Path, Encoding.Default);
                while (sr.Peek() > -1)
                {
                    string strLine = sr.ReadLine();
                    if (strLine.Substring(0, 1) == "#")
                        continue;

                    string strField = strLine.Substring(0, strLine.IndexOf("="));
                    string strValue = strLine.Replace(strField + "=", "");

                    switch (strField)
                    {
                        case "DB_Address":
                            DB_Address = strValue;
                            break;
                        case "DB_Name":
                            DB_Name = strValue;
                            break;
                        case "ID":
                            mEncrypt_ID = strValue;
                            break;
                        case "Password":
                            mEncrypt_Password = strValue;
                            break;
                    }
                }
                sr.Close();
                sr.Dispose();
            }

            public void Save_DB_Config()
            {
                bool bFlag_DB_Address = false;
                bool bFlag_DB_Name = false;
                bool bFlag_ID = false;
                bool bFlag_Password = false;

                StringBuilder sb = new StringBuilder();
                StreamReader sr = new StreamReader(mFile_Path, Encoding.Default);
                while (sr.Peek() > -1)
                {
                    string strLine = sr.ReadLine();
                    if (strLine.Substring(0, 1) == "#")
                    {
                        sb.AppendLine(strLine);
                        continue;
                    }

                    string strContent = string.Empty;
                    string strField = strLine.Substring(0, strLine.IndexOf("="));
                    switch (strField)
                    {
                        case "DB_Address":
                            {
                                bFlag_DB_Address = true;
                                strContent = string.Format("{0}={1}", strField, DB_Address);
                            }
                            break;
                        case "DB_Name":
                            {
                                bFlag_DB_Name = true;
                                strContent = string.Format("{0}={1}", strField, DB_Name);
                            }
                            break;
                        case "ID":
                            {
                                bFlag_ID = true;
                                strContent = string.Format("{0}={1}", strField, mEncrypt_ID);
                            }
                            break;
                        case "Password":
                            {
                                bFlag_Password = true;
                                strContent = string.Format("{0}={1}", strField, mEncrypt_Password);
                            }
                            break;
                    }

                    sb.AppendLine(strContent);
                }
                sr.Close();
                sr.Dispose();

                if (!bFlag_DB_Address)
                    sb.AppendLine(string.Format("DB_Address={0}", DB_Address));

                if (!bFlag_DB_Name)
                    sb.AppendLine(string.Format("DB_Name={0}", DB_Name));

                if (!bFlag_ID)
                    sb.AppendLine(string.Format("ID={0}", mEncrypt_ID));

                if (!bFlag_Password)
                    sb.AppendLine(string.Format("Password={0}", mEncrypt_Password));

                StreamWriter sw = new StreamWriter(mFile_Path, false);
                sw.Write(sb.ToString());
                sw.Close();
                sw.Dispose();
            }
        }


        public class Step
        {
            public List<Parameter> Parameters = new List<Parameter>();
            public struct Parameter
            {
                public string Parameter_Code;
                public string Default_Value;
                public string Parameter_Remark;
            }

            public Dictionary<string, List<ConditionInfo>> ExceptionConditions = new Dictionary<string, List<ConditionInfo>>();
            public struct ConditionInfo
            {
                public string Name;
                public string Value;
            }

            public void InitializeStep(string target_file_path, int step)
            {
                if (step == 2)
                    Parameters.Clear();
                else
                    ExceptionConditions.Clear();

                StreamReader sr = new StreamReader(target_file_path, Encoding.UTF8);
                while (sr.Peek() > -1)
                {
                    string content = sr.ReadLine().Replace("\t", "").Trim();
                    if (content == string.Empty || content.Substring(0, 1) == "#")
                        continue;

                    if (step == 2)
                        AddParameters(content);
                    else
                        AddExceptionConditions(content);
                }
                sr.Close();
                sr.Dispose();
            }

            private void AddExceptionConditions(string content)
            {
                string[] contents = content.Split('/').ToArray();
                string tableName = contents[0].Trim().ToUpper();
                ConditionInfo conditionInfo = new ConditionInfo()
                {
                    Name = contents.Length > 1 ? contents[1].Trim() : string.Empty,
                    Value = contents.Length > 2 ? contents[2].Trim() : string.Empty
                };
                if (ExceptionConditions.ContainsKey(tableName))
                { 
                    if (!ExceptionConditions[tableName].Contains(conditionInfo))
                        ExceptionConditions[tableName].Add(conditionInfo);
                }
                else
                    ExceptionConditions.Add(tableName, new List<ConditionInfo>() { conditionInfo });
            }

            private void AddParameters(string content)
            {
                Parameter parameter = new Parameter();
                int splitIndex = content.IndexOf("/");
                parameter.Parameter_Code = content.Substring(0, splitIndex);

                string parameterString = content.Substring(splitIndex + 1, content.Length - (splitIndex + 1));
                splitIndex = parameterString.IndexOf("/");
                parameter.Default_Value = parameterString.Substring(0, splitIndex);
                parameter.Parameter_Remark = parameterString.Substring(splitIndex + 1, parameterString.Length - (splitIndex + 1));
                Parameters.Add(parameter);
            }

            public DataTable GetParametersToTable()
            {
                DataTable resultDt = new DataTable();
                resultDt.Columns.Add(new DataColumn("parameter_code", typeof(string)));
                resultDt.Columns.Add(new DataColumn("parameter_value", typeof(string)));
                resultDt.Columns.Add(new DataColumn("remark", typeof(string)));

                foreach (Parameter parameter in Parameters)
                {
                    DataRow dr = resultDt.NewRow();
                    dr["parameter_code"] = parameter.Parameter_Code;
                    dr["parameter_value"] = parameter.Default_Value;
                    dr["remark"] = parameter.Parameter_Remark;
                    resultDt.Rows.Add(dr);
                }

                return resultDt;
            }

            public Tuple<bool, string, string> GetExceptionConditionToString(string tableName)
            {
                string conditionName = string.Empty;
                string conditionValue = string.Empty;
                string tableNameUpper = tableName.ToUpper();
                bool isExceptionTable = ExceptionConditions.ContainsKey(tableNameUpper.ToUpper());
                if (isExceptionTable)
                {
                    const string SPLIT = " / ";
                    List<ConditionInfo> conditionInfos = ExceptionConditions[tableNameUpper];
                    foreach (ConditionInfo conditionInfo in conditionInfos)
                    {
                        conditionName += $"{conditionInfo.Name}{SPLIT}";
                        conditionValue += $"{conditionInfo.Value}{SPLIT}";
                    }

                    conditionName = conditionName.Substring(0, conditionName.Length - SPLIT.Length);
                    conditionValue = conditionValue.Substring(0, conditionValue.Length - SPLIT.Length);
                }

                return new Tuple<bool, string, string>(isExceptionTable, conditionName, conditionValue);
            }

            public string[] GetExceptionCondition(string tableName)
            {
                List<string> conditionList = new List<string>() { tableName };
                string tableNameUpper = tableName.ToUpper();
                if (ExceptionConditions.ContainsKey(tableNameUpper))
                {
                    List<ConditionInfo> conditionInfos = ExceptionConditions[tableNameUpper];
                    foreach (ConditionInfo conditionInfo in conditionInfos)
                    {
                        conditionList.Add($"{conditionInfo.Name}/{conditionInfo.Value}");
                    }
                }

                return conditionList.ToArray();
            }
        }
    }
}
