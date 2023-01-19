using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraGrid;

namespace MasterData_Manager
{
    class BackgoundWorker_Manager
    {
        private enum work_type
        {
            NONE, SEARCH, UPDATE
        }

        private Sql_Manager mSql_Manager = null;
        private BackgroundWorker mBackgroundWorker = null;
        private DataTable mResult_DataTable = null;
        private int mResult_UpdateCount = 0;

        private int mStep = 0;
        private GridControl mGridControl = null;
        private List<string[]> mParameters = null;
        private DataTable mStandard_Table = null;

        private work_type mWork_Type = work_type.NONE;

        public bool IsBusy 
        {
            get { return mBackgroundWorker.IsBusy; }
        }

        public int UpdatedRowCount
        {
            get {
                int _updateRowCount = mResult_UpdateCount;
                mResult_UpdateCount = 0;
                return _updateRowCount; 
            }
        }

        public void Initialize(Sql_Manager sql_Manager)
        {
            if (sql_Manager == null)
            { 
                mBackgroundWorker = null;
                mSql_Manager = null;
            }
            else
            {
                mBackgroundWorker = new BackgroundWorker();
                mBackgroundWorker.WorkerReportsProgress = true;
                mBackgroundWorker.WorkerSupportsCancellation = true;
                mBackgroundWorker.DoWork += new DoWorkEventHandler(mBackgroundWorker_DoWork);
                mBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(mBackgroundWorker_RunWorkerCompleted);

                mSql_Manager = sql_Manager;
            }
        }

        private void mBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (mWork_Type == work_type.SEARCH)
            {
                if (mStep == 1 || mStep == 2)
                    mResult_DataTable = mSql_Manager.Sql_Execute_Search(mStep, mParameters[0][0]);
                else
                    mResult_DataTable = mSql_Manager.Sql_Execute_Search(mStep);
            }
            else if (mWork_Type == work_type.UPDATE)
            {
                foreach (string[] param in mParameters)
                {
                    try
                    { 
                        string message = mSql_Manager.Sql_Execute_Update(mStep, param);
                        if (!string.IsNullOrEmpty(message))
                            mResult_UpdateCount += Convert.ToInt32(message);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void mBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (mWork_Type == work_type.SEARCH)
            {
                if (mStep == 2)
                {
                    foreach (DataRow dr in mResult_DataTable.Rows)
                    {
                        string parameter_code = dr["parameter_code"].ToString().ToUpper();
                        for (int i = 0; i < mStandard_Table.Rows.Count; i++)
                        {
                            if (mStandard_Table.Rows[i]["parameter_code"].ToString().ToUpper() == parameter_code)
                            {
                                mStandard_Table.Rows[i]["parameter_value"] = dr["parameter_value"];
                                mStandard_Table.Rows[i]["remark"] = dr["remark"];
                                break;
                            }
                        }
                    }

                    mResult_DataTable = mStandard_Table;
                }

                if (mGridControl != null)
                    mGridControl.DataSource = mResult_DataTable;
                mResult_DataTable = null;
                mStandard_Table = null;
            }

            mWork_Type = work_type.NONE;
        }

        public void RunWorkerAsync_Search(int step, GridControl target, string search_parameter = "", DataTable standard_table = null)
        {
            mWork_Type = work_type.SEARCH;

            mStep = step;
            mGridControl = target;
            mParameters = new List<string[]>();
            mParameters.Add(new string[] { search_parameter });
            mStandard_Table = standard_table;

            mBackgroundWorker.RunWorkerAsync();
        }

        public void RunWorkerAsync_Execute(int step, List<string[]> parameters)
        {
            mWork_Type = work_type.UPDATE;

            mStep = step;
            mParameters = parameters;

            mBackgroundWorker.RunWorkerAsync();
        }
    }
}
