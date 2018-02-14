namespace POS_System_EF.UI
{
    partial class OrganizationForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtOrgnizationCode = new System.Windows.Forms.TextBox();
            this.txtOranizationName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.btnClearImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxOrg = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControlOrg = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCodeManual = new System.Windows.Forms.TextBox();
            this.tpDisplay = new System.Windows.Forms.TabPage();
            this.pbOrg = new System.Windows.Forms.PictureBox();
            this.txtShowName = new System.Windows.Forms.TextBox();
            this.txtShowCode = new System.Windows.Forms.TextBox();
            this.txtShowContact = new System.Windows.Forms.TextBox();
            this.txtShowAddress = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.txtSearchCode = new System.Windows.Forms.TextBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.dgvOrganization = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).BeginInit();
            this.tabControlOrg.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(201, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(103, 242);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(254, 73);
            this.txtAddress.TabIndex = 21;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(148, 59);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(209, 26);
            this.txtContactNo.TabIndex = 23;
            // 
            // txtOrgnizationCode
            // 
            this.txtOrgnizationCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgnizationCode.Location = new System.Drawing.Point(242, 328);
            this.txtOrgnizationCode.Name = "txtOrgnizationCode";
            this.txtOrgnizationCode.ReadOnly = true;
            this.txtOrgnizationCode.Size = new System.Drawing.Size(115, 26);
            this.txtOrgnizationCode.TabIndex = 24;
            // 
            // txtOranizationName
            // 
            this.txtOranizationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOranizationName.Location = new System.Drawing.Point(103, 16);
            this.txtOranizationName.Name = "txtOranizationName";
            this.txtOranizationName.Size = new System.Drawing.Size(254, 26);
            this.txtOranizationName.TabIndex = 25;
            this.txtOranizationName.TextChanged += new System.EventHandler(this.txtOranizationName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Logo/Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Contact No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(295, 198);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(62, 23);
            this.buttonUpload.TabIndex = 30;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // btnClearImage
            // 
            this.btnClearImage.Location = new System.Drawing.Point(233, 198);
            this.btnClearImage.Name = "btnClearImage";
            this.btnClearImage.Size = new System.Drawing.Size(56, 23);
            this.btnClearImage.TabIndex = 125;
            this.btnClearImage.Text = "Clear";
            this.btnClearImage.UseVisualStyleBackColor = true;
            this.btnClearImage.Click += new System.EventHandler(this.btnClearImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(220, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 92);
            this.textBox1.TabIndex = 124;
            this.textBox1.Text = "\r\nImage size must  300 X 300 PX and image format JPEG/JPG.Image size MAX 100KB.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "+88 -";
            // 
            // pictureBoxOrg
            // 
            this.pictureBoxOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOrg.Location = new System.Drawing.Point(106, 100);
            this.pictureBoxOrg.Name = "pictureBoxOrg";
            this.pictureBoxOrg.Size = new System.Drawing.Size(108, 121);
            this.pictureBoxOrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrg.TabIndex = 29;
            this.pictureBoxOrg.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 126;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabControlOrg
            // 
            this.tabControlOrg.Controls.Add(this.tabPage1);
            this.tabControlOrg.Controls.Add(this.tpDisplay);
            this.tabControlOrg.Location = new System.Drawing.Point(12, 12);
            this.tabControlOrg.Name = "tabControlOrg";
            this.tabControlOrg.SelectedIndex = 0;
            this.tabControlOrg.Size = new System.Drawing.Size(438, 437);
            this.tabControlOrg.TabIndex = 128;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCodeManual);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnClearImage);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.buttonUpload);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBoxOrg);
            this.tabPage1.Controls.Add(this.txtOranizationName);
            this.tabPage1.Controls.Add(this.txtOrgnizationCode);
            this.tabPage1.Controls.Add(this.txtContactNo);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCodeManual
            // 
            this.txtCodeManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeManual.Location = new System.Drawing.Point(106, 328);
            this.txtCodeManual.Name = "txtCodeManual";
            this.txtCodeManual.Size = new System.Drawing.Size(108, 26);
            this.txtCodeManual.TabIndex = 127;
            // 
            // tpDisplay
            // 
            this.tpDisplay.BackColor = System.Drawing.Color.SlateGray;
            this.tpDisplay.Controls.Add(this.pbOrg);
            this.tpDisplay.Controls.Add(this.txtShowName);
            this.tpDisplay.Controls.Add(this.txtShowCode);
            this.tpDisplay.Controls.Add(this.txtShowContact);
            this.tpDisplay.Controls.Add(this.txtShowAddress);
            this.tpDisplay.Controls.Add(this.button5);
            this.tpDisplay.Location = new System.Drawing.Point(4, 22);
            this.tpDisplay.Name = "tpDisplay";
            this.tpDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tpDisplay.Size = new System.Drawing.Size(430, 411);
            this.tpDisplay.TabIndex = 1;
            this.tpDisplay.Text = "Display";
            // 
            // pbOrg
            // 
            this.pbOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOrg.Location = new System.Drawing.Point(32, 16);
            this.pbOrg.Name = "pbOrg";
            this.pbOrg.Size = new System.Drawing.Size(182, 121);
            this.pbOrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrg.TabIndex = 139;
            this.pbOrg.TabStop = false;
            // 
            // txtShowName
            // 
            this.txtShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowName.Location = new System.Drawing.Point(32, 155);
            this.txtShowName.Name = "txtShowName";
            this.txtShowName.ReadOnly = true;
            this.txtShowName.Size = new System.Drawing.Size(195, 26);
            this.txtShowName.TabIndex = 136;
            // 
            // txtShowCode
            // 
            this.txtShowCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowCode.Location = new System.Drawing.Point(32, 191);
            this.txtShowCode.Name = "txtShowCode";
            this.txtShowCode.ReadOnly = true;
            this.txtShowCode.Size = new System.Drawing.Size(101, 26);
            this.txtShowCode.TabIndex = 135;
            // 
            // txtShowContact
            // 
            this.txtShowContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowContact.Location = new System.Drawing.Point(32, 234);
            this.txtShowContact.Name = "txtShowContact";
            this.txtShowContact.ReadOnly = true;
            this.txtShowContact.Size = new System.Drawing.Size(168, 26);
            this.txtShowContact.TabIndex = 134;
            // 
            // txtShowAddress
            // 
            this.txtShowAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowAddress.Location = new System.Drawing.Point(32, 279);
            this.txtShowAddress.Multiline = true;
            this.txtShowAddress.Name = "txtShowAddress";
            this.txtShowAddress.ReadOnly = true;
            this.txtShowAddress.Size = new System.Drawing.Size(263, 73);
            this.txtShowAddress.TabIndex = 133;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(295, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 138;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(456, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Quick Search";
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrc.Location = new System.Drawing.Point(566, 44);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(154, 26);
            this.textBoxSrc.TabIndex = 25;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // txtSearchCode
            // 
            this.txtSearchCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCode.Location = new System.Drawing.Point(833, 44);
            this.txtSearchCode.Name = "txtSearchCode";
            this.txtSearchCode.Size = new System.Drawing.Size(154, 26);
            this.txtSearchCode.TabIndex = 25;
            this.txtSearchCode.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(1086, 417);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 23);
            this.buttonHome.TabIndex = 27;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // dgvOrganization
            // 
            this.dgvOrganization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganization.Location = new System.Drawing.Point(460, 96);
            this.dgvOrganization.Name = "dgvOrganization";
            this.dgvOrganization.RowHeadersVisible = false;
            this.dgvOrganization.RowTemplate.Height = 70;
            this.dgvOrganization.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganization.Size = new System.Drawing.Size(701, 315);
            this.dgvOrganization.TabIndex = 28;
            this.dgvOrganization.DoubleClick += new System.EventHandler(this.dgvOrganization_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(993, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 31);
            this.btnSearch.TabIndex = 127;
            this.btnSearch.Text = "Search By Code";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 498);
            this.Controls.Add(this.tabControlOrg);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvOrganization);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.txtSearchCode);
            this.Controls.Add(this.textBoxSrc);
            this.Controls.Add(this.label6);
            this.Name = "OrganizationForm";
            this.Text = "Organization Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrg)).EndInit();
            this.tabControlOrg.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tpDisplay.ResumeLayout(false);
            this.tpDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtOrgnizationCode;
        private System.Windows.Forms.TextBox txtOranizationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.PictureBox pictureBoxOrg;
        private System.Windows.Forms.Button btnClearImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControlOrg;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpDisplay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.TextBox txtSearchCode;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.DataGridView dgvOrganization;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pbOrg;
        private System.Windows.Forms.TextBox txtShowName;
        private System.Windows.Forms.TextBox txtShowCode;
        private System.Windows.Forms.TextBox txtShowContact;
        private System.Windows.Forms.TextBox txtShowAddress;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtCodeManual;
    }
}