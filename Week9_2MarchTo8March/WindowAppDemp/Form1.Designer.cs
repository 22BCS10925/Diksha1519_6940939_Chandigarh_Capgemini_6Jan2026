namespace WindowAppDemp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmpId = new Label();
            lblEmpName = new Label();
            lblEmpDesig = new Label();
            lblEmpDOJ = new Label();
            lblEmpSalary = new Label();
            txtEmpId = new TextBox();
            txtEmpName = new TextBox();
            txtEmpDesig = new TextBox();
            txtEmpDOJ = new TextBox();
            txtEmpSalary = new TextBox();
            txtDeptNO = new TextBox();
            lblDeptNO = new Label();
            btnInsert = new Button();
            btnFind = new Button();
            btnClear = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnUpdateDB = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Location = new Point(125, 33);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(71, 15);
            lblEmpId.TabIndex = 0;
            lblEmpId.Text = "Enter EmpId";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Location = new Point(125, 67);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(93, 15);
            lblEmpName.TabIndex = 1;
            lblEmpName.Text = "Enter EmpName";
            // 
            // lblEmpDesig
            // 
            lblEmpDesig.AutoSize = true;
            lblEmpDesig.Location = new Point(125, 101);
            lblEmpDesig.Name = "lblEmpDesig";
            lblEmpDesig.Size = new Size(100, 15);
            lblEmpDesig.TabIndex = 2;
            lblEmpDesig.Text = "Enter Designation";
            // 
            // lblEmpDOJ
            // 
            lblEmpDOJ.AutoSize = true;
            lblEmpDOJ.Location = new Point(125, 137);
            lblEmpDOJ.Name = "lblEmpDOJ";
            lblEmpDOJ.Size = new Size(58, 15);
            lblEmpDOJ.TabIndex = 3;
            lblEmpDOJ.Text = "Enter DOJ";
            // 
            // lblEmpSalary
            // 
            lblEmpSalary.AutoSize = true;
            lblEmpSalary.Location = new Point(125, 172);
            lblEmpSalary.Name = "lblEmpSalary";
            lblEmpSalary.Size = new Size(68, 15);
            lblEmpSalary.TabIndex = 4;
            lblEmpSalary.Text = "Enter Salary";
            // 
            // txtEmpId
            // 
            txtEmpId.Location = new Point(331, 25);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(100, 23);
            txtEmpId.TabIndex = 5;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(331, 64);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(100, 23);
            txtEmpName.TabIndex = 6;
            // 
            // txtEmpDesig
            // 
            txtEmpDesig.Location = new Point(331, 98);
            txtEmpDesig.Name = "txtEmpDesig";
            txtEmpDesig.Size = new Size(100, 23);
            txtEmpDesig.TabIndex = 7;
            // 
            // txtEmpDOJ
            // 
            txtEmpDOJ.Location = new Point(331, 134);
            txtEmpDOJ.Name = "txtEmpDOJ";
            txtEmpDOJ.Size = new Size(100, 23);
            txtEmpDOJ.TabIndex = 8;
            // 
            // txtEmpSalary
            // 
            txtEmpSalary.Location = new Point(331, 169);
            txtEmpSalary.Name = "txtEmpSalary";
            txtEmpSalary.Size = new Size(100, 23);
            txtEmpSalary.TabIndex = 9;
            // 
            // txtDeptNO
            // 
            txtDeptNO.Location = new Point(331, 209);
            txtDeptNO.Name = "txtDeptNO";
            txtDeptNO.Size = new Size(100, 23);
            txtDeptNO.TabIndex = 10;
            // 
            // lblDeptNO
            // 
            lblDeptNO.AutoSize = true;
            lblDeptNO.Location = new Point(125, 217);
            lblDeptNO.Name = "lblDeptNO";
            lblDeptNO.Size = new Size(77, 15);
            lblDeptNO.TabIndex = 11;
            lblDeptNO.Text = "Emp DeptNO";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(125, 282);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 12;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(241, 282);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 13;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(343, 282);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(125, 358);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(241, 358);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(343, 358);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 17;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(477, 358);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(161, 23);
            btnUpdateDB.TabIndex = 18;
            btnUpdateDB.Text = "Update Into Database";
            btnUpdateDB.UseVisualStyleBackColor = true;
            btnUpdateDB.Click += btnUpdateDB_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(499, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdateDB);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnFind);
            Controls.Add(btnInsert);
            Controls.Add(lblDeptNO);
            Controls.Add(txtDeptNO);
            Controls.Add(txtEmpSalary);
            Controls.Add(txtEmpDOJ);
            Controls.Add(txtEmpDesig);
            Controls.Add(txtEmpName);
            Controls.Add(txtEmpId);
            Controls.Add(lblEmpSalary);
            Controls.Add(lblEmpDOJ);
            Controls.Add(lblEmpDesig);
            Controls.Add(lblEmpName);
            Controls.Add(lblEmpId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpId;
        private Label lblEmpName;
        private Label lblEmpDesig;
        private Label lblEmpDOJ;
        private Label lblEmpSalary;
        private TextBox txtEmpId;
        private TextBox txtEmpName;
        private TextBox txtEmpDesig;
        private TextBox txtEmpDOJ;
        private TextBox txtEmpSalary;
        private TextBox txtDeptNO;
        private Label lblDeptNO;
        private Button btnInsert;
        private Button btnFind;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Button btnUpdateDB;
        private DataGridView dataGridView1;
    }
}
