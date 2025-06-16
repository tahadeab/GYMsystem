namespace GymSystemFinalProject.Clients
{
    partial class frmAddUpdateClient
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcClientInfo = new System.Windows.Forms.TabControl();
            this.tcpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new GymSystemFinalProject.HumanResorcies.Controls.ctrlPersonCardWithFilter();
            this.tcpMembershipInfo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtEmergencyPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tcClientInfo.SuspendLayout();
            this.tcpPersonalInfo.SuspendLayout();
            this.tcpMembershipInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tcClientInfo
            // 
            this.tcClientInfo.Controls.Add(this.tcpPersonalInfo);
            this.tcClientInfo.Controls.Add(this.tcpMembershipInfo);
            this.tcClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcClientInfo.Location = new System.Drawing.Point(-3, 73);
            this.tcClientInfo.Name = "tcClientInfo";
            this.tcClientInfo.SelectedIndex = 0;
            this.tcClientInfo.Size = new System.Drawing.Size(960, 490);
            this.tcClientInfo.TabIndex = 0;
            this.tcClientInfo.SelectedIndexChanged += new System.EventHandler(this.tcClientInfo_SelectedIndexChanged);
            // 
            // tcpPersonalInfo
            // 
            this.tcpPersonalInfo.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tcpPersonalInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcpPersonalInfo.Location = new System.Drawing.Point(4, 34);
            this.tcpPersonalInfo.Name = "tcpPersonalInfo";
            this.tcpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcpPersonalInfo.Size = new System.Drawing.Size(952, 452);
            this.tcpPersonalInfo.TabIndex = 0;
            this.tcpPersonalInfo.Text = "Personla Info";
            this.tcpPersonalInfo.UseVisualStyleBackColor = true;
            this.tcpPersonalInfo.Click += new System.EventHandler(this.tcpPersonalInfo_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(4, 1);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(952, 447);
            this.ctrlPersonCardWithFilter1.TabIndex = 0;
            this.ctrlPersonCardWithFilter1.Load += new System.EventHandler(this.ctrlPersonCardWithFilter1_Load_1);
            // 
            // tcpMembershipInfo
            // 
            this.tcpMembershipInfo.Controls.Add(this.label5);
            this.tcpMembershipInfo.Controls.Add(this.pictureBox2);
            this.tcpMembershipInfo.Controls.Add(this.lblMemberID);
            this.tcpMembershipInfo.Controls.Add(this.label4);
            this.tcpMembershipInfo.Controls.Add(this.chkIsActive);
            this.tcpMembershipInfo.Controls.Add(this.txtWeight);
            this.tcpMembershipInfo.Controls.Add(this.txtEmergencyPhone);
            this.tcpMembershipInfo.Controls.Add(this.label1);
            this.tcpMembershipInfo.Controls.Add(this.label3);
            this.tcpMembershipInfo.Controls.Add(this.label2);
            this.tcpMembershipInfo.Controls.Add(this.txtLength);
            this.tcpMembershipInfo.Controls.Add(this.pictureBox1);
            this.tcpMembershipInfo.Controls.Add(this.pictureBox8);
            this.tcpMembershipInfo.Controls.Add(this.pictureBox3);
            this.tcpMembershipInfo.Location = new System.Drawing.Point(4, 34);
            this.tcpMembershipInfo.Name = "tcpMembershipInfo";
            this.tcpMembershipInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tcpMembershipInfo.Size = new System.Drawing.Size(952, 452);
            this.tcpMembershipInfo.TabIndex = 1;
            this.tcpMembershipInfo.Text = "Membership Info";
            this.tcpMembershipInfo.UseVisualStyleBackColor = true;
            this.tcpMembershipInfo.Click += new System.EventHandler(this.tcpMembershipInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 145;
            this.label5.Text = "Phone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GymSystemFinalProject.Properties.Resources.Number_321;
            this.pictureBox2.Location = new System.Drawing.Point(203, 82);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 144;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(275, 87);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(48, 25);
            this.lblMemberID.TabIndex = 143;
            this.lblMemberID.Text = "???";
            this.lblMemberID.Click += new System.EventHandler(this.lblMemberID_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 142;
            this.label4.Text = "ClientID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(280, 300);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(5);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(117, 29);
            this.chkIsActive.TabIndex = 141;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(263, 125);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtWeight.MaxLength = 50;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(283, 30);
            this.txtWeight.TabIndex = 132;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            this.txtWeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtWeight_Validating);
            // 
            // txtEmergencyPhone
            // 
            this.txtEmergencyPhone.Location = new System.Drawing.Point(263, 237);
            this.txtEmergencyPhone.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtEmergencyPhone.MaxLength = 50;
            this.txtEmergencyPhone.Name = "txtEmergencyPhone";
            this.txtEmergencyPhone.Size = new System.Drawing.Size(283, 30);
            this.txtEmergencyPhone.TabIndex = 138;
            this.txtEmergencyPhone.TextChanged += new System.EventHandler(this.txtEmergencyPhone_TextChanged);
            this.txtEmergencyPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmergencyPhone_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 134;
            this.label1.Text = "Weight:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 139;
            this.label3.Text = "Emergency ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 135;
            this.label2.Text = "Length:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(263, 177);
            this.txtLength.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtLength.MaxLength = 50;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(283, 30);
            this.txtLength.TabIndex = 133;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            this.txtLength.Validating += new System.ComponentModel.CancelEventHandler(this.txtLength_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GymSystemFinalProject.Properties.Resources.Password_32;
            this.pictureBox1.Location = new System.Drawing.Point(203, 234);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 140;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::GymSystemFinalProject.Properties.Resources.Person_32;
            this.pictureBox8.Location = new System.Drawing.Point(203, 125);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(39, 32);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 137;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GymSystemFinalProject.Properties.Resources.Password_32;
            this.pictureBox3.Location = new System.Drawing.Point(203, 174);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 136;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(949, 70);
            this.lblTitle.TabIndex = 120;
            this.lblTitle.Text = "Add New Client";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfoNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonInfoNext.Image = global::GymSystemFinalProject.Properties.Resources.Next_32;
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(807, 504);
            this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(125, 42);
            this.btnPersonInfoNext.TabIndex = 121;
            this.btnPersonInfoNext.Text = "Next";
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GymSystemFinalProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(638, 571);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 52);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::GymSystemFinalProject.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(792, 571);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 52);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 628);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPersonInfoNext);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tcClientInfo);
            this.Name = "frmAddUpdateClient";
            this.Text = "frmAddUpdateClient";
            this.Load += new System.EventHandler(this.frmAddUpdateClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tcClientInfo.ResumeLayout(false);
            this.tcpPersonalInfo.ResumeLayout(false);
            this.tcpMembershipInfo.ResumeLayout(false);
            this.tcpMembershipInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tcClientInfo;
        private System.Windows.Forms.TabPage tcpPersonalInfo;
        private System.Windows.Forms.TabPage tcpMembershipInfo;
        private HumanResorcies.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtEmergencyPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}