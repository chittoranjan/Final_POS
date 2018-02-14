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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(402, 419);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(119, 23);
            this.btnPdf.TabIndex = 17;
            this.btnPdf.Text = "Make It Pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Visible = false;
            // 
            // itemListView
            // 
            this.itemListView.Location = new System.Drawing.Point(21, 204);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(524, 204);
            this.itemListView.TabIndex = 16;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(33, 154);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(89, 20);
            this.lblContact.TabIndex = 12;
            this.lblContact.Text = "Contact No";
            this.lblContact.Visible = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(7, 111);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(120, 20);
            this.lblCustomerName.TabIndex = 13;
            this.lblCustomerName.Text = "CustomerName";
            this.lblCustomerName.Visible = false;
            // 
            // lblOutlet
            // 
            this.lblOutlet.AutoSize = true;
            this.lblOutlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutlet.Location = new System.Drawing.Point(33, 73);
            this.lblOutlet.Name = "lblOutlet";
            this.lblOutlet.Size = new System.Drawing.Size(94, 20);
            this.lblOutlet.TabIndex = 14;
            this.lblOutlet.Text = "OutletName";
            this.lblOutlet.Visible = false;
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(47, 29);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(83, 20);
            this.lblInvoice.TabIndex = 15;
            this.lblInvoice.Text = "Invoice No";
            this.lblInvoice.Visible = false;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(136, 154);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = true;
            this.txtContactNo.Size = new System.Drawing.Size(287, 26);
            this.txtContactNo.TabIndex = 8;
            this.txtContactNo.Visible = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(136, 109);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(287, 26);
            this.txtCustomerName.TabIndex = 9;
            this.txtCustomerName.Visible = false;
            // 
            // txtOutletName
            // 
            this.txtOutletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutletName.Location = new System.Drawing.Point(136, 67);
            this.txtOutletName.Name = "txtOutletName";
            this.txtOutletName.ReadOnly = true;
            this.txtOutletName.Size = new System.Drawing.Size(287, 26);
            this.txtOutletName.TabIndex = 10;
            this.txtOutletName.Visible = false;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(136, 26);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(287, 26);
            this.txtInvoiceNo.TabIndex = 11;
            this.txtInvoiceNo.Visible = false;
            // 
            // richTextBoxSalesList
            // 
            this.richTextBoxSalesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSalesList.Location = new System.Drawing.Point(6, 12);
            this.richTextBoxSalesList.Name = "richTextBoxSalesList";
            this.richTextBoxSalesList.Size = new System.Drawing.Size(555, 445);
            this.richTextBoxSalesList.TabIndex = 7;
            this.richTextBoxSalesList.Text = "";
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesList.Location = new System.Drawing.Point(580, 82);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.Size = new System.Drawing.Size(552, 370);
            this.dgvSalesList.TabIndex = 6;
            this.dgvSalesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesList_CellDoubleClick);
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 471);
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
            this.Text = "SalesReportForm";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}