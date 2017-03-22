namespace SA44Team02A_SportsProject
{
    partial class PaymentForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.payableAmtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transIDInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.custIDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payBtn);
            this.groupBox1.Controls.Add(this.payableAmtInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.transIDInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(211, 283);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(450, 350);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaction Information";
            // 
            // payBtn
            // 
            this.payBtn.Location = new System.Drawing.Point(132, 271);
            this.payBtn.Margin = new System.Windows.Forms.Padding(2);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(100, 38);
            this.payBtn.TabIndex = 4;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            // 
            // payableAmtInput
            // 
            this.payableAmtInput.Location = new System.Drawing.Point(196, 161);
            this.payableAmtInput.Margin = new System.Windows.Forms.Padding(2);
            this.payableAmtInput.Name = "payableAmtInput";
            this.payableAmtInput.Size = new System.Drawing.Size(180, 30);
            this.payableAmtInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Payable Amount:";
            // 
            // transIDInput
            // 
            this.transIDInput.Location = new System.Drawing.Point(196, 95);
            this.transIDInput.Margin = new System.Windows.Forms.Padding(2);
            this.transIDInput.Name = "transIDInput";
            this.transIDInput.Size = new System.Drawing.Size(180, 30);
            this.transIDInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transaction ID:";
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(631, 236);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(2);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(100, 38);
            this.checkBtn.TabIndex = 6;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            // 
            // custIDInput
            // 
            this.custIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDInput.Location = new System.Drawing.Point(407, 240);
            this.custIDInput.Margin = new System.Windows.Forms.Padding(2);
            this.custIDInput.Name = "custIDInput";
            this.custIDInput.Size = new System.Drawing.Size(180, 30);
            this.custIDInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 243);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer ID:";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 853);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.custIDInput);
            this.Controls.Add(this.label1);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.TextBox payableAmtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox transIDInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox custIDInput;
        private System.Windows.Forms.Label label1;
    }
}