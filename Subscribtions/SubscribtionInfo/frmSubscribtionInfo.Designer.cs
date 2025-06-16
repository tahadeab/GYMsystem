namespace GymSystemFinalProject.Subscribtions.SubscribtionInfo
{
    partial class frmSubscribtionInfo
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
            this.ctrlSubscribtionCard1 = new GymSystemFinalProject.Subscribtions.SubscribtionInfo.ctrlSubscribtionCard();
            this.ctrlPersonCard1 = new GymSystemFinalProject.HumanResorcies.Controls.ctrlPersonCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSubscribtionCard1
            // 
            this.ctrlSubscribtionCard1.Location = new System.Drawing.Point(1, 2);
            this.ctrlSubscribtionCard1.Name = "ctrlSubscribtionCard1";
            this.ctrlSubscribtionCard1.Size = new System.Drawing.Size(846, 675);
            this.ctrlSubscribtionCard1.TabIndex = 0;
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(725, 353);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(8, 18);
            this.ctrlPersonCard1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GymSystemFinalProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(697, 685);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 48);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSubscribtionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 741);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Controls.Add(this.ctrlSubscribtionCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSubscribtionInfo";
            this.Text = "frmSubscribtionInfo";
            this.Load += new System.EventHandler(this.frmSubscribtionInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSubscribtionCard ctrlSubscribtionCard1;
        private HumanResorcies.Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button btnClose;
    }
}