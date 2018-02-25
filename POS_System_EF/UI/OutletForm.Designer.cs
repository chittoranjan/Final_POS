namespace POS_System_EF.UI
{
    partial class OutletForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutletForm));
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.txtQuickSrc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOutlet = new System.Windows.Forms.DataGridView();
            this.buttonHome = new System.Windows.Forms.Button();
            this.tabControlOutlet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxAddOraganization = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textCodeManual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOutletName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOrganizationName = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtOutletCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtShowOrgName = new System.Windows.Forms.TextBox();
            this.txtShowOutletName = new System.Windows.Forms.TextBox();
            this.txtShowAddress = new System.Windows.Forms.TextBox();
            this.txtShowContactNo = new System.Windows.Forms.TextBox();
            this.txtShowOutletCode = new System.Windows.Forms.TextBox();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).BeginInit();
            this.tabControlOutlet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxAddOraganization.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.Controls.Add(this.btnClear);
            this.groupBoxShow.Controls.Add(this.txtSearchCode);
            this.groupBoxShow.Controls.Add(this.txtQuickSrc);
            this.groupBoxShow.Controls.Add(this.label8);
            this.groupBoxShow.Controls.Add(this.label6);
            this.groupBoxShow.Controls.Add(this.dgvOutlet);
            this.groupBoxShow.Location = new System.Drawing.Point(446, 25);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Size = new System.Drawing.Size(637, 394);
            this.groupBoxShow.TabIndex = 10;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "Show Group Box";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(551, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(69, 26);
            this.btnClear.TabIndex = 129;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCode.Location = new System.Drawing.Point(402, 20);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(133, 26);
            this.txtSearchCode.TabIndex = 128;
            this.txtSearchCode.TextChanged += new System.EventHandler(this.txtSearchCode_TextChanged);
            // 
            // txtQuickSrc
            // 
            this.txtQuickSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuickSrc.Location = new System.Drawing.Point(118, 23);
            this.txtQuickSrc.Name = "txtQuickSrc";
            this.txtQuickSrc.Size = new System.Drawing.Size(139, 26);
            this.txtQuickSrc.TabIndex = 28;
            this.txtQuickSrc.TextChanged += new System.EventHandler(this.txtQuickSrc_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(274, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Search by Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Quick Search";
            // 
            // dgvOutlet
            // 
            this.dgvOutlet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutlet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutlet.Location = new System.Drawing.Point(12, 59);
            this.dgvOutlet.Name = "dgvOutlet";
            this.dgvOutlet.RowHeadersVisible = false;
            this.dgvOutlet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutlet.Size = new System.Drawing.Size(614, 329);
            this.dgvOutlet.TabIndex = 4;
            this.dgvOutlet.DoubleClick += new System.EventHandler(this.dgvOutlet_DoubleClick);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(997, 426);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 2;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // tabControlOutlet
            // 
            this.tabControlOutlet.Controls.Add(this.tabPage1);
            this.tabControlOutlet.Controls.Add(this.tabPage2);
            this.tabControlOutlet.Location = new System.Drawing.Point(8, 13);
            this.tabControlOutlet.Name = "tabControlOutlet";
            this.tabControlOutlet.SelectedIndex = 0;
            this.tabControlOutlet.Size = new System.Drawing.Size(432, 436);
            this.tabControlOutlet.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxAddOraganization);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddOraganization
            // 
            this.groupBoxAddOraganization.Controls.Add(this.btnDelete);
            this.groupBoxAddOraganization.Controls.Add(this.textCodeManual);
            this.groupBoxAddOraganization.Controls.Add(this.label7);
            this.groupBoxAddOraganization.Controls.Add(this.textBoxOutletName);
            this.groupBoxAddOraganization.Controls.Add(this.label4);
            this.groupBoxAddOraganization.Controls.Add(this.cmbOrganizationName);
            this.groupBoxAddOraganization.Controls.Add(this.buttonClear);
            this.groupBoxAddOraganization.Controls.Add(this.btnSave);
            this.groupBoxAddOraganization.Controls.Add(this.txtAddress);
            this.groupBoxAddOraganization.Controls.Add(this.txtContactNo);
            this.groupBoxAddOraganization.Controls.Add(this.txtOutletCode);
            this.groupBoxAddOraganization.Controls.Add(this.label5);
            this.groupBoxAddOraganization.Controls.Add(this.label3);
            this.groupBoxAddOraganization.Controls.Add(this.label2);
            this.groupBoxAddOraganization.Controls.Add(this.label1);
            this.groupBoxAddOraganization.Location = new System.Drawing.Point(11, 5);
            this.groupBoxAddOraganization.Name = "groupBoxAddOraganization";
            this.groupBoxAddOraganization.Size = new System.Drawing.Size(402, 401);
            this.groupBoxAddOraganization.TabIndex = 10;
            this.groupBoxAddOraganization.TabStop = false;
            this.groupBoxAddOraganization.Text = "Add Outlet";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 130;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textCodeManual
            // 
            this.textCodeManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodeManual.Location = new System.Drawing.Point(176, 140);
            this.textCodeManual.Name = "textCodeManual";
            this.textCodeManual.Size = new System.Drawing.Size(104, 26);
            this.textCodeManual.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(127, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "+88 -";
            // 
            // textBoxOutletName
            // 
            this.textBoxOutletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutletName.Location = new System.Drawing.Point(176, 85);
            this.textBoxOutletName.Name = "textBoxOutletName";
            this.textBoxOutletName.Size = new System.Drawing.Size(206, 26);
            this.textBoxOutletName.TabIndex = 12;
            this.textBoxOutletName.TextChanged += new System.EventHandler(this.textBoxOutletName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Outlet Name";
            // 
            // cmbOrganizationName
            // 
            this.cmbOrganizationName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrganizationName.FormattingEnabled = true;
            this.cmbOrganizationName.Location = new System.Drawing.Point(176, 32);
            this.cmbOrganizationName.Name = "cmbOrganizationName";
            this.cmbOrganizationName.Size = new System.Drawing.Size(204, 28);
            this.cmbOrganizationName.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(207, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(142, 242);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(238, 83);
            this.txtAddress.TabIndex = 1;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(176, 187);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(204, 26);
            this.txtContactNo.TabIndex = 1;
            // 
            // txtOutletCode
            // 
            this.txtOutletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutletCode.Location = new System.Drawing.Point(286, 140);
            this.txtOutletCode.Name = "txtOutletCode";
            this.txtOutletCode.ReadOnly = true;
            this.txtOutletCode.Size = new System.Drawing.Size(96, 26);
            this.txtOutletCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organization Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnPrint);
            this.tabPage2.Controls.Add(this.txtShowOrgName);
            this.tabPage2.Controls.Add(this.txtShowOutletName);
            this.tabPage2.Controls.Add(this.txtShowAddress);
            this.tabPage2.Controls.Add(this.txtShowContactNo);
            this.tabPage2.Controls.Add(this.txtShowOutletCode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Display";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(322, 371);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtShowOrgName
            // 
            this.txtShowOrgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowOrgName.Location = new System.Drawing.Point(129, 26);
            this.txtShowOrgName.Name = "txtShowOrgName";
            this.txtShowOrgName.ReadOnly = true;
            this.txtShowOrgName.Size = new System.Drawing.Size(238, 26);
            this.txtShowOrgName.TabIndex = 26;
            // 
            // txtShowOutletName
            // 
            this.txtShowOutletName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowOutletName.Location = new System.Drawing.Point(129, 71);
            this.txtShowOutletName.Name = "txtShowOutletName";
            this.txtShowOutletName.ReadOnly = true;
            this.txtShowOutletName.Size = new System.Drawing.Size(238, 26);
            this.txtShowOutletName.TabIndex = 25;
            // 
            // txtShowAddress
            // 
            this.txtShowAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowAddress.Location = new System.Drawing.Point(129, 207);
            this.txtShowAddress.Multiline = true;
            this.txtShowAddress.Name = "txtShowAddress";
            this.txtShowAddress.ReadOnly = true;
            this.txtShowAddress.Size = new System.Drawing.Size(238, 83);
            this.txtShowAddress.TabIndex = 21;
            // 
            // txtShowContactNo
            // 
            this.txtShowContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowContactNo.Location = new System.Drawing.Point(129, 160);
            this.txtShowContactNo.Name = "txtShowContactNo";
            this.txtShowContactNo.ReadOnly = true;
            this.txtShowContactNo.Size = new System.Drawing.Size(204, 26);
            this.txtShowContactNo.TabIndex = 22;
            // 
            // txtShowOutletCode
            // 
            this.txtShowOutletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowOutletCode.Location = new System.Drawing.Point(129, 116);
            this.txtShowOutletCode.Name = "txtShowOutletCode";
            this.txtShowOutletCode.ReadOnly = true;
            this.txtShowOutletCode.Size = new System.Drawing.Size(238, 26);
            this.txtShowOutletCode.TabIndex = 23;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Org Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Outlet Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Contact No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Address";
            // 
            // OutletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.tabControlOutlet);
            this.Controls.Add(this.groupBoxShow);
            this.Controls.Add(this.buttonHome);
            this.Name = "OutletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlet Form";
            this.groupBoxShow.ResumeLayout(false);
            this.groupBoxShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutlet)).EndInit();
            this.tabControlOutlet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxAddOraganization.ResumeLayout(false);
            this.groupBoxAddOraganization.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxShow;
        private System.Windows.Forms.DataGridView dgvOutlet;
        private System.Windows.Forms.TextBox txtQuickSrc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.TabControl tabControlOutlet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtShowOrgName;
        private System.Windows.Forms.TextBox txtShowOutletName;
        private System.Windows.Forms.TextBox txtShowAddress;
        private System.Windows.Forms.TextBox txtShowContactNo;
        private System.Windows.Forms.TextBox txtShowOutletCode;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.GroupBox groupBoxAddOraganization;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textCodeManual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOutletName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOrganizationName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtOutletCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}