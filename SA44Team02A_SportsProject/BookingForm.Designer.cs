namespace SA44Team02A_SportsProject
{
    partial class BookingForm
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
            this.checkBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.timeUseCBox = new System.Windows.Forms.ComboBox();
            this.dateIssueDTPicker = new System.Windows.Forms.DateTimePicker();
            this.facilityCodeCBox = new System.Windows.Forms.ComboBox();
            this.bookBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.custIDInput2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custIDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(486, 188);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(100, 38);
            this.checkBtn.TabIndex = 8;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.timeUseCBox);
            this.groupBox1.Controls.Add(this.dateIssueDTPicker);
            this.groupBox1.Controls.Add(this.facilityCodeCBox);
            this.groupBox1.Controls.Add(this.bookBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.custIDInput2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(125, 291);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(633, 378);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(361, 268);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(100, 38);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // timeUseCBox
            // 
            this.timeUseCBox.FormattingEnabled = true;
            this.timeUseCBox.Items.AddRange(new object[] {
            "7am-8am",
            "8am-9am",
            "9am-10am",
            "10am-11am",
            "11am-12pm",
            "12pm-1pm",
            "1pm-2pm",
            "2pm-3pm",
            "3pm-4pm",
            "4pm-5pm",
            "5pm-6pm",
            "6pm-7pm",
            "7pm-8pm",
            "8pm-9pm",
            "9pm-10pm"});
            this.timeUseCBox.Location = new System.Drawing.Point(197, 174);
            this.timeUseCBox.Margin = new System.Windows.Forms.Padding(2);
            this.timeUseCBox.Name = "timeUseCBox";
            this.timeUseCBox.Size = new System.Drawing.Size(135, 33);
            this.timeUseCBox.TabIndex = 13;
            // 
            // dateIssueDTPicker
            // 
            this.dateIssueDTPicker.Location = new System.Drawing.Point(197, 131);
            this.dateIssueDTPicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateIssueDTPicker.Name = "dateIssueDTPicker";
            this.dateIssueDTPicker.Size = new System.Drawing.Size(135, 30);
            this.dateIssueDTPicker.TabIndex = 12;
            // 
            // facilityCodeCBox
            // 
            this.facilityCodeCBox.FormattingEnabled = true;
            this.facilityCodeCBox.Items.AddRange(new object[] {
            "Badminton",
            "Treadmill"});
            this.facilityCodeCBox.Location = new System.Drawing.Point(197, 85);
            this.facilityCodeCBox.Margin = new System.Windows.Forms.Padding(2);
            this.facilityCodeCBox.Name = "facilityCodeCBox";
            this.facilityCodeCBox.Size = new System.Drawing.Size(135, 33);
            this.facilityCodeCBox.TabIndex = 11;
            // 
            // bookBtn
            // 
            this.bookBtn.Location = new System.Drawing.Point(59, 268);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(100, 38);
            this.bookBtn.TabIndex = 10;
            this.bookBtn.Text = "Book";
            this.bookBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time Use:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date Issue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Facility Code:";
            // 
            // custIDInput2
            // 
            this.custIDInput2.Location = new System.Drawing.Point(197, 42);
            this.custIDInput2.Margin = new System.Windows.Forms.Padding(2);
            this.custIDInput2.Name = "custIDInput2";
            this.custIDInput2.Size = new System.Drawing.Size(135, 30);
            this.custIDInput2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID:";
            // 
            // custIDInput
            // 
            this.custIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDInput.Location = new System.Drawing.Point(322, 192);
            this.custIDInput.Margin = new System.Windows.Forms.Padding(2);
            this.custIDInput.Name = "custIDInput";
            this.custIDInput.Size = new System.Drawing.Size(135, 30);
            this.custIDInput.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer ID:";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.custIDInput);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.Text = "Booking";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox timeUseCBox;
        private System.Windows.Forms.DateTimePicker dateIssueDTPicker;
        private System.Windows.Forms.ComboBox facilityCodeCBox;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox custIDInput2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custIDInput;
        private System.Windows.Forms.Label label1;
    }
}