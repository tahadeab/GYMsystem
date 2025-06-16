namespace GymSystemFinalProject
{
    partial class frm_MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Ms_Subscribtion = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_YearlyPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.proTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTrailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_MonthlyPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.proTrailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTrailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_ManageSubs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstribSubList = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Persons = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Members = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_Users = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_AccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_CurrentUser = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_ChangPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.Ms_SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.ptx_MainScreen = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_MainScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(70, 70);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ms_Subscribtion,
            this.Ms_Persons,
            this.Ms_Members,
            this.Ms_Users,
            this.Ms_AccountSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 78);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Ms_Subscribtion
            // 
            this.Ms_Subscribtion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ms_YearlyPlan,
            this.ms_MonthlyPlan,
            this.ms_ManageSubs,
            this.toolstribSubList});
            this.Ms_Subscribtion.Image = global::GymSystemFinalProject.Properties.Resources.subscription_;
            this.Ms_Subscribtion.Name = "Ms_Subscribtion";
            this.Ms_Subscribtion.Size = new System.Drawing.Size(214, 74);
            this.Ms_Subscribtion.Text = "Subscribtion";
            this.Ms_Subscribtion.Click += new System.EventHandler(this.Ms_Subscribtion_Click);
            // 
            // Ms_YearlyPlan
            // 
            this.Ms_YearlyPlan.Checked = true;
            this.Ms_YearlyPlan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ms_YearlyPlan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proTrailToolStripMenuItem,
            this.defaultTrailToolStripMenuItem});
            this.Ms_YearlyPlan.Image = global::GymSystemFinalProject.Properties.Resources.YearlyPlan;
            this.Ms_YearlyPlan.Name = "Ms_YearlyPlan";
            this.Ms_YearlyPlan.Size = new System.Drawing.Size(357, 76);
            this.Ms_YearlyPlan.Text = "Yearly Plan";
            // 
            // proTrailToolStripMenuItem
            // 
            this.proTrailToolStripMenuItem.Name = "proTrailToolStripMenuItem";
            this.proTrailToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.proTrailToolStripMenuItem.Text = "Pro trail";
            this.proTrailToolStripMenuItem.Click += new System.EventHandler(this.proTrailToolStripMenuItem_Click);
            // 
            // defaultTrailToolStripMenuItem
            // 
            this.defaultTrailToolStripMenuItem.Name = "defaultTrailToolStripMenuItem";
            this.defaultTrailToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.defaultTrailToolStripMenuItem.Text = "Default trail";
            this.defaultTrailToolStripMenuItem.Click += new System.EventHandler(this.defaultTrailToolStripMenuItem_Click);
            // 
            // ms_MonthlyPlan
            // 
            this.ms_MonthlyPlan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proTrailToolStripMenuItem1,
            this.defaultTrailToolStripMenuItem1});
            this.ms_MonthlyPlan.Image = global::GymSystemFinalProject.Properties.Resources.monthlyPlan;
            this.ms_MonthlyPlan.Name = "ms_MonthlyPlan";
            this.ms_MonthlyPlan.Size = new System.Drawing.Size(357, 76);
            this.ms_MonthlyPlan.Text = "Monthly Plan";
            this.ms_MonthlyPlan.Click += new System.EventHandler(this.monthlyPlanToolStripMenuItem_Click);
            // 
            // proTrailToolStripMenuItem1
            // 
            this.proTrailToolStripMenuItem1.Name = "proTrailToolStripMenuItem1";
            this.proTrailToolStripMenuItem1.Size = new System.Drawing.Size(214, 32);
            this.proTrailToolStripMenuItem1.Text = "Pro trail";
            this.proTrailToolStripMenuItem1.Click += new System.EventHandler(this.proTrailToolStripMenuItem1_Click);
            // 
            // defaultTrailToolStripMenuItem1
            // 
            this.defaultTrailToolStripMenuItem1.Name = "defaultTrailToolStripMenuItem1";
            this.defaultTrailToolStripMenuItem1.Size = new System.Drawing.Size(224, 32);
            this.defaultTrailToolStripMenuItem1.Text = "Default trail";
            this.defaultTrailToolStripMenuItem1.Click += new System.EventHandler(this.defaultTrailToolStripMenuItem1_Click);
            // 
            // ms_ManageSubs
            // 
            this.ms_ManageSubs.Image = global::GymSystemFinalProject.Properties.Resources.Application_Types_64;
            this.ms_ManageSubs.Name = "ms_ManageSubs";
            this.ms_ManageSubs.Size = new System.Drawing.Size(357, 76);
            this.ms_ManageSubs.Text = "Manage Subscribtions";
            this.ms_ManageSubs.Click += new System.EventHandler(this.ms_ManageSubs_Click);
            // 
            // toolstribSubList
            // 
            this.toolstribSubList.Image = global::GymSystemFinalProject.Properties.Resources.Applications;
            this.toolstribSubList.Name = "toolstribSubList";
            this.toolstribSubList.Size = new System.Drawing.Size(357, 76);
            this.toolstribSubList.Text = "Subscribtion List";
            this.toolstribSubList.Click += new System.EventHandler(this.toolstribSubList_Click);
            // 
            // Ms_Persons
            // 
            this.Ms_Persons.Image = global::GymSystemFinalProject.Properties.Resources.People11;
            this.Ms_Persons.Name = "Ms_Persons";
            this.Ms_Persons.Size = new System.Drawing.Size(259, 74);
            this.Ms_Persons.Text = "Human Resorcies";
            this.Ms_Persons.Click += new System.EventHandler(this.Ms_Persons_Click);
            // 
            // Ms_Members
            // 
            this.Ms_Members.Image = global::GymSystemFinalProject.Properties.Resources.Members;
            this.Ms_Members.Name = "Ms_Members";
            this.Ms_Members.Size = new System.Drawing.Size(184, 74);
            this.Ms_Members.Text = "Members";
            this.Ms_Members.Click += new System.EventHandler(this.Ms_Members_Click);
            // 
            // Ms_Users
            // 
            this.Ms_Users.Image = global::GymSystemFinalProject.Properties.Resources.Users11;
            this.Ms_Users.Name = "Ms_Users";
            this.Ms_Users.Size = new System.Drawing.Size(147, 74);
            this.Ms_Users.Text = "Users";
            this.Ms_Users.Click += new System.EventHandler(this.Ms_Users_Click);
            // 
            // Ms_AccountSetting
            // 
            this.Ms_AccountSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ms_CurrentUser,
            this.Ms_ChangPassword,
            this.Ms_SignOut});
            this.Ms_AccountSetting.Image = global::GymSystemFinalProject.Properties.Resources.AccountSetting;
            this.Ms_AccountSetting.Name = "Ms_AccountSetting";
            this.Ms_AccountSetting.Size = new System.Drawing.Size(248, 74);
            this.Ms_AccountSetting.Text = "Account Setting";
            this.Ms_AccountSetting.Click += new System.EventHandler(this.Ms_AccountSetting_Click);
            // 
            // Ms_CurrentUser
            // 
            this.Ms_CurrentUser.Image = global::GymSystemFinalProject.Properties.Resources.PersonDetails_32;
            this.Ms_CurrentUser.Name = "Ms_CurrentUser";
            this.Ms_CurrentUser.Size = new System.Drawing.Size(313, 76);
            this.Ms_CurrentUser.Text = "Current User Info";
            this.Ms_CurrentUser.Click += new System.EventHandler(this.Ms_CurrentUser_Click);
            // 
            // Ms_ChangPassword
            // 
            this.Ms_ChangPassword.Image = global::GymSystemFinalProject.Properties.Resources.Password_32;
            this.Ms_ChangPassword.Name = "Ms_ChangPassword";
            this.Ms_ChangPassword.Size = new System.Drawing.Size(313, 76);
            this.Ms_ChangPassword.Text = "Change Password";
            this.Ms_ChangPassword.Click += new System.EventHandler(this.Ms_ChangPassword_Click);
            // 
            // Ms_SignOut
            // 
            this.Ms_SignOut.Image = global::GymSystemFinalProject.Properties.Resources.sign_out_32__2;
            this.Ms_SignOut.Name = "Ms_SignOut";
            this.Ms_SignOut.Size = new System.Drawing.Size(313, 76);
            this.Ms_SignOut.Text = "Sign Out";
            this.Ms_SignOut.Click += new System.EventHandler(this.Ms_SignOut_Click);
            // 
            // ptx_MainScreen
            // 
            this.ptx_MainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptx_MainScreen.Image = global::GymSystemFinalProject.Properties.Resources.MainScreen3;
            this.ptx_MainScreen.Location = new System.Drawing.Point(0, 78);
            this.ptx_MainScreen.Name = "ptx_MainScreen";
            this.ptx_MainScreen.Size = new System.Drawing.Size(1107, 561);
            this.ptx_MainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptx_MainScreen.TabIndex = 2;
            this.ptx_MainScreen.TabStop = false;
            this.ptx_MainScreen.Click += new System.EventHandler(this.ptx_MainScreen_Click);
            // 
            // frm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 639);
            this.Controls.Add(this.ptx_MainScreen);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptx_MainScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Ms_Subscribtion;
        private System.Windows.Forms.ToolStripMenuItem Ms_YearlyPlan;
        private System.Windows.Forms.ToolStripMenuItem proTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultTrailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ms_MonthlyPlan;
        private System.Windows.Forms.ToolStripMenuItem proTrailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem defaultTrailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Ms_Persons;
        private System.Windows.Forms.ToolStripMenuItem Ms_Members;
        private System.Windows.Forms.ToolStripMenuItem Ms_Users;
        private System.Windows.Forms.ToolStripMenuItem Ms_AccountSetting;
        private System.Windows.Forms.ToolStripMenuItem Ms_CurrentUser;
        private System.Windows.Forms.ToolStripMenuItem Ms_ChangPassword;
        private System.Windows.Forms.ToolStripMenuItem Ms_SignOut;
        private System.Windows.Forms.PictureBox ptx_MainScreen;
        private System.Windows.Forms.ToolStripMenuItem ms_ManageSubs;
        private System.Windows.Forms.ToolStripMenuItem toolstribSubList;
    }
}

