namespace POS_System_EF.UI
{
    partial class ExpenseForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalShow = new System.Windows.Forms.TextBox();
            this.txtPaidSho = new System.Windows.Forms.TextBox();
            this.txtDueShow = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.cmbOutlet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpaid = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbExpenseItem = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExpense = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTotalShow);
            this.groupBox3.Controls.Add(this.txtPaidSho);
            this.groupBox3.Controls.Add(this.txtDueShow);
            this.groupBox3.Location = new System.Drawing.Point(790, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 160);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Expense Summary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Paid";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Due";
            // 
            // txtTotalShow
            // 
            this.txtTotalShow.Location = new System.Drawing.Point(86, 30);
            this.txtTotalShow.Name = "txtTotalShow";
            this.txtTotalShow.ReadOnly = true;
            this.txtTotalShow.Size = new System.Drawing.Size(121, 20);
            this.txtTotalShow.TabIndex = 1;
            // 
            // txtPaidSho
            // 
            this.txtPaidSho.Location = new System.Drawing.Point(86, 65);
            this.txtPaidSho.Name = "txtPaidSho";
            this.txtPaidSho.ReadOnly = true;
            this.txtPaidSho.Size = new System.Drawing.Size(121, 20);
            this.txtPaidSho.TabIndex = 1;
            // 
            // txtDueShow
            // 
            this.txtDueShow.Location = new System.Drawing.Point(86, 101);
            this.txtDueShow.Name = "txtDueShow";
            this.txtDueShow.ReadOnly = true;
            this.txtDueShow.Size = new System.Drawing.Size(121, 20);
            this.txtDueShow.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker);
            this.groupBox2.Controls.Add(this.cmbEmployee);
            this.groupBox2.Controls.Add(this.cmbOrganization);
            this.groupBox2.Controls.Add(this.cmbOutlet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(451, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 225);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Info";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(91, 150);
            this.dateTimePicker.MaxDate = new System.DateTime(2018, 2, 10, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2018, 2, 10, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker.TabIndex = 11;
            this.dateTimePicker.Value = new System.DateTime(2018, 2, 10, 0, 0, 0, 0);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(91, 112);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(171, 21);
            this.cmbEmployee.TabIndex = 9;
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(91, 27);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(171, 21);
            this.cmbOrganization.TabIndex = 10;
            this.cmbOrganization.SelectionChangeCommitted += new System.EventHandler(this.cmbOrganization_SelectionChangeCommitted);
            // 
            // cmbOutlet
            // 
            this.cmbOutlet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutlet.FormattingEnabled = true;
            this.cmbOutlet.Location = new System.Drawing.Point(91, 68);
            this.cmbOutlet.Name = "cmbOutlet";
            this.cmbOutlet.Size = new System.Drawing.Size(171, 21);
            this.cmbOutlet.TabIndex = 10;
            this.cmbOutlet.SelectionChangeCommitted += new System.EventHandler(this.cmbOutlet_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Employee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Organization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "OutLet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpaid);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.cmbExpenseItem);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 225);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expense Info";
            // 
            // txtpaid
            // 
            this.txtpaid.Location = new System.Drawing.Point(113, 185);
            this.txtpaid.Name = "txtpaid";
            this.txtpaid.Size = new System.Drawing.Size(100, 20);
            this.txtpaid.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(113, 153);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(113, 121);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 7;
            // 
            // cmbExpenseItem
            // 
            this.cmbExpenseItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpenseItem.FormattingEnabled = true;
            this.cmbExpenseItem.Location = new System.Drawing.Point(113, 19);
            this.cmbExpenseItem.Name = "cmbExpenseItem";
            this.cmbExpenseItem.Size = new System.Drawing.Size(196, 21);
            this.cmbExpenseItem.TabIndex = 10;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(113, 53);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(196, 53);
            this.txtRemark.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Paid";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expense Item";
            // 
            // dgvExpense
            // 
            this.dgvExpense.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpense.Location = new System.Drawing.Point(53, 243);
            this.dgvExpense.Name = "dgvExpense";
            this.dgvExpense.RowHeadersVisible = false;
            this.dgvExpense.Size = new System.Drawing.Size(979, 163);
            this.dgvExpense.TabIndex = 13;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(858, 415);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 34);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(948, 415);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(84, 34);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(858, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(948, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(765, 183);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 34);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvExpense);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Name = "ExpenseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Form";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalShow;
        private System.Windows.Forms.TextBox txtPaidSho;
        private System.Windows.Forms.TextBox txtDueShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.ComboBox cmbOutlet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpaid;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbExpenseItem;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExpense;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
    }
}