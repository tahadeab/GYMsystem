namespace GymSystemFinalProject.Subscribtions.SubscribtionInfo
{
    partial class ctrlSubscribtionCard
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
            this.ctrlClientCard1 = new GymSystemFinalProject.Clients.ctrlClientCard();
            this.gboSubscribtionInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCoachID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblremainder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEmdDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSubType = new System.Windows.Forms.Label();
            this.lblSubID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gboSubscribtionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlClientCard1
            // 
            this.ctrlClientCard1.Location = new System.Drawing.Point(3, 3);
            this.ctrlClientCard1.Name = "ctrlClientCard1";
            this.ctrlClientCard1.Size = new System.Drawing.Size(835, 436);
            this.ctrlClientCard1.TabIndex = 0;
            this.ctrlClientCard1.Load += new System.EventHandler(this.ctrlClientCard1_Load);
            // 
            // gboSubscribtionInfo
            // 
            this.gboSubscribtionInfo.Controls.Add(this.label8);
            this.gboSubscribtionInfo.Controls.Add(this.lblCoachID);
            this.gboSubscribtionInfo.Controls.Add(this.label9);
            this.gboSubscribtionInfo.Controls.Add(this.lblremainder);
            this.gboSubscribtionInfo.Controls.Add(this.label3);
            this.gboSubscribtionInfo.Controls.Add(this.lblCash);
            this.gboSubscribtionInfo.Controls.Add(this.label7);
            this.gboSubscribtionInfo.Controls.Add(this.label6);
            this.gboSubscribtionInfo.Controls.Add(this.dtpEmdDate);
            this.gboSubscribtionInfo.Controls.Add(this.label5);
            this.gboSubscribtionInfo.Controls.Add(this.dtpStartDate);
            this.gboSubscribtionInfo.Controls.Add(this.label4);
            this.gboSubscribtionInfo.Controls.Add(this.lblTotalPrice);
            this.gboSubscribtionInfo.Controls.Add(this.lblSubType);
            this.gboSubscribtionInfo.Controls.Add(this.lblSubID);
            this.gboSubscribtionInfo.Controls.Add(this.label1);
            this.gboSubscribtionInfo.Location = new System.Drawing.Point(14, 445);
            this.gboSubscribtionInfo.Name = "gboSubscribtionInfo";
            this.gboSubscribtionInfo.Size = new System.Drawing.Size(824, 246);
            this.gboSubscribtionInfo.TabIndex = 1;
            this.gboSubscribtionInfo.TabStop = false;
            this.gboSubscribtionInfo.Text = "SubscribtionInfo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Coach ID:";
            // 
            // lblCoachID
            // 
            this.lblCoachID.AutoSize = true;
            this.lblCoachID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoachID.Location = new System.Drawing.Point(609, 175);
            this.lblCoachID.Name = "lblCoachID";
            this.lblCoachID.Size = new System.Drawing.Size(48, 25);
            this.lblCoachID.TabIndex = 14;
            this.lblCoachID.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Remainder:";
            // 
            // lblremainder
            // 
            this.lblremainder.AutoSize = true;
            this.lblremainder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremainder.Location = new System.Drawing.Point(614, 128);
            this.lblremainder.Name = "lblremainder";
            this.lblremainder.Size = new System.Drawing.Size(48, 25);
            this.lblremainder.TabIndex = 12;
            this.lblremainder.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cash: ";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(578, 82);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(48, 25);
            this.lblCash.TabIndex = 10;
            this.lblCash.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "End Date:";
            // 
            // dtpEmdDate
            // 
            this.dtpEmdDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmdDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmdDate.Location = new System.Drawing.Point(157, 175);
            this.dtpEmdDate.Name = "dtpEmdDate";
            this.dtpEmdDate.Size = new System.Drawing.Size(118, 29);
            this.dtpEmdDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(154, 128);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(118, 29);
            this.dtpStartDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "SubScribtion Type: ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(614, 33);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(48, 25);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "???";
            // 
            // lblSubType
            // 
            this.lblSubType.AutoSize = true;
            this.lblSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubType.Location = new System.Drawing.Point(224, 82);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(48, 25);
            this.lblSubType.TabIndex = 2;
            this.lblSubType.Text = "???";
            // 
            // lblSubID
            // 
            this.lblSubID.AutoSize = true;
            this.lblSubID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubID.Location = new System.Drawing.Point(182, 33);
            this.lblSubID.Name = "lblSubID";
            this.lblSubID.Size = new System.Drawing.Size(48, 25);
            this.lblSubID.TabIndex = 1;
            this.lblSubID.Text = "???";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subscribtion ID: ";
            // 
            // ctrlSubscribtionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gboSubscribtionInfo);
            this.Controls.Add(this.ctrlClientCard1);
            this.Name = "ctrlSubscribtionCard";
            this.Size = new System.Drawing.Size(845, 701);
            this.gboSubscribtionInfo.ResumeLayout(false);
            this.gboSubscribtionInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Clients.ctrlClientCard ctrlClientCard1;
        private System.Windows.Forms.GroupBox gboSubscribtionInfo;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.Label lblSubID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEmdDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCoachID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblremainder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCash;
    }
}
