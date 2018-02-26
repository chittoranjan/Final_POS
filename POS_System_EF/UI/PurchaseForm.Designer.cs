namespace POS_System_EF.UI
{
    partial class PurchaseForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOutlet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbShowPurchaseItem = new System.Windows.Forms.GroupBox();
            this.dgvPurchaseList = new System.Windows.Forms.DataGridView();
            this.gbPurchaseRecieving = new System.Windows.Forms.GroupBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSummary.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.gbShowPurchaseItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.gbPurchaseRecieving.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(911, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 35);
            this.button4.TabIndex = 24;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(809, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 35);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbSummary
            // 
            this.gbSummary.Controls.Add(this.label7);
            this.gbSummary.Controls.Add(this.label11);
            this.gbSummary.Controls.Add(this.lblTotalAmount);
            this.gbSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSummary.Location = new System.Drawing.Point(601, 341);
            this.gbSummary.Name = "gbSummary";
            this.gbSummary.Size = new System.Drawing.Size(397, 95);
            this.gbSummary.TabIndex = 23;
            this.gbSummary.TabStop = false;
            this.gbSummary.Text = "Purchase Summary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Total Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(246, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Amount Due";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(75, 53);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(18, 20);
            this.lblTotalAmount.TabIndex = 13;
            this.lblTotalAmount.Text = "0";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.txtRemarks);
            this.gbDetails.Controls.Add(this.dtpPurchase);
            this.gbDetails.Controls.Add(this.cmbSupplier);
            this.gbDetails.Controls.Add(this.cmbEmployee);
            this.gbDetails.Controls.Add(this.label9);
            this.gbDetails.Controls.Add(this.label8);
            this.gbDetails.Controls.Add(this.label6);
            this.gbDetails.Controls.Add(this.label5);
            this.gbDetails.Controls.Add(this.cmbOutlet);
            this.gbDetails.Controls.Add(this.label4);
            this.gbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.Location = new System.Drawing.Point(601, 91);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(397, 244);
            this.gbDetails.TabIndex = 22;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Information Details";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(143, 201);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(202, 26);
            this.txtRemarks.TabIndex = 9;
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchase.Location = new System.Drawing.Point(145, 157);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.Size = new System.Drawing.Size(200, 26);
            this.dtpPurchase.TabIndex = 12;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(145, 112);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(202, 28);
            this.cmbSupplier.TabIndex = 11;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(145, 65);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(202, 28);
            this.cmbEmployee.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Remarks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Purchase Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Employee";
            // 
            // cmbOutlet
            // 
            this.cmbOutlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOutlet.FormattingEnabled = true;
            this.cmbOutlet.Location = new System.Drawing.Point(145, 19);
            this.cmbOutlet.Name = "cmbOutlet";
            this.cmbOutlet.Size = new System.Drawing.Size(202, 28);
            this.cmbOutlet.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Outlet";
            // 
            // gbShowPurchaseItem
            // 
            this.gbShowPurchaseItem.Controls.Add(this.dgvPurchaseList);
            this.gbShowPurchaseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbShowPurchaseItem.Location = new System.Drawing.Point(30, 91);
            this.gbShowPurchaseItem.Name = "gbShowPurchaseItem";
            this.gbShowPurchaseItem.Size = new System.Drawing.Size(552, 364);
            this.gbShowPurchaseItem.TabIndex = 21;
            this.gbShowPurchaseItem.TabStop = false;
            this.gbShowPurchaseItem.Text = "Purchase Details";
            // 
            // dgvPurchaseList
            // 
            this.dgvPurchaseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseList.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPurchaseList.Location = new System.Drawing.Point(3, 22);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.RowHeadersVisible = false;
            this.dgvPurchaseList.Size = new System.Drawing.Size(543, 336);
            this.dgvPurchaseList.TabIndex = 0;
            this.dgvPurchaseList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseList_CellClick);
            // 
            // gbPurchaseRecieving
            // 
            this.gbPurchaseRecieving.Controls.Add(this.cmbItem);
            this.gbPurchaseRecieving.Controls.Add(this.label1);
            this.gbPurchaseRecieving.Controls.Add(this.btnClear);
            this.gbPurchaseRecieving.Controls.Add(this.txtQty);
            this.gbPurchaseRecieving.Controls.Add(this.btnAdd);
            this.gbPurchaseRecieving.Controls.Add(this.txtCostPrice);
            this.gbPurchaseRecieving.Controls.Add(this.label3);
            this.gbPurchaseRecieving.Controls.Add(this.label2);
            this.gbPurchaseRecieving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPurchaseRecieving.Location = new System.Drawing.Point(30, 12);
            this.gbPurchaseRecieving.Name = "gbPurchaseRecieving";
            this.gbPurchaseRecieving.Size = new System.Drawing.Size(968, 73);
            this.gbPurchaseRecieving.TabIndex = 20;
            this.gbPurchaseRecieving.TabStop = false;
            this.gbPurchaseRecieving.Text = "Purchase Receiving";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(103, 26);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(156, 28);
            this.cmbItem.TabIndex = 1;
            this.cmbItem.SelectedValueChanged += new System.EventHandler(this.cmbItem_LocationChanged);
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
            this.btnClear.Location = new System.Drawing.Point(786, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(376, 29);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 26);
            this.txtQty.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(691, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostPrice.Location = new System.Drawing.Point(570, 31);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(94, 26);
            this.txtCostPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 503);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbShowPurchaseItem);
            this.Controls.Add(this.gbPurchaseRecieving);
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseForm";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.gbSummary.ResumeLayout(false);
            this.gbSummary.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbShowPurchaseItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.gbPurchaseRecieving.ResumeLayout(false);
            this.gbPurchaseRecieving.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker dtpPurchase;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOutlet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbShowPurchaseItem;
        private System.Windows.Forms.DataGridView dgvPurchaseList;
        private System.Windows.Forms.GroupBox gbPurchaseRecieving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItem;
    }
}