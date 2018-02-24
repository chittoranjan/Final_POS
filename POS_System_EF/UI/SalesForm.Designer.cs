namespace POS_System_EF.UI
{
    partial class SalesForm
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
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSalesSummary = new System.Windows.Forms.GroupBox();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpSales = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOutlet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbShowPurchaseItem = new System.Windows.Forms.GroupBox();
            this.dgvSalesList = new System.Windows.Forms.DataGridView();
            this.gbSalesRecieving = new System.Windows.Forms.GroupBox();
            this.txtSalePriceRO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbSalesItem = new System.Windows.Forms.ComboBox();
            this.txtSalesQty = new System.Windows.Forms.TextBox();
            this.btnSalesAdd = new System.Windows.Forms.Button();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbCustomerDetails.SuspendLayout();
            this.gbSalesSummary.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.gbShowPurchaseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).BeginInit();
            this.gbSalesRecieving.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 66);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Summary";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(100, 25);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(73, 26);
            this.txtStock.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 20);
            this.label16.TabIndex = 9;
            this.label16.Text = "Stock";
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Controls.Add(this.lblCustomerId);
            this.gbCustomerDetails.Controls.Add(this.txtCustomerName);
            this.gbCustomerDetails.Controls.Add(this.txtContactNo);
            this.gbCustomerDetails.Controls.Add(this.label12);
            this.gbCustomerDetails.Controls.Add(this.label13);
            this.gbCustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerDetails.Location = new System.Drawing.Point(593, 301);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Size = new System.Drawing.Size(463, 109);
            this.gbCustomerDetails.TabIndex = 39;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Summary";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(394, 26);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(0, 16);
            this.lblCustomerId.TabIndex = 32;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(190, 68);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(198, 22);
            this.txtCustomerName.TabIndex = 15;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(190, 21);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(198, 22);
            this.txtContactNo.TabIndex = 15;
            this.txtContactNo.Leave += new System.EventHandler(this.txtContactNo_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(132, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(89, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Contact No";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(366, 576);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(101, 26);
            this.txtTotalAmount.TabIndex = 33;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(923, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 35);
            this.button4.TabIndex = 40;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(821, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // gbSalesSummary
            // 
            this.gbSalesSummary.Controls.Add(this.lblVat);
            this.gbSalesSummary.Controls.Add(this.lblTotal);
            this.gbSalesSummary.Controls.Add(this.txtDiscount);
            this.gbSalesSummary.Controls.Add(this.label15);
            this.gbSalesSummary.Controls.Add(this.txtVat);
            this.gbSalesSummary.Controls.Add(this.txtSubTotal);
            this.gbSalesSummary.Controls.Add(this.label6);
            this.gbSalesSummary.Controls.Add(this.label11);
            this.gbSalesSummary.Controls.Add(this.label10);
            this.gbSalesSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalesSummary.Location = new System.Drawing.Point(597, 416);
            this.gbSalesSummary.Name = "gbSalesSummary";
            this.gbSalesSummary.Size = new System.Drawing.Size(463, 137);
            this.gbSalesSummary.TabIndex = 37;
            this.gbSalesSummary.TabStop = false;
            this.gbSalesSummary.Text = "Sales Summary";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(290, 81);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(15, 16);
            this.lblVat.TabIndex = 33;
            this.lblVat.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(183, 112);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 16);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "0";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(183, 49);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(125, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Total";
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(183, 78);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(100, 22);
            this.txtVat.TabIndex = 15;
            this.txtVat.Leave += new System.EventHandler(this.txtVat_Leave);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(183, 18);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubTotal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(131, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Vat ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Sub Total";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtRemarks);
            this.gbDetails.Controls.Add(this.dtpSales);
            this.gbDetails.Controls.Add(this.cmbEmployee);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.cmbOutlet);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(594, 97);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(466, 198);
            this.gbDetails.TabIndex = 36;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Information Details";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(183, 149);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(206, 26);
            this.txtRemarks.TabIndex = 9;
            // 
            // dtpSales
            // 
            this.dtpSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSales.Location = new System.Drawing.Point(183, 105);
            this.dtpSales.Name = "dtpSales";
            this.dtpSales.Size = new System.Drawing.Size(206, 26);
            this.dtpSales.TabIndex = 12;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(183, 65);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(202, 28);
            this.cmbEmployee.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Remarks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(80, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sales Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee";
            // 
            // cmbOutlet
            // 
            this.cmbOutlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOutlet.FormattingEnabled = true;
            this.cmbOutlet.Location = new System.Drawing.Point(183, 19);
            this.cmbOutlet.Name = "cmbOutlet";
            this.cmbOutlet.Size = new System.Drawing.Size(202, 28);
            this.cmbOutlet.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Outlet";
            // 
            // gbShowPurchaseItem
            // 
            this.gbShowPurchaseItem.Controls.Add(this.dgvSalesList);
            this.gbShowPurchaseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbShowPurchaseItem.Location = new System.Drawing.Point(23, 178);
            this.gbShowPurchaseItem.Name = "gbShowPurchaseItem";
            this.gbShowPurchaseItem.Size = new System.Drawing.Size(552, 381);
            this.gbShowPurchaseItem.TabIndex = 35;
            this.gbShowPurchaseItem.TabStop = false;
            this.gbShowPurchaseItem.Text = "Sales Details";
            // 
            // dgvSalesList
            // 
            this.dgvSalesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesList.Location = new System.Drawing.Point(3, 24);
            this.dgvSalesList.Name = "dgvSalesList";
            this.dgvSalesList.RowHeadersVisible = false;
            this.dgvSalesList.Size = new System.Drawing.Size(543, 351);
            this.dgvSalesList.TabIndex = 0;
            this.dgvSalesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesList_CellClick);
            this.dgvSalesList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSalesList_CellMouseClick);
            // 
            // gbSalesRecieving
            // 
            this.gbSalesRecieving.Controls.Add(this.txtSalePriceRO);
            this.gbSalesRecieving.Controls.Add(this.label1);
            this.gbSalesRecieving.Controls.Add(this.btnClear);
            this.gbSalesRecieving.Controls.Add(this.cmbSalesItem);
            this.gbSalesRecieving.Controls.Add(this.txtSalesQty);
            this.gbSalesRecieving.Controls.Add(this.btnSalesAdd);
            this.gbSalesRecieving.Controls.Add(this.txtSalePrice);
            this.gbSalesRecieving.Controls.Add(this.label3);
            this.gbSalesRecieving.Controls.Add(this.label2);
            this.gbSalesRecieving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalesRecieving.Location = new System.Drawing.Point(23, 18);
            this.gbSalesRecieving.Name = "gbSalesRecieving";
            this.gbSalesRecieving.Size = new System.Drawing.Size(1037, 73);
            this.gbSalesRecieving.TabIndex = 34;
            this.gbSalesRecieving.TabStop = false;
            this.gbSalesRecieving.Text = "Sales";
            // 
            // txtSalePriceRO
            // 
            this.txtSalePriceRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePriceRO.Location = new System.Drawing.Point(706, 31);
            this.txtSalePriceRO.Name = "txtSalePriceRO";
            this.txtSalePriceRO.ReadOnly = true;
            this.txtSalePriceRO.Size = new System.Drawing.Size(73, 26);
            this.txtSalePriceRO.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(923, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // cmbSalesItem
            // 
            this.cmbSalesItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSalesItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalesItem.FormattingEnabled = true;
            this.cmbSalesItem.Location = new System.Drawing.Point(103, 26);
            this.cmbSalesItem.Name = "cmbSalesItem";
            this.cmbSalesItem.Size = new System.Drawing.Size(204, 28);
            this.cmbSalesItem.TabIndex = 1;
            this.cmbSalesItem.SelectedIndexChanged += new System.EventHandler(this.cmbSalesItem_SelectedIndexChanged);
            // 
            // txtSalesQty
            // 
            this.txtSalesQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesQty.Location = new System.Drawing.Point(414, 29);
            this.txtSalesQty.Name = "txtSalesQty";
            this.txtSalesQty.Size = new System.Drawing.Size(100, 26);
            this.txtSalesQty.TabIndex = 2;
            // 
            // btnSalesAdd
            // 
            this.btnSalesAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.btnSalesAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesAdd.Location = new System.Drawing.Point(808, 32);
            this.btnSalesAdd.Name = "btnSalesAdd";
            this.btnSalesAdd.Size = new System.Drawing.Size(109, 26);
            this.btnSalesAdd.TabIndex = 6;
            this.btnSalesAdd.Text = "Add";
            this.btnSalesAdd.UseVisualStyleBackColor = true;
            this.btnSalesAdd.Click += new System.EventHandler(this.btnSalesAdd_Click_1);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(627, 31);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(73, 26);
            this.txtSalePrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sale Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(340, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(244, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Total Amount";
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCustomerDetails);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSalesSummary);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbShowPurchaseItem);
            this.Controls.Add(this.gbSalesRecieving);
            this.Controls.Add(this.label7);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            this.gbSalesSummary.ResumeLayout(false);
            this.gbSalesSummary.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbShowPurchaseItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesList)).EndInit();
            this.gbSalesRecieving.ResumeLayout(false);
            this.gbSalesRecieving.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbSalesSummary;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker dtpSales;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOutlet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbShowPurchaseItem;
        private System.Windows.Forms.DataGridView dgvSalesList;
        private System.Windows.Forms.GroupBox gbSalesRecieving;
        private System.Windows.Forms.TextBox txtSalePriceRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbSalesItem;
        private System.Windows.Forms.TextBox txtSalesQty;
        private System.Windows.Forms.Button btnSalesAdd;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;

    }
}