namespace POS_System_EF
{
    partial class ExpenseCategoryForm
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
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.buttonSrcClear = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbRootCategory = new System.Windows.Forms.ComboBox();
            this.rbSubCategory = new System.Windows.Forms.RadioButton();
            this.rbRootCategory = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.textBoxSrc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeRootcat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.txtCodeManual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.Location = new System.Drawing.Point(288, 306);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(75, 30);
            this.btnSaveCategory.TabIndex = 90;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // buttonSrcClear
            // 
            this.buttonSrcClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSrcClear.Location = new System.Drawing.Point(931, 33);
            this.buttonSrcClear.Name = "buttonSrcClear";
            this.buttonSrcClear.Size = new System.Drawing.Size(94, 29);
            this.buttonSrcClear.TabIndex = 89;
            this.buttonSrcClear.Text = "Clear";
            this.buttonSrcClear.UseVisualStyleBackColor = true;
            this.buttonSrcClear.Click += new System.EventHandler(this.buttonSrcClear_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(950, 404);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(75, 30);
            this.buttonHome.TabIndex = 87;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Location = new System.Drawing.Point(402, 75);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.RowHeadersVisible = false;
            this.dgvCategoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoryList.Size = new System.Drawing.Size(623, 292);
            this.dgvCategoryList.TabIndex = 88;
            this.dgvCategoryList.DoubleClick += new System.EventHandler(this.dgvCategoryList_DoubleClick);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(188, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 86;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbRootCategory
            // 
            this.cmbRootCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRootCategory.FormattingEnabled = true;
            this.cmbRootCategory.Location = new System.Drawing.Point(148, 86);
            this.cmbRootCategory.Name = "cmbRootCategory";
            this.cmbRootCategory.Size = new System.Drawing.Size(215, 21);
            this.cmbRootCategory.TabIndex = 85;
            // 
            // rbSubCategory
            // 
            this.rbSubCategory.AutoSize = true;
            this.rbSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSubCategory.Location = new System.Drawing.Point(267, 35);
            this.rbSubCategory.Name = "rbSubCategory";
            this.rbSubCategory.Size = new System.Drawing.Size(112, 21);
            this.rbSubCategory.TabIndex = 84;
            this.rbSubCategory.TabStop = true;
            this.rbSubCategory.Text = "Sub Category";
            this.rbSubCategory.UseVisualStyleBackColor = true;
            this.rbSubCategory.CheckedChanged += new System.EventHandler(this.rbSubCategory_CheckedChanged);
            // 
            // rbRootCategory
            // 
            this.rbRootCategory.AutoSize = true;
            this.rbRootCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRootCategory.Location = new System.Drawing.Point(148, 33);
            this.rbRootCategory.Name = "rbRootCategory";
            this.rbRootCategory.Size = new System.Drawing.Size(117, 21);
            this.rbRootCategory.TabIndex = 83;
            this.rbRootCategory.TabStop = true;
            this.rbRootCategory.Text = "Root Category";
            this.rbRootCategory.UseVisualStyleBackColor = true;
            this.rbRootCategory.CheckedChanged += new System.EventHandler(this.rbRootCategory_CheckedChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 207);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(215, 65);
            this.txtDescription.TabIndex = 79;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(267, 167);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(96, 20);
            this.txtCode.TabIndex = 80;
            // 
            // textBoxSrc
            // 
            this.textBoxSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSrc.Location = new System.Drawing.Point(693, 35);
            this.textBoxSrc.Name = "textBoxSrc";
            this.textBoxSrc.Size = new System.Drawing.Size(219, 26);
            this.textBoxSrc.TabIndex = 82;
            this.textBoxSrc.TextChanged += new System.EventHandler(this.textBoxSrc_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(215, 20);
            this.txtName.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Code";
            // 
            // labeRootcat
            // 
            this.labeRootcat.AutoSize = true;
            this.labeRootcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeRootcat.Location = new System.Drawing.Point(27, 89);
            this.labeRootcat.Name = "labeRootcat";
            this.labeRootcat.Size = new System.Drawing.Size(99, 17);
            this.labeRootcat.TabIndex = 75;
            this.labeRootcat.Text = "Root Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "Name";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(95, 306);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 92;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // txtCodeManual
            // 
            this.txtCodeManual.Location = new System.Drawing.Point(148, 167);
            this.txtCodeManual.Name = "txtCodeManual";
            this.txtCodeManual.Size = new System.Drawing.Size(113, 20);
            this.txtCodeManual.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(584, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 93;
            this.label4.Text = "Quick Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Select Category";
            // 
            // ExpenseCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.buttonSrcClear);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.dgvCategoryList);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbRootCategory);
            this.Controls.Add(this.rbSubCategory);
            this.Controls.Add(this.rbRootCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.textBoxSrc);
            this.Controls.Add(this.txtCodeManual);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labeRootcat);
            this.Controls.Add(this.label1);
            this.Name = "ExpenseCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense Category Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button buttonSrcClear;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbRootCategory;
        private System.Windows.Forms.RadioButton rbSubCategory;
        private System.Windows.Forms.RadioButton rbRootCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox textBoxSrc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeRootcat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox txtCodeManual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}