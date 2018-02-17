namespace POS_System_EF.UI
{
    partial class SupplierCustomerForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.partyGroupBox = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkSupplier = new System.Windows.Forms.CheckBox();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtPartyCode = new System.Windows.Forms.TextBox();
            this.txtPartyName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.partyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(441, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(580, 291);
            this.dataGridView.TabIndex = 40;
            this.dataGridView.DoubleClick += new System.EventHandler(this.dataGridView_DoubleClick);
            // 
            // partyGroupBox
            // 
            this.partyGroupBox.Controls.Add(this.btnDelete);
            this.partyGroupBox.Controls.Add(this.label7);
            this.partyGroupBox.Controls.Add(this.chkSupplier);
            this.partyGroupBox.Controls.Add(this.chkCustomer);
            this.partyGroupBox.Controls.Add(this.label6);
            this.partyGroupBox.Controls.Add(this.btnClear);
            this.partyGroupBox.Controls.Add(this.btnSave);
            this.partyGroupBox.Controls.Add(this.txtAddress);
            this.partyGroupBox.Controls.Add(this.txtEmail);
            this.partyGroupBox.Controls.Add(this.txtContactNo);
            this.partyGroupBox.Controls.Add(this.txtPartyCode);
            this.partyGroupBox.Controls.Add(this.txtPartyName);
            this.partyGroupBox.Controls.Add(this.label5);
            this.partyGroupBox.Controls.Add(this.label4);
            this.partyGroupBox.Controls.Add(this.label3);
            this.partyGroupBox.Controls.Add(this.label2);
            this.partyGroupBox.Controls.Add(this.label1);
            this.partyGroupBox.Location = new System.Drawing.Point(12, 12);
            this.partyGroupBox.Name = "partyGroupBox";
            this.partyGroupBox.Size = new System.Drawing.Size(400, 437);
            this.partyGroupBox.TabIndex = 42;
            this.partyGroupBox.TabStop = false;
            this.partyGroupBox.Text = "SetUp Party";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(79, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(105, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "+88-";
            // 
            // chkSupplier
            // 
            this.chkSupplier.AutoSize = true;
            this.chkSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSupplier.Location = new System.Drawing.Point(263, 298);
            this.chkSupplier.Name = "chkSupplier";
            this.chkSupplier.Size = new System.Drawing.Size(86, 24);
            this.chkSupplier.TabIndex = 54;
            this.chkSupplier.Text = "Supplier";
            this.chkSupplier.UseVisualStyleBackColor = true;
            this.chkSupplier.CheckedChanged += new System.EventHandler(this.chkSupplier_CheckedChanged);
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCustomer.Location = new System.Drawing.Point(123, 298);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(97, 24);
            this.chkCustomer.TabIndex = 53;
            this.chkCustomer.Text = "Customer";
            this.chkCustomer.UseVisualStyleBackColor = true;
            this.chkCustomer.CheckedChanged += new System.EventHandler(this.chkCustomer_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Party Type";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(171, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(274, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(109, 228);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(270, 61);
            this.txtAddress.TabIndex = 45;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(109, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 26);
            this.txtEmail.TabIndex = 46;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(152, 182);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(226, 26);
            this.txtContactNo.TabIndex = 47;
            // 
            // txtPartyCode
            // 
            this.txtPartyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyCode.Location = new System.Drawing.Point(108, 88);
            this.txtPartyCode.Name = "txtPartyCode";
            this.txtPartyCode.ReadOnly = true;
            this.txtPartyCode.Size = new System.Drawing.Size(270, 26);
            this.txtPartyCode.TabIndex = 48;
            // 
            // txtPartyName
            // 
            this.txtPartyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartyName.Location = new System.Drawing.Point(108, 42);
            this.txtPartyName.Name = "txtPartyName";
            this.txtPartyName.Size = new System.Drawing.Size(270, 26);
            this.txtPartyName.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Location = new System.Drawing.Point(441, 22);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(270, 20);
            this.textBoxSrc.TabIndex = 49;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Location = new System.Drawing.Point(946, 20);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(75, 23);
            this.buttonSupplier.TabIndex = 50;
            this.buttonSupplier.Text = "Supplier";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.buttonSupplier_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(849, 20);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomer.TabIndex = 50;
            this.buttonCustomer.Text = "Customer";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(946, 391);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 51;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // SupplierCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.partyGroupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonSupplier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSrc);
            this.Name = "SupplierCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier And Customer Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.partyGroupBox.ResumeLayout(false);
            this.partyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox partyGroupBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtPartyCode;
        private System.Windows.Forms.TextBox txtPartyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSupplier;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button btnDelete;
    }
}