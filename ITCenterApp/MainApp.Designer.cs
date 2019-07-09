namespace ITCenterApp
{
    partial class MainApp
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
            this.dgv_headers = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_rows = new System.Windows.Forms.DataGridView();
            this.btn_headerCreateUpdate = new System.Windows.Forms.Button();
            this.btn_headerDelete = new System.Windows.Forms.Button();
            this.btn_headerCancel = new System.Windows.Forms.Button();
            this.btn_rowCancel = new System.Windows.Forms.Button();
            this.btn_rowDelete = new System.Windows.Forms.Button();
            this.btn_rowCreateUpdate = new System.Windows.Forms.Button();
            this.lbl_header_name = new System.Windows.Forms.Label();
            this.lbl_headerNetPrice = new System.Windows.Forms.Label();
            this.tb_headerName = new System.Windows.Forms.TextBox();
            this.lbl_headerCustomerNumber = new System.Windows.Forms.Label();
            this.tb_headerCustomerNumber = new System.Windows.Forms.TextBox();
            this.tb_headerNetPrice = new System.Windows.Forms.TextBox();
            this.tb_rowNetPrice = new System.Windows.Forms.TextBox();
            this.tb_rowQuantity = new System.Windows.Forms.TextBox();
            this.lbl_rowQuantity = new System.Windows.Forms.Label();
            this.tb_rowArticleName = new System.Windows.Forms.TextBox();
            this.lbl_rowNetPrice = new System.Windows.Forms.Label();
            this.lbl_rowArticleName = new System.Windows.Forms.Label();
            this.ArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_headers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rows)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_headers
            // 
            this.dgv_headers.AllowUserToAddRows = false;
            this.dgv_headers.AllowUserToDeleteRows = false;
            this.dgv_headers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_headers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_headers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerNumber,
            this.Name,
            this.CreatedDate,
            this.NetPrice,
            this.GrossPrice});
            this.dgv_headers.Location = new System.Drawing.Point(352, 29);
            this.dgv_headers.MultiSelect = false;
            this.dgv_headers.Name = "dgv_headers";
            this.dgv_headers.ReadOnly = true;
            this.dgv_headers.RowTemplate.Height = 24;
            this.dgv_headers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_headers.Size = new System.Drawing.Size(755, 194);
            this.dgv_headers.TabIndex = 0;
            this.dgv_headers.SelectionChanged += new System.EventHandler(this.dgv_headers_SelectionChanged);
            this.dgv_headers.DoubleClick += new System.EventHandler(this.dgv_headers_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CustomerNumber
            // 
            this.CustomerNumber.DataPropertyName = "CustomerNumber";
            this.CustomerNumber.HeaderText = "CustomerNumber";
            this.CustomerNumber.Name = "CustomerNumber";
            this.CustomerNumber.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // NetPrice
            // 
            this.NetPrice.DataPropertyName = "NetPrice";
            this.NetPrice.HeaderText = "NetPrice";
            this.NetPrice.Name = "NetPrice";
            this.NetPrice.ReadOnly = true;
            // 
            // GrossPrice
            // 
            this.GrossPrice.DataPropertyName = "GrossPrice";
            this.GrossPrice.HeaderText = "GrossPrice";
            this.GrossPrice.Name = "GrossPrice";
            this.GrossPrice.ReadOnly = true;
            // 
            // dgv_rows
            // 
            this.dgv_rows.AllowUserToAddRows = false;
            this.dgv_rows.AllowUserToDeleteRows = false;
            this.dgv_rows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_rows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticleName,
            this.rowId,
            this.HeaderId});
            this.dgv_rows.Location = new System.Drawing.Point(352, 229);
            this.dgv_rows.Name = "dgv_rows";
            this.dgv_rows.ReadOnly = true;
            this.dgv_rows.RowTemplate.Height = 24;
            this.dgv_rows.Size = new System.Drawing.Size(755, 194);
            this.dgv_rows.TabIndex = 1;
            // 
            // btn_headerCreateUpdate
            // 
            this.btn_headerCreateUpdate.Location = new System.Drawing.Point(90, 200);
            this.btn_headerCreateUpdate.Name = "btn_headerCreateUpdate";
            this.btn_headerCreateUpdate.Size = new System.Drawing.Size(75, 33);
            this.btn_headerCreateUpdate.TabIndex = 2;
            this.btn_headerCreateUpdate.Text = "Create";
            this.btn_headerCreateUpdate.UseVisualStyleBackColor = true;
            this.btn_headerCreateUpdate.Click += new System.EventHandler(this.btn_headerCreateUpdate_Click);
            // 
            // btn_headerDelete
            // 
            this.btn_headerDelete.Location = new System.Drawing.Point(171, 200);
            this.btn_headerDelete.Name = "btn_headerDelete";
            this.btn_headerDelete.Size = new System.Drawing.Size(75, 33);
            this.btn_headerDelete.TabIndex = 3;
            this.btn_headerDelete.Text = "Delete";
            this.btn_headerDelete.UseVisualStyleBackColor = true;
            this.btn_headerDelete.Click += new System.EventHandler(this.btn_headerDelete_Click);
            // 
            // btn_headerCancel
            // 
            this.btn_headerCancel.Location = new System.Drawing.Point(252, 200);
            this.btn_headerCancel.Name = "btn_headerCancel";
            this.btn_headerCancel.Size = new System.Drawing.Size(75, 33);
            this.btn_headerCancel.TabIndex = 4;
            this.btn_headerCancel.Text = "Cancel";
            this.btn_headerCancel.UseVisualStyleBackColor = true;
            this.btn_headerCancel.Click += new System.EventHandler(this.btn_headerCancel_Click);
            // 
            // btn_rowCancel
            // 
            this.btn_rowCancel.Location = new System.Drawing.Point(252, 400);
            this.btn_rowCancel.Name = "btn_rowCancel";
            this.btn_rowCancel.Size = new System.Drawing.Size(75, 33);
            this.btn_rowCancel.TabIndex = 7;
            this.btn_rowCancel.Text = "Cancel";
            this.btn_rowCancel.UseVisualStyleBackColor = true;
            this.btn_rowCancel.Click += new System.EventHandler(this.btn_rowCancel_Click);
            // 
            // btn_rowDelete
            // 
            this.btn_rowDelete.Location = new System.Drawing.Point(171, 400);
            this.btn_rowDelete.Name = "btn_rowDelete";
            this.btn_rowDelete.Size = new System.Drawing.Size(75, 33);
            this.btn_rowDelete.TabIndex = 6;
            this.btn_rowDelete.Text = "Delete";
            this.btn_rowDelete.UseVisualStyleBackColor = true;
            this.btn_rowDelete.Click += new System.EventHandler(this.btn_rowDelete_Click);
            // 
            // btn_rowCreateUpdate
            // 
            this.btn_rowCreateUpdate.Location = new System.Drawing.Point(90, 400);
            this.btn_rowCreateUpdate.Name = "btn_rowCreateUpdate";
            this.btn_rowCreateUpdate.Size = new System.Drawing.Size(75, 33);
            this.btn_rowCreateUpdate.TabIndex = 5;
            this.btn_rowCreateUpdate.Text = "Create";
            this.btn_rowCreateUpdate.UseVisualStyleBackColor = true;
            this.btn_rowCreateUpdate.Click += new System.EventHandler(this.btn_rowCreateUpdate_Click);
            // 
            // lbl_header_name
            // 
            this.lbl_header_name.AutoSize = true;
            this.lbl_header_name.Location = new System.Drawing.Point(96, 81);
            this.lbl_header_name.Name = "lbl_header_name";
            this.lbl_header_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_header_name.TabIndex = 8;
            this.lbl_header_name.Text = "Name";
            // 
            // lbl_headerNetPrice
            // 
            this.lbl_headerNetPrice.AutoSize = true;
            this.lbl_headerNetPrice.Location = new System.Drawing.Point(75, 137);
            this.lbl_headerNetPrice.Name = "lbl_headerNetPrice";
            this.lbl_headerNetPrice.Size = new System.Drawing.Size(66, 17);
            this.lbl_headerNetPrice.TabIndex = 9;
            this.lbl_headerNetPrice.Text = "Net Price";
            // 
            // tb_headerName
            // 
            this.tb_headerName.Location = new System.Drawing.Point(171, 78);
            this.tb_headerName.Name = "tb_headerName";
            this.tb_headerName.Size = new System.Drawing.Size(100, 22);
            this.tb_headerName.TabIndex = 10;
            // 
            // lbl_headerCustomerNumber
            // 
            this.lbl_headerCustomerNumber.AutoSize = true;
            this.lbl_headerCustomerNumber.Location = new System.Drawing.Point(19, 109);
            this.lbl_headerCustomerNumber.Name = "lbl_headerCustomerNumber";
            this.lbl_headerCustomerNumber.Size = new System.Drawing.Size(122, 17);
            this.lbl_headerCustomerNumber.TabIndex = 11;
            this.lbl_headerCustomerNumber.Text = "Customer Number";
            // 
            // tb_headerCustomerNumber
            // 
            this.tb_headerCustomerNumber.Location = new System.Drawing.Point(171, 106);
            this.tb_headerCustomerNumber.Name = "tb_headerCustomerNumber";
            this.tb_headerCustomerNumber.Size = new System.Drawing.Size(100, 22);
            this.tb_headerCustomerNumber.TabIndex = 12;
            this.tb_headerCustomerNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_headerCustomerNumber_KeyPress);
            // 
            // tb_headerNetPrice
            // 
            this.tb_headerNetPrice.Location = new System.Drawing.Point(171, 134);
            this.tb_headerNetPrice.Name = "tb_headerNetPrice";
            this.tb_headerNetPrice.Size = new System.Drawing.Size(100, 22);
            this.tb_headerNetPrice.TabIndex = 13;
            this.tb_headerNetPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_headerNetPrice_KeyPress);
            // 
            // tb_rowNetPrice
            // 
            this.tb_rowNetPrice.Location = new System.Drawing.Point(171, 312);
            this.tb_rowNetPrice.Name = "tb_rowNetPrice";
            this.tb_rowNetPrice.Size = new System.Drawing.Size(100, 22);
            this.tb_rowNetPrice.TabIndex = 21;
            this.tb_rowNetPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rowNetPrice_KeyPress);
            // 
            // tb_rowQuantity
            // 
            this.tb_rowQuantity.Location = new System.Drawing.Point(171, 284);
            this.tb_rowQuantity.Name = "tb_rowQuantity";
            this.tb_rowQuantity.Size = new System.Drawing.Size(100, 22);
            this.tb_rowQuantity.TabIndex = 20;
            this.tb_rowQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rowQuantity_KeyPress);
            // 
            // lbl_rowQuantity
            // 
            this.lbl_rowQuantity.AutoSize = true;
            this.lbl_rowQuantity.Location = new System.Drawing.Point(80, 287);
            this.lbl_rowQuantity.Name = "lbl_rowQuantity";
            this.lbl_rowQuantity.Size = new System.Drawing.Size(61, 17);
            this.lbl_rowQuantity.TabIndex = 19;
            this.lbl_rowQuantity.Text = "Quantity";
            // 
            // tb_rowArticleName
            // 
            this.tb_rowArticleName.Location = new System.Drawing.Point(171, 256);
            this.tb_rowArticleName.Name = "tb_rowArticleName";
            this.tb_rowArticleName.Size = new System.Drawing.Size(100, 22);
            this.tb_rowArticleName.TabIndex = 18;
            // 
            // lbl_rowNetPrice
            // 
            this.lbl_rowNetPrice.AutoSize = true;
            this.lbl_rowNetPrice.Location = new System.Drawing.Point(75, 315);
            this.lbl_rowNetPrice.Name = "lbl_rowNetPrice";
            this.lbl_rowNetPrice.Size = new System.Drawing.Size(66, 17);
            this.lbl_rowNetPrice.TabIndex = 17;
            this.lbl_rowNetPrice.Text = "Net Price";
            // 
            // lbl_rowArticleName
            // 
            this.lbl_rowArticleName.AutoSize = true;
            this.lbl_rowArticleName.Location = new System.Drawing.Point(53, 259);
            this.lbl_rowArticleName.Name = "lbl_rowArticleName";
            this.lbl_rowArticleName.Size = new System.Drawing.Size(88, 17);
            this.lbl_rowArticleName.TabIndex = 16;
            this.lbl_rowArticleName.Text = "Article Name";
            // 
            // ArticleName
            // 
            this.ArticleName.HeaderText = "Column1";
            this.ArticleName.Name = "ArticleName";
            this.ArticleName.ReadOnly = true;
            // 
            // rowId
            // 
            this.rowId.DataPropertyName = "Id";
            this.rowId.HeaderText = "Id";
            this.rowId.Name = "rowId";
            this.rowId.ReadOnly = true;
            // 
            // HeaderId
            // 
            this.HeaderId.DataPropertyName = "HeaderId";
            this.HeaderId.HeaderText = "HeaderId";
            this.HeaderId.Name = "HeaderId";
            this.HeaderId.ReadOnly = true;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 450);
            this.Controls.Add(this.tb_rowNetPrice);
            this.Controls.Add(this.tb_rowQuantity);
            this.Controls.Add(this.lbl_rowQuantity);
            this.Controls.Add(this.tb_rowArticleName);
            this.Controls.Add(this.lbl_rowNetPrice);
            this.Controls.Add(this.lbl_rowArticleName);
            this.Controls.Add(this.tb_headerNetPrice);
            this.Controls.Add(this.tb_headerCustomerNumber);
            this.Controls.Add(this.lbl_headerCustomerNumber);
            this.Controls.Add(this.tb_headerName);
            this.Controls.Add(this.lbl_headerNetPrice);
            this.Controls.Add(this.lbl_header_name);
            this.Controls.Add(this.btn_rowCancel);
            this.Controls.Add(this.btn_rowDelete);
            this.Controls.Add(this.btn_rowCreateUpdate);
            this.Controls.Add(this.btn_headerCancel);
            this.Controls.Add(this.btn_headerDelete);
            this.Controls.Add(this.btn_headerCreateUpdate);
            this.Controls.Add(this.dgv_rows);
            this.Controls.Add(this.dgv_headers);
            //this.Name = "MainApp";
            this.Text = "Zadanie rekrutacyjne";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_headers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_headers;
        private System.Windows.Forms.DataGridView dgv_rows;
        private System.Windows.Forms.Button btn_headerCreateUpdate;
        private System.Windows.Forms.Button btn_headerDelete;
        private System.Windows.Forms.Button btn_headerCancel;
        private System.Windows.Forms.Button btn_rowCancel;
        private System.Windows.Forms.Button btn_rowDelete;
        private System.Windows.Forms.Button btn_rowCreateUpdate;
        private System.Windows.Forms.Label lbl_header_name;
        private System.Windows.Forms.Label lbl_headerNetPrice;
        private System.Windows.Forms.TextBox tb_headerName;
        private System.Windows.Forms.Label lbl_headerCustomerNumber;
        private System.Windows.Forms.TextBox tb_headerCustomerNumber;
        private System.Windows.Forms.TextBox tb_headerNetPrice;
        private System.Windows.Forms.TextBox tb_rowNetPrice;
        private System.Windows.Forms.TextBox tb_rowQuantity;
        private System.Windows.Forms.Label lbl_rowQuantity;
        private System.Windows.Forms.TextBox tb_rowArticleName;
        private System.Windows.Forms.Label lbl_rowNetPrice;
        private System.Windows.Forms.Label lbl_rowArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeaderId;
    }
}

