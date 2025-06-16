namespace GymSystemFinalProject.Clients
{
    partial class frmClinetInfo
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
            this.ctrlClientCard1 = new GymSystemFinalProject.Clients.ctrlClientCard();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlClientCard1
            // 
            this.ctrlClientCard1.Location = new System.Drawing.Point(-2, 1);
            this.ctrlClientCard1.Name = "ctrlClientCard1";
            this.ctrlClientCard1.Size = new System.Drawing.Size(835, 436);
            this.ctrlClientCard1.TabIndex = 0;
            this.ctrlClientCard1.Load += new System.EventHandler(this.ctrlClientCard1_Load);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::GymSystemFinalProject.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(640, 431);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 48);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmClinetInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 485);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlClientCard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmClinetInfo";
            this.Text = "frmClinetInfo";
            this.Load += new System.EventHandler(this.frmClinetInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlClientCard ctrlClientCard1;
        private System.Windows.Forms.Button btnClose;
    }
}