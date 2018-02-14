namespace POS_System_EF.UI
{
    partial class PurchaseReportForm
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
            this.dgvPurchaseReport = new System.Windows.Forms.DataGridView();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.purchaseDate = new System.Windows.Forms.Label();
            this.outletName = new System.Windows.Forms.Label();
            this.lblemployeeName = new System.Windows.Forms.Label();
            this.lblsupplierName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.itemListView = new System.Windows.Forms.ListView();
            this.barcodePictureBox = new System.Windows.Forms.PictureBox();
            this.PurchaseReportTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.barcodePictureBox3 = new System.Windows.Forms.PictureBox();
            this.barcodePictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).BeginInit();
            this.PurchaseReportTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPurchaseReport
            // 
            this.dgvPurchaseReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchaseReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseReport.Location = new System.Drawing.Point(604, 106);
            this.dgvPurchaseReport.Name = "dgvPurchaseReport";
            this.dgvPurchaseReport.RowHeadersVisible = false;
            this.dgvPurchaseReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseReport.Size = new System.Drawing.Size(618, 431);
            this.dgvPurchaseReport.TabIndex = 0;
            this.dgvPurchaseReport.DoubleClick += new System.EventHandler(this.dgvPurchaseReport_DoubleClick);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(865, 35);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(229, 26);
            this.txtSearchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search EmployeeName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Invoice No";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(146, 10);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(144, 26);
            this.txtInvoiceNo.TabIndex = 4;
            // 
            // purchaseDate
            // 
            this.purchaseDate.AutoSize = true;
            this.purchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDate.Location = new System.Drawing.Point(153, 49);
            this.purchaseDate.Name = "purchaseDate";
            this.purchaseDate.Size = new System.Drawing.Size(18, 20);
            this.purchaseDate.TabIndex = 5;
            this.purchaseDate.Text = "0";
            // 
            // outletName
            // 
            this.outletName.AutoSize = true;
            this.outletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outletName.Location = new System.Drawing.Point(153, 84);
            this.outletName.Name = "outletName";
            this.outletName.Size = new System.Drawing.Size(18, 20);
            this.outletName.TabIndex = 5;
            this.outletName.Text = "0";
            // 
            // lblemployeeName
            // 
            this.lblemployeeName.AutoSize = true;
            this.lblemployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployeeName.Location = new System.Drawing.Point(153, 117);
            this.lblemployeeName.Name = "lblemployeeName";
            this.lblemployeeName.Size = new System.Drawing.Size(18, 20);
            this.lblemployeeName.TabIndex = 5;
            this.lblemployeeName.Text = "0";
            // 
            // lblsupplierName
            // 
            this.lblsupplierName.AutoSize = true;
            this.lblsupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsupplierName.Location = new System.Drawing.Point(153, 149);
            this.lblsupplierName.Name = "lblsupplierName";
            this.lblsupplierName.Size = new System.Drawing.Size(18, 20);
            this.lblsupplierName.TabIndex = 5;
            this.lblsupplierName.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Outlet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "EmployeeName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Supplier Name";
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(392, 12);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(124, 23);
            this.btnPdf.TabIndex = 8;
            this.btnPdf.Text = "Make It PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Visible = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // itemListView
            // 
            this.itemListView.Location = new System.Drawing.Point(15, 189);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(501, 316);
            this.itemListView.TabIndex = 9;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.DoubleClick += new System.EventHandler(this.itemListView_DoubleClick);
            // 
            // barcodePictureBox
            // 
            this.barcodePictureBox.Location = new System.Drawing.Point(30, 36);
            this.barcodePictureBox.Name = "barcodePictureBox";
            this.barcodePictureBox.Size = new System.Drawing.Size(470, 130);
            this.barcodePictureBox.TabIndex = 10;
            this.barcodePictureBox.TabStop = false;
            this.barcodePictureBox.Visible = false;
            // 
            // PurchaseReportTabControl
            // 
            this.PurchaseReportTabControl.Controls.Add(this.tabPage1);
            this.PurchaseReportTabControl.Controls.Add(this.tabPage2);
            this.PurchaseReportTabControl.Location = new System.Drawing.Point(12, 0);
            this.PurchaseReportTabControl.Name = "PurchaseReportTabControl";
            this.PurchaseReportTabControl.SelectedIndex = 0;
            this.PurchaseReportTabControl.Size = new System.Drawing.Size(543, 537);
            this.PurchaseReportTabControl.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtInvoiceNo);
            this.tabPage1.Controls.Add(this.itemListView);
            this.tabPage1.Controls.Add(this.purchaseDate);
            this.tabPage1.Controls.Add(this.btnPdf);
            this.tabPage1.Controls.Add(this.outletName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lblemployeeName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblsupplierName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(535, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Invoice Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Controls.Add(this.barcodePictureBox3);
            this.tabPage2.Controls.Add(this.barcodePictureBox2);
            this.tabPage2.Controls.Add(this.barcodePictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(535, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BarCode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(414, 470);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // barcodePictureBox3
            // 
            this.barcodePictureBox3.Location = new System.Drawing.Point(30, 326);
            this.barcodePictureBox3.Name = "barcodePictureBox3";
            this.barcodePictureBox3.Size = new System.Drawing.Size(470, 127);
            this.barcodePictureBox3.TabIndex = 10;
            this.barcodePictureBox3.TabStop = false;
            this.barcodePictureBox3.Visible = false;
            // 
            // barcodePictureBox2
            // 
            this.barcodePictureBox2.Location = new System.Drawing.Point(30, 181);
            this.barcodePictureBox2.Name = "barcodePictureBox2";
            this.barcodePictureBox2.Size = new System.Drawing.Size(470, 127);
            this.barcodePictureBox2.TabIndex = 10;
            this.barcodePictureBox2.TabStop = false;
            this.barcodePictureBox2.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1116, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PurchaseReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 549);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.PurchaseReportTabControl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.dgvPurchaseReport);
            this.Name = "PurchaseReportForm";
            this.Text = "PurchaseReportForm";
            this.Load += new System.EventHandler(this.PurchaseReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox)).EndInit();
            this.PurchaseReportTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPurchaseReport;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label purchaseDate;
        private System.Windows.Forms.Label outletName;
        private System.Windows.Forms.Label lblemployeeName;
        private System.Windows.Forms.Label lblsupplierName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.PictureBox barcodePictureBox;
        private System.Windows.Forms.TabControl PurchaseReportTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PictureBox barcodePictureBox3;
        private System.Windows.Forms.PictureBox barcodePictureBox2;
        private System.Windows.Forms.Button btnSearch;
    }
}