namespace POS_System_EF.UI
{
    partial class ExpenseReportForm
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
            this.dgvExpenseReport = new System.Windows.Forms.DataGridView();
            this.PrintPriview = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtShowInvioceNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtShowDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtShowEmployee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShowOutlet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShowOrg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExpensePrint = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSrcExpense = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseReport)).BeginInit();
            this.PrintPriview.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensePrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpenseReport
            // 
            this.dgvExpenseReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseReport.Location = new System.Drawing.Point(572, 50);
            this.dgvExpenseReport.Name = "dgvExpenseReport";
            this.dgvExpenseReport.RowHeadersVisible = false;
            this.dgvExpenseReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenseReport.Size = new System.Drawing.Size(500, 399);
            this.dgvExpenseReport.TabIndex = 3;
            this.dgvExpenseReport.DoubleClick += new System.EventHandler(this.dgvExpenseReport_DoubleClick);
            // 
            // PrintPriview
            // 
            this.PrintPriview.Controls.Add(this.tabPage1);
            this.PrintPriview.Controls.Add(this.tabPage2);
            this.PrintPriview.Location = new System.Drawing.Point(12, 12);
            this.PrintPriview.Name = "PrintPriview";
            this.PrintPriview.SelectedIndex = 0;
            this.PrintPriview.Size = new System.Drawing.Size(554, 437);
            this.PrintPriview.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtShowInvioceNo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtShowDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.txtShowEmployee);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtShowOutlet);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtShowOrg);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvExpensePrint);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Print Preview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtShowInvioceNo
            // 
            this.txtShowInvioceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowInvioceNo.Location = new System.Drawing.Point(114, 11);
            this.txtShowInvioceNo.Name = "txtShowInvioceNo";
            this.txtShowInvioceNo.ReadOnly = true;
            this.txtShowInvioceNo.Size = new System.Drawing.Size(181, 23);
            this.txtShowInvioceNo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Invoice No";
            // 
            // txtShowDate
            // 
            this.txtShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowDate.Location = new System.Drawing.Point(114, 118);
            this.txtShowDate.Name = "txtShowDate";
            this.txtShowDate.ReadOnly = true;
            this.txtShowDate.Size = new System.Drawing.Size(181, 23);
            this.txtShowDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(456, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 32);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtShowEmployee
            // 
            this.txtShowEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowEmployee.Location = new System.Drawing.Point(114, 92);
            this.txtShowEmployee.Name = "txtShowEmployee";
            this.txtShowEmployee.ReadOnly = true;
            this.txtShowEmployee.Size = new System.Drawing.Size(181, 23);
            this.txtShowEmployee.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Employee";
            // 
            // txtShowOutlet
            // 
            this.txtShowOutlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowOutlet.Location = new System.Drawing.Point(114, 66);
            this.txtShowOutlet.Name = "txtShowOutlet";
            this.txtShowOutlet.ReadOnly = true;
            this.txtShowOutlet.Size = new System.Drawing.Size(181, 23);
            this.txtShowOutlet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Outlet";
            // 
            // txtShowOrg
            // 
            this.txtShowOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowOrg.Location = new System.Drawing.Point(114, 40);
            this.txtShowOrg.Name = "txtShowOrg";
            this.txtShowOrg.ReadOnly = true;
            this.txtShowOrg.Size = new System.Drawing.Size(181, 23);
            this.txtShowOrg.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Organization";
            // 
            // dgvExpensePrint
            // 
            this.dgvExpensePrint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpensePrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpensePrint.Location = new System.Drawing.Point(3, 175);
            this.dgvExpensePrint.Name = "dgvExpensePrint";
            this.dgvExpensePrint.RowHeadersVisible = false;
            this.dgvExpensePrint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpensePrint.Size = new System.Drawing.Size(534, 230);
            this.dgvExpensePrint.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bar Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(987, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtSrcExpense
            // 
            this.txtSrcExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSrcExpense.Location = new System.Drawing.Point(707, 12);
            this.txtSrcExpense.Multiline = true;
            this.txtSrcExpense.Name = "txtSrcExpense";
            this.txtSrcExpense.Size = new System.Drawing.Size(254, 32);
            this.txtSrcExpense.TabIndex = 4;
            this.txtSrcExpense.TextChanged += new System.EventHandler(this.txtSrcExpense_TextChanged);
            // 
            // ExpenseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.dgvExpenseReport);
            this.Controls.Add(this.PrintPriview);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSrcExpense);
            this.Name = "ExpenseReportForm";
            this.Text = "ExpenseReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseReport)).EndInit();
            this.PrintPriview.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpensePrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpenseReport;
        private System.Windows.Forms.TabControl PrintPriview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtShowInvioceNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtShowDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtShowEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShowOutlet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShowOrg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExpensePrint;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSrcExpense;
    }
}