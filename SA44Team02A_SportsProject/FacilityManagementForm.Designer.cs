namespace SA44Team02A_SportsProject
{
    partial class FacilityManagementForm
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
            this.statusInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.rentalCostInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numRentedInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalStockInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timeIDInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.facilityNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.createBtn);
            this.groupBox1.Controls.Add(this.rentalCostInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numRentedInput);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.totalStockInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.timeIDInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.facilityNameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(85, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(500, 436);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detailed Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // statusInput
            // 
            this.statusInput.Location = new System.Drawing.Point(181, 311);
            this.statusInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusInput.Name = "statusInput";
            this.statusInput.Size = new System.Drawing.Size(150, 30);
            this.statusInput.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(163, 384);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(100, 38);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // rentalCostInput
            // 
            this.rentalCostInput.Location = new System.Drawing.Point(181, 256);
            this.rentalCostInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rentalCostInput.Name = "rentalCostInput";
            this.rentalCostInput.Size = new System.Drawing.Size(150, 30);
            this.rentalCostInput.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "RentalCost:";
            // 
            // numRentedInput
            // 
            this.numRentedInput.Location = new System.Drawing.Point(181, 201);
            this.numRentedInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numRentedInput.Name = "numRentedInput";
            this.numRentedInput.Size = new System.Drawing.Size(150, 30);
            this.numRentedInput.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 204);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "NumberRented:";
            // 
            // totalStockInput
            // 
            this.totalStockInput.Location = new System.Drawing.Point(181, 146);
            this.totalStockInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalStockInput.Name = "totalStockInput";
            this.totalStockInput.Size = new System.Drawing.Size(150, 30);
            this.totalStockInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "TotalStock:";
            // 
            // timeIDInput
            // 
            this.timeIDInput.Location = new System.Drawing.Point(181, 91);
            this.timeIDInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeIDInput.Name = "timeIDInput";
            this.timeIDInput.Size = new System.Drawing.Size(150, 30);
            this.timeIDInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time ID:";
            // 
            // facilityNameInput
            // 
            this.facilityNameInput.Location = new System.Drawing.Point(181, 36);
            this.facilityNameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.facilityNameInput.Name = "facilityNameInput";
            this.facilityNameInput.Size = new System.Drawing.Size(150, 30);
            this.facilityNameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Facility Name:";
            // 
            // FacilityManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 595);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacilityManagementForm";
            this.Text = "FacilityManagementForm";
            this.Load += new System.EventHandler(this.FacilityManagementForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox statusInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox rentalCostInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numRentedInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalStockInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timeIDInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox facilityNameInput;
        private System.Windows.Forms.Label label2;
    }
}