namespace GymSystemFinalProject.Clients
{
    partial class ctrlClientCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlPersonCard1 = new GymSystemFinalProject.HumanResorcies.Controls.ctrlPersonCard();
            this.ctrlPersonCard2 = new GymSystemFinalProject.HumanResorcies.Controls.ctrlPersonCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmrgencyPhone = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.Location = new System.Drawing.Point(5, 10);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(826, 308);
            this.ctrlPersonCard1.TabIndex = 0;
            this.ctrlPersonCard1.Load += new System.EventHandler(this.ctrlPersonCard1_Load);
            // 
            // ctrlPersonCard2
            // 
            this.ctrlPersonCard2.Location = new System.Drawing.Point(808, 435);
            this.ctrlPersonCard2.Name = "ctrlPersonCard2";
            this.ctrlPersonCard2.Size = new System.Drawing.Size(95, 15);
            this.ctrlPersonCard2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmrgencyPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblIsActive);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblMemberID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Membership Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(490, 37);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(48, 25);
            this.lblLength.TabIndex = 140;
            this.lblLength.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 139;
            this.label2.Text = "Length: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(301, 37);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(48, 25);
            this.lblWeight.TabIndex = 138;
            this.lblWeight.Text = "???";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(135, 37);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(48, 25);
            this.lblMemberID.TabIndex = 137;
            this.lblMemberID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 136;
            this.label4.Text = "Member ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 130;
            this.label1.Text = "Weight:";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(691, 38);
            this.lblIsActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(48, 25);
            this.lblIsActive.TabIndex = 142;
            this.lblIsActive.Text = "???";
            this.lblIsActive.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 141;
            this.label5.Text = "Is Active:";
            // 
            // lblEmrgencyPhone
            // 
            this.lblEmrgencyPhone.AutoSize = true;
            this.lblEmrgencyPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmrgencyPhone.Location = new System.Drawing.Point(432, 75);
            this.lblEmrgencyPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmrgencyPhone.Name = "lblEmrgencyPhone";
            this.lblEmrgencyPhone.Size = new System.Drawing.Size(48, 25);
            this.lblEmrgencyPhone.TabIndex = 144;
            this.lblEmrgencyPhone.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 143;
            this.label6.Text = "Emergency Phone:";
            // 
            // ctrlClientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersonCard2);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "ctrlClientCard";
            this.Size = new System.Drawing.Size(835, 436);
            this.Load += new System.EventHandler(this.ctrlClientCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HumanResorcies.Controls.ctrlPersonCard ctrlPersonCard1;
        private HumanResorcies.Controls.ctrlPersonCard ctrlPersonCard2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmrgencyPhone;
        private System.Windows.Forms.Label label6;
    }
}
