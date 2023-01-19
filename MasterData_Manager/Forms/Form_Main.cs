using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace MasterData_Manager
{    
    public partial class Form_Main : Form
    {
     
        private Sql_Manager m_Sql_Manager = new Sql_Manager();
        private Init_Manager m_Init_Manager = new Init_Manager();
        private BackgoundWorker_Manager m_Bworker_Manager = new BackgoundWorker_Manager();

        private int m_nStep = 1;
        private string m_strStep1_Message = "[SEARCH] 버튼을 눌러 조회해 주십시오.";
        private int m_nStep4_Unchecked_Count = 0;


        public Form_Main()
        {
            InitializeComponent();
            m_Init_Manager.Initialize();

            tb_DBAddress.Text = m_Init_Manager.INIT_DB.DB_Address;
            tb_DBName.Text = m_Init_Manager.INIT_DB.DB_Name;
            tb_ID.Text = m_Init_Manager.INIT_DB.ID;
            tb_Password.Text = m_Init_Manager.INIT_DB.Password;
        }


        private void sb_Connect_Click(object sender, EventArgs e)
        {
            if(sb_Connect.Text == "CONNECT")
            {
                string connectionString = string.Format("Server={0};database={1};uid={2};pwd={3}", tb_DBAddress.Text, tb_DBName.Text, tb_ID.Text, tb_Password.Text);
                if (m_Sql_Manager.Sql_Connect(connectionString))
                {
                    Set_DBControl_Enabled(false);

                    Set_Log("################# DB Connect Success #################");
                    sb_Connect.Text = "DISCONNECT";

                    m_Init_Manager.INIT_DB.DB_Address = tb_DBAddress.Text;
                    m_Init_Manager.INIT_DB.DB_Name = tb_DBName.Text;
                    m_Init_Manager.INIT_DB.ID = tb_ID.Text;
                    m_Init_Manager.INIT_DB.Password = tb_Password.Text;
                    m_Init_Manager.INIT_DB.Save_DB_Config();

                    m_Bworker_Manager.Initialize(m_Sql_Manager);
                }
                else
                {
                    Set_Log("################# DB Connect Fail #################");
                    sb_Connect.Text = "CONNECT";
                }
            }
            else
            {
                if (m_Sql_Manager.Sql_Disconnect())
                {
                    Set_DBControl_Enabled(true);

                    Set_Log("################# DB Disconnect Success #################");
                    sb_Connect.Text = "CONNECT";

                    m_Bworker_Manager.Initialize(null);
                }
                else
                {
                    Set_Log("################# DB Disconnect Fail #################");
                    sb_Connect.Text = "DISCONNECT";
                }
            }
        }
        private void cb_Step_Click(object sender, EventArgs e)
        {
            m_nStep = Convert.ToInt32(((DevExpress.XtraEditors.CheckButton)sender).Tag);

            cb_Step1.Checked = false;
            cb_Step2.Checked = false;
            cb_Step3.Checked = false;
            cb_Step4.Checked = false;

            tc_Step.SelectedTabPageIndex = m_nStep - 1;
            tc_Step.Update();

            if (m_nStep != 1)
                Search();
            else
                Set_Message(m_strStep1_Message);
        }
        private void sb_Search_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void sb_Execute_Click(object sender, EventArgs e)
        {
            Execute();
        }
        private void sb_Step4_CheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_Step4.RowCount; i++)
            {
                gv_Step4.SetRowCellValue(i, gc_step4_Check, "Y");
            }
        }
        private void sb_Step4_UncheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_Step4.RowCount; i++)
            {
                gv_Step4.SetRowCellValue(i, gc_step4_Check, "N");
            }
        }
        private void cbe_ViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbe_ViewPassword.Checked)
                tb_Password.UseSystemPasswordChar = false;
            else
                tb_Password.UseSystemPasswordChar = true;
        }
        private void r_ce_step4_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (gv_Step4.GetFocusedRowCellValue(gc_step4_Check).ToString() == "N")
            {
                m_nStep4_Unchecked_Count--;
                gv_Step4.SetFocusedRowCellValue(gc_step4_Check, "Y");
            }
            else
            {
                m_nStep4_Unchecked_Count++;
                gv_Step4.SetFocusedRowCellValue(gc_step4_Check, "N");
            }

            lc_Step4_Checked_Count.Text = string.Format("{0} / {1}", gv_Step4.RowCount - m_nStep4_Unchecked_Count, gv_Step4.RowCount);
        }


        private void Set_DBControl_Enabled(bool bEnabled)
        {
            tb_DBAddress.Enabled = bEnabled;
            tb_DBName.Enabled = bEnabled;
            tb_ID.Enabled = bEnabled;
            tb_Password.Enabled = bEnabled;
            if (!bEnabled)
                cbe_ViewPassword.Checked = bEnabled;
            cbe_ViewPassword.Enabled = bEnabled;

            groupBox2.Enabled = !bEnabled;
            groupBox3.Enabled = !bEnabled;
        }
        private void DB_Information_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                tb_DBAddress.Text = "sf.tascorp.co.kr";
                tb_DBName.Text = "RTEGMS_NATUREFARM";
            }
            else if (e.KeyCode == Keys.F11)
            {
                tb_DBAddress.Text = "sf.tascorp.co.kr,1444";
                tb_DBName.Text = "RTEGMS_JOONGHUN";
            }
            else if (e.KeyCode == Keys.Enter)
                sb_Connect_Click(null, null);
        }
        private void Set_Message(string strMessage = "", int nRowCount = 0)
        {
            string _strMessage = string.Empty;
            if (strMessage != string.Empty)
                _strMessage = strMessage;
            else
            {
                switch (m_nStep)
                {
                    case 1:
                        {
                            if (nRowCount == 0)
                                _strMessage = "조회 결과가 없습니다. 다음 단계를 진행해주십시오.";
                            else
                                _strMessage = string.Format("{0}건 조회되었습니다. 프로시저 수정 후 다음 단계를 진행해주십시오.", nRowCount);
                        }
                        break;
                    case 2:
                        {
                            _strMessage = string.Format("{0}건 조회되었습니다. 설정 완료 후 저장 해주십시오.", nRowCount);
                        }
                        break;
                    case 3:
                        {
                        }
                        break;
                    case 4:
                        {
                            _strMessage = string.Format("{0}건 조회되었습니다. 데이터를 삭제할 테이블 선택 후 [EXECUTE] 버튼을 눌러주십시오.", nRowCount);
                        }
                        break;
                }
            }
            lc_Message.Text = _strMessage;
            lc_Message.Update();
        }
        private void Set_Log(string LogMessage)
        {
            if (LogMessage.Contains("####"))
                tb_log.AppendText(string.Format("[{0}] {1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), LogMessage));
            else
                tb_log.AppendText(string.Format("[{0}] Step{1}. {2}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"), m_nStep, LogMessage));
        }
        private void Search()
        {
            if (m_nStep == 1 && te_Step1_Prev_DB_Name.Text == string.Empty)
            {
                MessageBox.Show("기존 DB명이 입력되지 않았습니다.");
                return;
            }

            Form_Wait fWait = new Form_Wait();
            fWait.Set_Description("조회 중 입니다.\r\n잠시만 기다려 주십시오.");
            fWait.Display(this.Location, this.Size);

            groupBox3.Enabled = false;

            string strWork = string.Empty;
            DevExpress.XtraGrid.GridControl gridControl = null;
            switch (m_nStep)
            {
                case 1:
                    strWork = string.Format("기존 DB명 : {0}", te_Step1_Prev_DB_Name.Text);
                    gridControl = gc_Step1;
                    break;
                case 2:
                    strWork = "파라미터 세팅";
                    gridControl = gc_Step2;
                    break;
                case 4:
                    strWork = "테이블 세팅";
                    gridControl = gc_Step4;
                    break;
            }

            Set_Log(string.Format("조회\r\n - {0}", strWork));
            string search_condition = string.Empty;
            if (m_nStep == 1)
                search_condition = te_Step1_Prev_DB_Name.Text;
            else if (m_nStep == 2)
            {
                foreach (Init_Manager.Step.Parameter param in m_Init_Manager.INIT_STEP.Parameters)
                {
                    search_condition += string.Format("{0}'{1}'", search_condition == string.Empty ? "" : ",", param.Parameter_Code.ToUpper());
                }
            }

            DataTable standard_table = m_nStep == 2 ? m_Init_Manager.INIT_STEP.Get_Parameters_To_Table() : null;
            m_Bworker_Manager.RunWorkerAsync_Search(m_nStep, gridControl, search_condition, standard_table);
            while (m_Bworker_Manager.IsBusy)
            {
                Application.DoEvents();
            }

            groupBox3.Enabled = true;

            int nRowCount = 0;
            switch (m_nStep)
            {
                case 1:
                    nRowCount = gv_Step1.RowCount;
                    m_strStep1_Message = lc_Message.Text;
                    break;
                case 2:
                    nRowCount = gv_Step2.RowCount;
                    break;

                case 4:
                    nRowCount = gv_Step4.RowCount;
                    m_nStep4_Unchecked_Count = 0;
                    for (int i = 0; i < gv_Step4.RowCount; i++)
                    {
                        for (int j = 0; j < m_Init_Manager.INIT_STEP.Exception_Tables.Count; j++)
                        {
                            if (m_Init_Manager.INIT_STEP.Exception_Tables[j].Table_Name.ToUpper() == gv_Step4.GetRowCellValue(i, gc_step4_Table_Name).ToString().ToUpper())
                            {
                                if (m_Init_Manager.INIT_STEP.Exception_Tables[j].Condition_Name != string.Empty)
                                {
                                    gv_Step4.SetRowCellValue(i, gc_step4_Condition_Name, m_Init_Manager.INIT_STEP.Exception_Tables[j].Condition_Name);
                                    gv_Step4.SetRowCellValue(i, gc_step4_Condition_Value, m_Init_Manager.INIT_STEP.Exception_Tables[j].Condition_Value);
                                }
                                else
                                {
                                    gv_Step4.SetRowCellValue(i, gc_step4_Check, "N");
                                    m_nStep4_Unchecked_Count++;
                                }
                            }
                        }
                    }
                    lc_Step4_Checked_Count.Text = string.Format("{0} / {1}", gv_Step4.RowCount - m_nStep4_Unchecked_Count, gv_Step4.RowCount);
                    break;
            }

            Set_Message("", nRowCount);
            fWait.Close();
        }
        private void Execute()
        {
            Form_Wait fWait = new Form_Wait();
            fWait.Set_Description("저장 중 입니다.\r\n잠시만 기다려 주십시오.");
            fWait.Display(this.Location, this.Size);

            groupBox3.Enabled = false;

            string strWork = string.Empty;
            List<string[]> lstParameters = new List<string[]>();
            switch (m_nStep)
            {
                case 2:
                    strWork = "파라미터 세팅";
                    for (int i = 0; i < gv_Step2.RowCount; i++)
                    {
                        string[] param = new string[3];
                        param[0] = gv_Step2.GetRowCellValue(i, gc_step2_Parameter_Code).ToString();
                        param[1] = gv_Step2.GetRowCellValue(i, gc_step2_Parameter_Value).ToString();
                        param[2] = gv_Step2.GetRowCellValue(i, gc_step2_Remark).ToString();
                        lstParameters.Add(param);
                    }
                    break;
                case 3:
                    break;
                case 4:
                    strWork = "테이블 세팅";
                    for (int i = 0; i < gv_Step4.RowCount; i++)
                    {
                        if (gv_Step4.GetRowCellValue(i, gc_step4_Check).ToString() == "Y")
                        {
                            string[] param = new string[3];
                            param[0] = gv_Step4.GetRowCellValue(i, gc_step4_Table_Name).ToString();
                            param[1] = gv_Step4.GetRowCellValue(i, gc_step4_Condition_Name).ToString();
                            param[2] = gv_Step4.GetRowCellValue(i, gc_step4_Condition_Value).ToString();
                            lstParameters.Add(param);
                        }
                    }
                    break;
            }

            Set_Log(string.Format("저장\r\n - {0}", strWork));
            m_Bworker_Manager.RunWorkerAsync_Execute(m_nStep, lstParameters);
            while (m_Bworker_Manager.IsBusy)
            {
                Application.DoEvents();
            }

            groupBox3.Enabled = true;

            int nUpdatedRowCount = m_Bworker_Manager.UpdatedRowCount;
            if (nUpdatedRowCount > 0)
            {
                if (m_nStep == 2 || m_nStep == 3)
                    Set_Message(string.Format("{0}건 저장되었습니다. 다음 단계를 진행해주십시오.", nUpdatedRowCount));
                else
                    Set_Message(string.Format("{0}건 삭제 되었습니다. 다시 [EXECUTE] 버튼을 눌러주십시오.", nUpdatedRowCount));
            }   
            else
                Set_Message("삭제가 완료 되었습니다. 다음 단계를 진행해주십시오.");

            fWait.Close();
        }
    }
}
