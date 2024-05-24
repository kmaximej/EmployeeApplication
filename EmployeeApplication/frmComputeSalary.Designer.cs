namespace EmployeeApplication
{
    partial class Form1
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxTotalHours = new System.Windows.Forms.TextBox();
            this.textBoxRatePerHour = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.labelFN = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelJT = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelTotalWorked = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBasicSalary = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(46, 74);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(206, 32);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // textBoxTotalHours
            // 
            this.textBoxTotalHours.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalHours.Location = new System.Drawing.Point(307, 289);
            this.textBoxTotalHours.Multiline = true;
            this.textBoxTotalHours.Name = "textBoxTotalHours";
            this.textBoxTotalHours.Size = new System.Drawing.Size(206, 31);
            this.textBoxTotalHours.TabIndex = 1;
            // 
            // textBoxRatePerHour
            // 
            this.textBoxRatePerHour.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRatePerHour.Location = new System.Drawing.Point(46, 289);
            this.textBoxRatePerHour.Multiline = true;
            this.textBoxRatePerHour.Name = "textBoxRatePerHour";
            this.textBoxRatePerHour.Size = new System.Drawing.Size(206, 31);
            this.textBoxRatePerHour.TabIndex = 2;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJobTitle.Location = new System.Drawing.Point(307, 166);
            this.textBoxJobTitle.Multiline = true;
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(206, 32);
            this.textBoxJobTitle.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(307, 74);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(206, 32);
            this.textBoxLastName.TabIndex = 4;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartment.Location = new System.Drawing.Point(46, 166);
            this.textBoxDepartment.Multiline = true;
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(206, 32);
            this.textBoxDepartment.TabIndex = 5;
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFN.Location = new System.Drawing.Point(42, 52);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(90, 19);
            this.labelFN.TabIndex = 6;
            this.labelFN.Text = "First Name";
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLN.Location = new System.Drawing.Point(303, 52);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(89, 19);
            this.labelLN.TabIndex = 7;
            this.labelLN.Text = "Last Name";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDept.Location = new System.Drawing.Point(42, 144);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(101, 19);
            this.labelDept.TabIndex = 8;
            this.labelDept.Text = "Department";
            // 
            // labelJT
            // 
            this.labelJT.AutoSize = true;
            this.labelJT.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJT.Location = new System.Drawing.Point(303, 144);
            this.labelJT.Name = "labelJT";
            this.labelJT.Size = new System.Drawing.Size(72, 19);
            this.labelJT.TabIndex = 9;
            this.labelJT.Text = "Job Title";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.Location = new System.Drawing.Point(42, 267);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(112, 19);
            this.labelRate.TabIndex = 10;
            this.labelRate.Text = "Rate per hour";
            // 
            // labelTotalWorked
            // 
            this.labelTotalWorked.AutoSize = true;
            this.labelTotalWorked.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalWorked.Location = new System.Drawing.Point(303, 267);
            this.labelTotalWorked.Name = "labelTotalWorked";
            this.labelTotalWorked.Size = new System.Drawing.Size(155, 19);
            this.labelTotalWorked.TabIndex = 11;
            this.labelTotalWorked.Text = "Total hours worked";
            // 
            // buttonCompute
            // 
            this.buttonCompute.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCompute.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompute.Location = new System.Drawing.Point(190, 342);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(174, 39);
            this.buttonCompute.TabIndex = 12;
            this.buttonCompute.Text = "Compute Salary";
            this.buttonCompute.UseVisualStyleBackColor = false;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Last Name:";
            // 
            // labelBasicSalary
            // 
            this.labelBasicSalary.AutoSize = true;
            this.labelBasicSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBasicSalary.Location = new System.Drawing.Point(43, 497);
            this.labelBasicSalary.Name = "labelBasicSalary";
            this.labelBasicSalary.Size = new System.Drawing.Size(84, 17);
            this.labelBasicSalary.TabIndex = 15;
            this.labelBasicSalary.Text = "Basic Salary: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(167, 405);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(114, 17);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "<first name here>";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLast.Location = new System.Drawing.Point(167, 452);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(112, 17);
            this.labelLast.TabIndex = 17;
            this.labelLast.Text = "<last name here>";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.Location = new System.Drawing.Point(167, 497);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(39, 17);
            this.labelSalary.TabIndex = 18;
            this.labelSalary.Text = "00.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 557);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelBasicSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.labelTotalWorked);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelJT);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxJobTitle);
            this.Controls.Add(this.textBoxRatePerHour);
            this.Controls.Add(this.textBoxTotalHours);
            this.Controls.Add(this.textBoxFirstName);
            this.Name = "Form1";
            this.Text = "frmComputeSalary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxTotalHours;
        private System.Windows.Forms.TextBox textBoxRatePerHour;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelJT;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelTotalWorked;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBasicSalary;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label labelSalary;
    }
}

