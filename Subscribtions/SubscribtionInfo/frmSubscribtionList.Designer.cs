namespace GymSystemFinalProject.Subscribtions.SubscribtionInfo
{
    partial class frmSubscribtionList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.dgvSubscribtion = new System.Windows.Forms.DataGridView();
            this.cmsSubscribtion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrebAddNewSubscribtion = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolstribYearly = new System.Windows.Forms.ToolStripMenuItem();
            this.sub2ToolstribPro = new System.Windows.Forms.ToolStripMenuItem();
            this.sub2ToolstribDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.subToolstribMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.sub2ToolstribPromonth = new System.Windows.Forms.ToolStripMenuItem();
            this.sub2ToolstribDefaultMonth = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddSubscribtion = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribtion)).BeginInit();
            this.cmsSubscribtion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(126, 708);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(32, 24);
            this.lblRecordsCount.TabIndex = 120;
            this.lblRecordsCount.Text = "??";
            // 
            // dgvSubscribtion
            // 
            this.dgvSubscribtion.AllowUserToAddRows = false;
            this.dgvSubscribtion.AllowUserToDeleteRows = false;
            this.dgvSubscribtion.AllowUserToResizeRows = false;
            this.dgvSubscribtion.BackgroundColor = System.Drawing.Color.White;
            this.dgvSubscribtion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribtion.ContextMenuStrip = this.cmsSubscribtion;
            this.dgvSubscribtion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubscribtion.Location = new System.Drawing.Point(75, 304);
            this.dgvSubscribtion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSubscribtion.MultiSelect = false;
            this.dgvSubscribtion.Name = "dgvSubscribtion";
            this.dgvSubscribtion.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubscribtion.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubscribtion.RowHeadersWidth = 51;
            this.dgvSubscribtion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscribtion.Size = new System.Drawing.Size(892, 391);
            this.dgvSubscribtion.TabIndex = 115;
            this.dgvSubscribtion.TabStop = false;
            this.dgvSubscribtion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubscribtion_CellContentDoubleClick);
            // 
            // cmsSubscribtion
            // 
            this.cmsSubscribtion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSubscribtion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.toolStripSeparator2,
            this.ToolStrebAddNewSubscribtion,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.cmsSubscribtion.Name = "contextMenuStrip1";
            this.cmsSubscribtion.Size = new System.Drawing.Size(251, 292);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.Image = global::GymSystemFinalProject.Properties.Resources.PersonDetails_32;
            this.showDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(250, 46);
            this.showDetailsToolStripMenuItem.Text = "&Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // ToolStrebAddNewSubscribtion
            // 
            this.ToolStrebAddNewSubscribtion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subToolstribYearly,
            this.subToolstribMonthly});
            this.ToolStrebAddNewSubscribtion.Image = global::GymSystemFinalProject.Properties.Resources.Add_Person_40;
            this.ToolStrebAddNewSubscribtion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStrebAddNewSubscribtion.Name = "ToolStrebAddNewSubscribtion";
            this.ToolStrebAddNewSubscribtion.Size = new System.Drawing.Size(250, 46);
            this.ToolStrebAddNewSubscribtion.Text = "Add &New Subscribtion";
            // 
            // subToolstribYearly
            // 
            this.subToolstribYearly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub2ToolstribPro,
            this.sub2ToolstribDefault});
            this.subToolstribYearly.Name = "subToolstribYearly";
            this.subToolstribYearly.Size = new System.Drawing.Size(224, 26);
            this.subToolstribYearly.Text = "Yearly";
            // 
            // sub2ToolstribPro
            // 
            this.sub2ToolstribPro.Name = "sub2ToolstribPro";
            this.sub2ToolstribPro.Size = new System.Drawing.Size(141, 26);
            this.sub2ToolstribPro.Text = "Pro";
            this.sub2ToolstribPro.Click += new System.EventHandler(this.sub2ToolstribPro_Click);
            // 
            // sub2ToolstribDefault
            // 
            this.sub2ToolstribDefault.Name = "sub2ToolstribDefault";
            this.sub2ToolstribDefault.Size = new System.Drawing.Size(141, 26);
            this.sub2ToolstribDefault.Text = "Default";
            this.sub2ToolstribDefault.Click += new System.EventHandler(this.sub2ToolstribDefault_Click);
            // 
            // subToolstribMonthly
            // 
            this.subToolstribMonthly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub2ToolstribPromonth,
            this.sub2ToolstribDefaultMonth});
            this.subToolstribMonthly.Name = "subToolstribMonthly";
            this.subToolstribMonthly.Size = new System.Drawing.Size(224, 26);
            this.subToolstribMonthly.Text = "Monthly";
            this.subToolstribMonthly.Click += new System.EventHandler(this.subToolstribMonthly_Click);
            // 
            // sub2ToolstribPromonth
            // 
            this.sub2ToolstribPromonth.Name = "sub2ToolstribPromonth";
            this.sub2ToolstribPromonth.Size = new System.Drawing.Size(224, 26);
            this.sub2ToolstribPromonth.Text = "Pro";
            this.sub2ToolstribPromonth.Click += new System.EventHandler(this.sub2ToolstribPromonth_Click);
            // 
            // sub2ToolstribDefaultMonth
            // 
            this.sub2ToolstribDefaultMonth.Name = "sub2ToolstribDefaultMonth";
            this.sub2ToolstribDefaultMonth.Size = new System.Drawing.Size(224, 26);
            this.sub2ToolstribDefaultMonth.Text = "Default";
            this.sub2ToolstribDefaultMonth.Click += new System.EventHandler(this.sub2ToolstribDefaultMonth_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::GymSystemFinalProject.Properties.Resources.edit_32;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(250, 46);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::GymSystemFinalProject.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(250, 46);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = global::GymSystemFinalProject.Properties.Resources.send_email_32;
            this.sendEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(250, 46);
            this.sendEmailToolStripMenuItem.Text = "Send E&mail";
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = global::GymSystemFinalProject.Properties.Resources.call_32;
            this.phoneCallToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(250, 46);
            this.phoneCallToolStripMenuItem.Text = "Phone &Call";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(370, 207);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 48);
            this.lblTitle.TabIndex = 122;
            this.lblTitle.Text = "Manage Users";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 708);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 119;
            this.label2.Text = "# Records:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "SubscribtionID",
            "SubscribtionName",
            "Person ID",
            "Full Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(125, 265);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(242, 24);
            this.cbFilterBy.TabIndex = 118;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterValue.Location = new System.Drawing.Point(374, 266);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(243, 24);
            this.txtFilterValue.TabIndex = 117;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 116;
            this.label1.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GymSystemFinalProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(800, 703);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 36);
            this.btnClose.TabIndex = 124;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnAddSubscribtion
            // 
            this.btnAddSubscribtion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubscribtion.Image = global::GymSystemFinalProject.Properties.Resources.Add_New_User_72;
            this.btnAddSubscribtion.Location = new System.Drawing.Point(847, 224);
            this.btnAddSubscribtion.Name = "btnAddSubscribtion";
            this.btnAddSubscribtion.Size = new System.Drawing.Size(120, 69);
            this.btnAddSubscribtion.TabIndex = 123;
            this.btnAddSubscribtion.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAddSubscribtion.UseVisualStyleBackColor = true;
            this.btnAddSubscribtion.Click += new System.EventHandler(this.btnAddSubscribtion_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPersonImage.Image = global::GymSystemFinalProject.Properties.Resources.subscription;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(378, 9);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(261, 193);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 121;
            this.pbPersonImage.TabStop = false;
            // 
            // frmSubscribtionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 757);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.dgvSubscribtion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddSubscribtion);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPersonImage);
            this.Name = "frmSubscribtionList";
            this.Text = "frmSubscribtionList";
            this.Load += new System.EventHandler(this.frmSubscribtionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribtion)).EndInit();
            this.cmsSubscribtion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.DataGridView dgvSubscribtion;
        private System.Windows.Forms.ContextMenuStrip cmsSubscribtion;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStrebAddNewSubscribtion;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddSubscribtion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ToolStripMenuItem subToolstribYearly;
        private System.Windows.Forms.ToolStripMenuItem subToolstribMonthly;
        private System.Windows.Forms.ToolStripMenuItem sub2ToolstribPro;
        private System.Windows.Forms.ToolStripMenuItem sub2ToolstribDefault;
        private System.Windows.Forms.ToolStripMenuItem sub2ToolstribPromonth;
        private System.Windows.Forms.ToolStripMenuItem sub2ToolstribDefaultMonth;
    }
}