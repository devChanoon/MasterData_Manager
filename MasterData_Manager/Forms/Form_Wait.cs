using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MasterData_Manager
{
    public partial class Form_Wait : Form
    {
        public Form_Wait()
        {
            InitializeComponent();
        }

        public void Set_Description(string wait_message)
        {
            lc_Wait_Message.Text = wait_message;
        }

        public void Display(Point owner_point, Size owner_size)
        {
            int position_X = owner_point.X + ((owner_size.Width - this.Width) / 2);
            int position_Y = owner_point.Y + ((owner_size.Height - this.Height) / 2);

            this.Location = new Point(position_X, position_Y);
            this.Show();
        }
    }
}