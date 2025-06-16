namespace GymSystemFinalProject.HumanResorcies
{
    partial class frmFindPersoncs
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlPersonCardWithFilter1 = new GymSystemFinalProject.HumanResorcies.Controls.ctrlPersonCardWithFilter();
            this.ctrlPersonCardWithFilter2 = new GymSystemFinalProject.HumanResorcies.Controls.ctrlPersonCardWithFilter();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(166, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 50);
            this.lblTitle.TabIndex = 102;
            this.lblTitle.Text = "Find Person Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(438, 302);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(8, 8);
            this.ctrlPersonCardWithFilter1.TabIndex = 103;
            // 
            // ctrlPersonCardWithFilter2
            // 
            this.ctrlPersonCardWithFilter2.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter2.FilterEnabled = true;
            this.ctrlPersonCardWithFilter2.Location = new System.Drawing.Point(12, 72);
            this.ctrlPersonCardWithFilter2.Name = "ctrlPersonCardWithFilter2";
            this.ctrlPersonCardWithFilter2.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter2.Size = new System.Drawing.Size(847, 361);
            this.ctrlPersonCardWithFilter2.TabIndex = 104;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GymSystemFinalProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(522, 427);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 116;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmFindPersoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 468);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonCardWithFilter2);
            this.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFindPersoncs";
            this.Text = "frmFindPersoncs";
            this.Load += new System.EventHandler(this.frmFindPersoncs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter2;
        private System.Windows.Forms.Button btnClose;
    }
}