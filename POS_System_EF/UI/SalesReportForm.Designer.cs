namespace POS_System_EF.UI
{
    partial class SalesReportForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPdf = new System.Windows.Forms.Button();
            this.itemListView = new System.Windows.Forms.ListView();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOutlet = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOutletName = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.richTextBoxSalesList = new System.Windows.Forms.RichTextBox();
            this.dgvSalesList = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchAny = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(284, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Line Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(367, 502);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 16);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "0";
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineTotal.ForeColor = System.Drawing.Color.Black;
            this.lblLineTotal.Location = new System.Drawing.Point(367, 399);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(15, 16);
            this.lblLineTotal.TabIndex = 38;
            this.lblLineTotal.Text = "0";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(367, 468);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(15, 16);
            this.lblVat.TabIndex = 37;
            this.lblVat.Text = "0";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(367, 431);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(15, 16);
            this.lblDiscount.TabIndex = 36;
            this.lblDiscount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Vat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "TotalAmount";
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(26, 488);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(129, 30);
            this.btnPdf.TabIndex = 32;
            this.btnPdf.Text = "Make It Pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Visible = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // itemListView
            // 
            this.itemListView.Location = new System.Drawing.Point(26, 164);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(400, 216);
            this.itemListView.TabIndex = 31;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(50, 131);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(89, 20);
            this.lblContact.TabIndex = 27;
            this.lblContact.Text = "Contact No";
            this.lblContact.Visible = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(19, 92);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerName.TabIndex = 28;
            this.lblCustomerName.Text = "CustomerName";
            this.lblCustomerName.Visible = false;
            // 
            // lblOutlet
            // 
            this.lblOutlet.AutoSize = true;
            this.lblOutlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutlet.Location = new System.Drawing.Point(45, 58);
            this.lblOutlet.Name = "lblOutlet";
            this.lblOutlet.Size = new System.Drawing.Size(94, 20);
            this.lblOutlet.TabIndex = 29;
            this.lblOutlet.Text = "OutletName";
            this.lblOutlet.Visible = false;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(56, 27);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(83, 20);
            this.lblInvoice.TabIndex = 30;
            this.lblInvoice.Text = "Invoice No";
            this.lblInvoice.Visible = false;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(154, 128);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(272, 26);
            this.txtContactNo.TabIndex = 23;
            this.txtContactNo.Visible = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(154, 92);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(272, 26);
            this.txtCustomerName.TabIndex = 24;
            this.txtCustomerName.Visible = false;
            // 
            // txtOutletName
            // 
            this.txtOutletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutletName.Location = new System.Drawing.Point(154, 58);
            this.txtOutletName.Name = "txtOutletName";
            this.txtOutletName.ReadOnly = true;
            this.txtOutletName.Size = new System.Drawing.Size(272, 26);
            this.txtOutletName.TabIndex = 25;
            this.txtOutletName.Visible = false;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(154, 24);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(167, 26);
            this.txtInvoiceNo.TabIndex = 26;
            this.txtInvoiceNo.Visible = false;
            // 
            // richTextBoxSalesList
            // 
            this.richTextBoxSalesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSalesList.Location = new System.Drawing.Point(9, 8);
            this.richTextBoxSalesList.Name = "richTextBoxSalesList";
            this.richTextBoxSalesList.Size = new System.Drawing.Size(435, 526);
            this.richTextBoxSalesList.TabIndex = 22;
            this.richTextBoxSalesList.Text = "";
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesList.Location = new System.Drawing.Point(459, 100);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.RowHeadersVisible = false;
            this.dgvSalesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesList.Size = new System.Drawing.Size(867, 392);
            this.dgvSalesList.TabIndex = 21;
            this.dgvSalesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesList_CellDoubleClick);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(1259, 498);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(91, 32);
            this.btnHome.TabIndex = 41;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Quick Search";
            // 
            // txtSearchAny
            // 
            this.txtSearchAny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAny.Location = new System.Drawing.Point(482, 48);
            this.txtSearchAny.Name = "txtSearchAny";
            this.txtSearchAny.Size = new System.Drawing.Size(250, 26);
            this.txtSearchAny.TabIndex = 42;
            this.txtSearchAny.TextChanged += new System.EventHandler(this.txtSearchAny_TextChanged);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 542);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchAny);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblLineTotal);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.itemListView);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblOutlet);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtOutletName);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.richTextBoxSalesList);
            this.Controls.Add(this.dgvSalesList);
            this.Name = "SalesReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReportForm";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblLineTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOutlet;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOutletName;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.RichTextBox richTextBoxSalesList;
        private System.Windows.Forms.DataGridView dgvSalesList;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchAny;
    }
}