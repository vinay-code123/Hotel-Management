namespace newHotelManagement
{
    partial class DashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.movingpanel = new System.Windows.Forms.Panel();
            this.btnaddroom = new Guna.UI2.WinForms.Guna2Button();
            this.btncheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btnemployee = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomerdetails = new Guna.UI2.WinForms.Guna2Button();
            this.btncustomerregis = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnminimize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uc_Employee1 = new newHotelManagement.All_User_Control.tabEmployee();
            this.customerDetails1 = new newHotelManagement.All_User_Control.CustomerDetails();
            this.uc_addroom2 = new newHotelManagement.All_User_Control.uc_addroom();
            this.uc_CustomerCheckOut1 = new newHotelManagement.All_User_Control.uc_CustomerCheckOut();
            this.uc_CustomerRegistration1 = new newHotelManagement.All_User_Control.uc_CustomerRegistration();
            this.uc_addroom1 = new newHotelManagement.All_User_Control.uc_addroom();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.movingpanel);
            this.panel1.Controls.Add(this.btnaddroom);
            this.panel1.Controls.Add(this.btncheckout);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.Controls.Add(this.btncustomerdetails);
            this.panel1.Controls.Add(this.btncustomerregis);
            this.panel1.Location = new System.Drawing.Point(44, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 125);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // movingpanel
            // 
            this.movingpanel.BackColor = System.Drawing.Color.Maroon;
            this.movingpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movingpanel.Location = new System.Drawing.Point(23, 78);
            this.movingpanel.Name = "movingpanel";
            this.movingpanel.Size = new System.Drawing.Size(185, 4);
            this.movingpanel.TabIndex = 0;
            // 
            // btnaddroom
            // 
            this.btnaddroom.BorderRadius = 26;
            this.btnaddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnaddroom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnaddroom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnaddroom.CheckedState.Parent = this.btnaddroom;
            this.btnaddroom.CustomImages.Parent = this.btnaddroom;
            this.btnaddroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnaddroom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnaddroom.ForeColor = System.Drawing.Color.White;
            this.btnaddroom.HoverState.Parent = this.btnaddroom;
            this.btnaddroom.Image = ((System.Drawing.Image)(resources.GetObject("btnaddroom.Image")));
            this.btnaddroom.Location = new System.Drawing.Point(3, 17);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.ShadowDecoration.Parent = this.btnaddroom;
            this.btnaddroom.Size = new System.Drawing.Size(236, 85);
            this.btnaddroom.TabIndex = 0;
            this.btnaddroom.Text = "Add Room";
            this.btnaddroom.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnaddroom.Click += new System.EventHandler(this.btnaddroom_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.BorderRadius = 26;
            this.btncheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncheckout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btncheckout.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btncheckout.CheckedState.Parent = this.btncheckout;
            this.btncheckout.CustomImages.Parent = this.btncheckout;
            this.btncheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btncheckout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncheckout.ForeColor = System.Drawing.Color.White;
            this.btncheckout.HoverState.Parent = this.btncheckout;
            this.btncheckout.Image = ((System.Drawing.Image)(resources.GetObject("btncheckout.Image")));
            this.btncheckout.Location = new System.Drawing.Point(503, 17);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.ShadowDecoration.Parent = this.btncheckout;
            this.btncheckout.Size = new System.Drawing.Size(236, 85);
            this.btncheckout.TabIndex = 2;
            this.btncheckout.Text = "Check Out";
            this.btncheckout.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // btnemployee
            // 
            this.btnemployee.BorderRadius = 26;
            this.btnemployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnemployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnemployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnemployee.CheckedState.Parent = this.btnemployee;
            this.btnemployee.CustomImages.Parent = this.btnemployee;
            this.btnemployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnemployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnemployee.ForeColor = System.Drawing.Color.White;
            this.btnemployee.HoverState.Parent = this.btnemployee;
            this.btnemployee.Image = ((System.Drawing.Image)(resources.GetObject("btnemployee.Image")));
            this.btnemployee.Location = new System.Drawing.Point(987, 17);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.ShadowDecoration.Parent = this.btnemployee;
            this.btnemployee.Size = new System.Drawing.Size(236, 85);
            this.btnemployee.TabIndex = 4;
            this.btnemployee.Text = "Employee";
            this.btnemployee.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btncustomerdetails
            // 
            this.btncustomerdetails.BorderRadius = 26;
            this.btncustomerdetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncustomerdetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btncustomerdetails.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btncustomerdetails.CheckedState.Parent = this.btncustomerdetails;
            this.btncustomerdetails.CustomImages.Parent = this.btncustomerdetails;
            this.btncustomerdetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btncustomerdetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncustomerdetails.ForeColor = System.Drawing.Color.White;
            this.btncustomerdetails.HoverState.Parent = this.btncustomerdetails;
            this.btncustomerdetails.Image = ((System.Drawing.Image)(resources.GetObject("btncustomerdetails.Image")));
            this.btncustomerdetails.Location = new System.Drawing.Point(745, 17);
            this.btncustomerdetails.Name = "btncustomerdetails";
            this.btncustomerdetails.ShadowDecoration.Parent = this.btncustomerdetails;
            this.btncustomerdetails.Size = new System.Drawing.Size(236, 85);
            this.btncustomerdetails.TabIndex = 3;
            this.btncustomerdetails.Text = "Customer Details";
            this.btncustomerdetails.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btncustomerdetails.Click += new System.EventHandler(this.btncustomerdetails_Click);
            // 
            // btncustomerregis
            // 
            this.btncustomerregis.BorderRadius = 26;
            this.btncustomerregis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btncustomerregis.CheckedState.FillColor = System.Drawing.Color.White;
            this.btncustomerregis.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btncustomerregis.CheckedState.Parent = this.btncustomerregis;
            this.btncustomerregis.CustomImages.Parent = this.btncustomerregis;
            this.btncustomerregis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btncustomerregis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btncustomerregis.ForeColor = System.Drawing.Color.White;
            this.btncustomerregis.HoverState.Parent = this.btncustomerregis;
            this.btncustomerregis.Image = ((System.Drawing.Image)(resources.GetObject("btncustomerregis.Image")));
            this.btncustomerregis.ImageSize = new System.Drawing.Size(17, 17);
            this.btncustomerregis.Location = new System.Drawing.Point(261, 17);
            this.btncustomerregis.Name = "btncustomerregis";
            this.btncustomerregis.ShadowDecoration.Parent = this.btncustomerregis;
            this.btncustomerregis.Size = new System.Drawing.Size(236, 85);
            this.btncustomerregis.TabIndex = 1;
            this.btncustomerregis.Text = "Customer Registration";
            this.btncustomerregis.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btncustomerregis.Click += new System.EventHandler(this.btncustomerregis_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_Employee1);
            this.panel2.Controls.Add(this.customerDetails1);
            this.panel2.Controls.Add(this.uc_addroom2);
            this.panel2.Controls.Add(this.uc_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uc_CustomerRegistration1);
            this.panel2.Controls.Add(this.uc_addroom1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(68, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 488);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.btn);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnexit
            // 
            this.btnexit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnexit.CheckedState.Parent = this.btnexit;
            this.btnexit.CustomImages.Parent = this.btnexit;
            this.btnexit.FillColor = System.Drawing.Color.White;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnexit.ForeColor = System.Drawing.Color.DimGray;
            this.btnexit.HoverState.Parent = this.btnexit;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(3, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.ShadowDecoration.Parent = this.btnexit;
            this.btnexit.Size = new System.Drawing.Size(20, 24);
            this.btnexit.TabIndex = 2;
            this.btnexit.Click += new System.EventHandler(this.cancel_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.CheckedState.Parent = this.btnminimize;
            this.btnminimize.CustomImages.Parent = this.btnminimize;
            this.btnminimize.FillColor = System.Drawing.Color.Blue;
            this.btnminimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnminimize.ForeColor = System.Drawing.Color.White;
            this.btnminimize.HoverState.Parent = this.btnminimize;
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnminimize.Location = new System.Drawing.Point(20, 12);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnminimize.ShadowDecoration.Parent = this.btnminimize;
            this.btnminimize.Size = new System.Drawing.Size(22, 24);
            this.btnminimize.TabIndex = 3;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // uc_Employee1
            // 
            this.uc_Employee1.BackColor = System.Drawing.Color.White;
            this.uc_Employee1.Location = new System.Drawing.Point(3, 3);
            this.uc_Employee1.Name = "uc_Employee1";
            this.uc_Employee1.Size = new System.Drawing.Size(1342, 583);
            this.uc_Employee1.TabIndex = 9;
            // 
            // customerDetails1
            // 
            this.customerDetails1.BackColor = System.Drawing.Color.Transparent;
            this.customerDetails1.Location = new System.Drawing.Point(17, 19);
            this.customerDetails1.Name = "customerDetails1";
            this.customerDetails1.Size = new System.Drawing.Size(1018, 436);
            this.customerDetails1.TabIndex = 8;
            // 
            // uc_addroom2
            // 
            this.uc_addroom2.BackColor = System.Drawing.Color.White;
            this.uc_addroom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addroom2.Location = new System.Drawing.Point(17, 19);
            this.uc_addroom2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uc_addroom2.Name = "uc_addroom2";
            this.uc_addroom2.Size = new System.Drawing.Size(1018, 436);
            this.uc_addroom2.TabIndex = 7;
            // 
            // uc_CustomerCheckOut1
            // 
            this.uc_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
            this.uc_CustomerCheckOut1.Location = new System.Drawing.Point(17, 19);
            this.uc_CustomerCheckOut1.Name = "uc_CustomerCheckOut1";
            this.uc_CustomerCheckOut1.Size = new System.Drawing.Size(1018, 436);
            this.uc_CustomerCheckOut1.TabIndex = 6;
            // 
            // uc_CustomerRegistration1
            // 
            this.uc_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uc_CustomerRegistration1.Location = new System.Drawing.Point(17, 19);
            this.uc_CustomerRegistration1.Name = "uc_CustomerRegistration1";
            this.uc_CustomerRegistration1.Size = new System.Drawing.Size(1018, 436);
            this.uc_CustomerRegistration1.TabIndex = 5;
            this.uc_CustomerRegistration1.Load += new System.EventHandler(this.uc_CustomerRegistration1_Load_1);
            // 
            // uc_addroom1
            // 
            this.uc_addroom1.BackColor = System.Drawing.Color.White;
            this.uc_addroom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addroom1.Location = new System.Drawing.Point(17, 19);
            this.uc_addroom1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uc_addroom1.Name = "uc_addroom1";
            this.uc_addroom1.Size = new System.Drawing.Size(1018, 436);
            this.uc_addroom1.TabIndex = 4;
            this.uc_addroom1.Load += new System.EventHandler(this.uc_addroom1_Load_3);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnexit;
        private Guna.UI2.WinForms.Guna2CircleButton btnminimize;
        private Guna.UI2.WinForms.Guna2Button btncheckout;
        private Guna.UI2.WinForms.Guna2Button btnemployee;
        private Guna.UI2.WinForms.Guna2Button btncustomerdetails;
        private Guna.UI2.WinForms.Guna2Button btncustomerregis;
        private Guna.UI2.WinForms.Guna2Button btnaddroom;
        private System.Windows.Forms.Panel movingpanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_Control.uc_addroom uc_addroom1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private All_User_Control.uc_CustomerRegistration uc_CustomerRegistration1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private All_User_Control.uc_CustomerCheckOut uc_CustomerCheckOut1;
        private All_User_Control.uc_addroom uc_addroom2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private All_User_Control.CustomerDetails customerDetails1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.tabEmployee uc_Employee1;
    }
}