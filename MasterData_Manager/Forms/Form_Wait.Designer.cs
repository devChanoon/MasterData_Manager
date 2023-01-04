
namespace MasterData_Manager
{
    partial class Form_Wait
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Wait));
            this.tlp_Wait = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lc_Wait_Message = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp_Wait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Wait
            // 
            this.tlp_Wait.AutoSize = true;
            this.tlp_Wait.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Wait.BackColor = System.Drawing.Color.White;
            this.tlp_Wait.ColumnCount = 4;
            this.tlp_Wait.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Wait.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlp_Wait.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Wait.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Wait.Controls.Add(this.pictureBox1, 1, 1);
            this.tlp_Wait.Controls.Add(this.lc_Wait_Message, 2, 1);
            this.tlp_Wait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Wait.Location = new System.Drawing.Point(0, 0);
            this.tlp_Wait.Name = "tlp_Wait";
            this.tlp_Wait.RowCount = 3;
            this.tlp_Wait.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Wait.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Wait.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Wait.Size = new System.Drawing.Size(470, 163);
            this.tlp_Wait.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lc_Wait_Message
            // 
            this.lc_Wait_Message.Appearance.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lc_Wait_Message.Appearance.Options.UseFont = true;
            this.lc_Wait_Message.Appearance.Options.UseTextOptions = true;
            this.lc_Wait_Message.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lc_Wait_Message.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lc_Wait_Message.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lc_Wait_Message.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_Wait_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lc_Wait_Message.Location = new System.Drawing.Point(108, 23);
            this.lc_Wait_Message.Name = "lc_Wait_Message";
            this.lc_Wait_Message.Size = new System.Drawing.Size(339, 117);
            this.lc_Wait_Message.TabIndex = 1;
            this.lc_Wait_Message.Text = "Wait Message";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tlp_Wait);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 165);
            this.panel1.TabIndex = 2;
            // 
            // Form_Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 165);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Wait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tlp_Wait.ResumeLayout(false);
            this.tlp_Wait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlp_Wait;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lc_Wait_Message;
        private System.Windows.Forms.Panel panel1;
    }
}
