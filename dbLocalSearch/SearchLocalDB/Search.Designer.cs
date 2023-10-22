namespace SearchLocalDB
{
	partial class Browse
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
			this.components = new System.ComponentModel.Container();
			this.lbl_phone = new MaterialSkin.Controls.MaterialLabel();
			this.txt_phone = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.appDataSet = new SearchLocalDB.AppDataSet();
			this.txt_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_name = new MaterialSkin.Controls.MaterialLabel();
			this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_email = new MaterialSkin.Controls.MaterialLabel();
			this.txt_address = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_address = new MaterialSkin.Controls.MaterialLabel();
			this.txt_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.lbl_search = new MaterialSkin.Controls.MaterialLabel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
			this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
			this.btn_edit = new MaterialSkin.Controls.MaterialFlatButton();
			this.btn_new = new MaterialSkin.Controls.MaterialFlatButton();
			this.phoneTableAdapter = new SearchLocalDB.AppDataSetTableAdapters.phoneTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.appDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_phone
			// 
			this.lbl_phone.AutoSize = true;
			this.lbl_phone.Depth = 0;
			this.lbl_phone.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_phone.Location = new System.Drawing.Point(16, 80);
			this.lbl_phone.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_phone.Name = "lbl_phone";
			this.lbl_phone.Size = new System.Drawing.Size(108, 19);
			this.lbl_phone.TabIndex = 0;
			this.lbl_phone.Text = "Phone Number";
			// 
			// txt_phone
			// 
			this.txt_phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "PhoneNumber", true));
			this.txt_phone.Depth = 0;
			this.txt_phone.Hint = "";
			this.txt_phone.Location = new System.Drawing.Point(144, 80);
			this.txt_phone.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_phone.Name = "txt_phone";
			this.txt_phone.PasswordChar = '\0';
			this.txt_phone.SelectedText = "";
			this.txt_phone.SelectionLength = 0;
			this.txt_phone.SelectionStart = 0;
			this.txt_phone.Size = new System.Drawing.Size(224, 23);
			this.txt_phone.TabIndex = 0;
			this.txt_phone.UseSystemPasswordChar = false;
			// 
			// phoneBindingSource
			// 
			this.phoneBindingSource.DataMember = "phone";
			this.phoneBindingSource.DataSource = this.appDataSet;
			// 
			// appDataSet
			// 
			this.appDataSet.DataSetName = "AppDataSet";
			this.appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txt_name
			// 
			this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "FullName", true));
			this.txt_name.Depth = 0;
			this.txt_name.Hint = "";
			this.txt_name.Location = new System.Drawing.Point(144, 112);
			this.txt_name.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_name.Name = "txt_name";
			this.txt_name.PasswordChar = '\0';
			this.txt_name.SelectedText = "";
			this.txt_name.SelectionLength = 0;
			this.txt_name.SelectionStart = 0;
			this.txt_name.Size = new System.Drawing.Size(224, 23);
			this.txt_name.TabIndex = 1;
			this.txt_name.UseSystemPasswordChar = false;
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Depth = 0;
			this.lbl_name.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_name.Location = new System.Drawing.Point(16, 112);
			this.lbl_name.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(77, 19);
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "Full Name";
			// 
			// txt_email
			// 
			this.txt_email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "Email", true));
			this.txt_email.Depth = 0;
			this.txt_email.Hint = "";
			this.txt_email.Location = new System.Drawing.Point(144, 144);
			this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_email.Name = "txt_email";
			this.txt_email.PasswordChar = '\0';
			this.txt_email.SelectedText = "";
			this.txt_email.SelectionLength = 0;
			this.txt_email.SelectionStart = 0;
			this.txt_email.Size = new System.Drawing.Size(224, 23);
			this.txt_email.TabIndex = 2;
			this.txt_email.UseSystemPasswordChar = false;
			// 
			// lbl_email
			// 
			this.lbl_email.AutoSize = true;
			this.lbl_email.Depth = 0;
			this.lbl_email.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_email.Location = new System.Drawing.Point(16, 144);
			this.lbl_email.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_email.Name = "lbl_email";
			this.lbl_email.Size = new System.Drawing.Size(47, 19);
			this.lbl_email.TabIndex = 0;
			this.lbl_email.Text = "Email";
			// 
			// txt_address
			// 
			this.txt_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.phoneBindingSource, "Address", true));
			this.txt_address.Depth = 0;
			this.txt_address.Hint = "";
			this.txt_address.Location = new System.Drawing.Point(144, 176);
			this.txt_address.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_address.Name = "txt_address";
			this.txt_address.PasswordChar = '\0';
			this.txt_address.SelectedText = "";
			this.txt_address.SelectionLength = 0;
			this.txt_address.SelectionStart = 0;
			this.txt_address.Size = new System.Drawing.Size(224, 23);
			this.txt_address.TabIndex = 3;
			this.txt_address.UseSystemPasswordChar = false;
			// 
			// lbl_address
			// 
			this.lbl_address.AutoSize = true;
			this.lbl_address.Depth = 0;
			this.lbl_address.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_address.Location = new System.Drawing.Point(16, 176);
			this.lbl_address.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.Size = new System.Drawing.Size(64, 19);
			this.lbl_address.TabIndex = 0;
			this.lbl_address.Text = "Address";
			// 
			// txt_search
			// 
			this.txt_search.Depth = 0;
			this.txt_search.Hint = "";
			this.txt_search.Location = new System.Drawing.Point(144, 208);
			this.txt_search.MouseState = MaterialSkin.MouseState.HOVER;
			this.txt_search.Name = "txt_search";
			this.txt_search.PasswordChar = '\0';
			this.txt_search.SelectedText = "";
			this.txt_search.SelectionLength = 0;
			this.txt_search.SelectionStart = 0;
			this.txt_search.Size = new System.Drawing.Size(640, 23);
			this.txt_search.TabIndex = 4;
			this.txt_search.UseSystemPasswordChar = false;
			this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
			// 
			// lbl_search
			// 
			this.lbl_search.AutoSize = true;
			this.lbl_search.Depth = 0;
			this.lbl_search.Font = new System.Drawing.Font("Roboto", 11F);
			this.lbl_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.lbl_search.Location = new System.Drawing.Point(16, 208);
			this.lbl_search.MouseState = MaterialSkin.MouseState.HOVER;
			this.lbl_search.Name = "lbl_search";
			this.lbl_search.Size = new System.Drawing.Size(55, 19);
			this.lbl_search.TabIndex = 0;
			this.lbl_search.Text = "Search";
			// 
			// dataGridView
			// 
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phoneNumberDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.phoneBindingSource;
			this.dataGridView.Location = new System.Drawing.Point(16, 240);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(768, 150);
			this.dataGridView.TabIndex = 5;
			this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// btn_save
			// 
			this.btn_save.AutoSize = true;
			this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_save.Depth = 0;
			this.btn_save.Location = new System.Drawing.Point(680, 400);
			this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btn_save.MinimumSize = new System.Drawing.Size(100, 0);
			this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_save.Name = "btn_save";
			this.btn_save.Primary = false;
			this.btn_save.Size = new System.Drawing.Size(100, 36);
			this.btn_save.TabIndex = 9;
			this.btn_save.Text = "SAVE";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.AutoSize = true;
			this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_cancel.Depth = 0;
			this.btn_cancel.Location = new System.Drawing.Point(552, 400);
			this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btn_cancel.MinimumSize = new System.Drawing.Size(100, 0);
			this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Primary = false;
			this.btn_cancel.Size = new System.Drawing.Size(100, 36);
			this.btn_cancel.TabIndex = 8;
			this.btn_cancel.Text = "CANCEL";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.AutoSize = true;
			this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_edit.Depth = 0;
			this.btn_edit.Location = new System.Drawing.Point(424, 400);
			this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btn_edit.MinimumSize = new System.Drawing.Size(100, 0);
			this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Primary = false;
			this.btn_edit.Size = new System.Drawing.Size(100, 36);
			this.btn_edit.TabIndex = 7;
			this.btn_edit.Text = "EDIT";
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_new
			// 
			this.btn_new.AutoSize = true;
			this.btn_new.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btn_new.Depth = 0;
			this.btn_new.Location = new System.Drawing.Point(296, 400);
			this.btn_new.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
			this.btn_new.MinimumSize = new System.Drawing.Size(100, 0);
			this.btn_new.MouseState = MaterialSkin.MouseState.HOVER;
			this.btn_new.Name = "btn_new";
			this.btn_new.Primary = false;
			this.btn_new.Size = new System.Drawing.Size(100, 36);
			this.btn_new.TabIndex = 6;
			this.btn_new.Text = "NEW";
			this.btn_new.UseVisualStyleBackColor = true;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// phoneTableAdapter
			// 
			this.phoneTableAdapter.ClearBeforeFill = true;
			// 
			// Browse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 450);
			this.Controls.Add(this.btn_new);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.txt_search);
			this.Controls.Add(this.lbl_search);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.lbl_address);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.lbl_email);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.txt_phone);
			this.Controls.Add(this.lbl_phone);
			this.Name = "Browse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Browse";
			this.Load += new System.EventHandler(this.Browse_Load);
			((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.appDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialLabel lbl_phone;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_phone;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_name;
		private MaterialSkin.Controls.MaterialLabel lbl_name;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
		private MaterialSkin.Controls.MaterialLabel lbl_email;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_address;
		private MaterialSkin.Controls.MaterialLabel lbl_address;
		private MaterialSkin.Controls.MaterialSingleLineTextField txt_search;
		private MaterialSkin.Controls.MaterialLabel lbl_search;
		private System.Windows.Forms.DataGridView dataGridView;
		private MaterialSkin.Controls.MaterialFlatButton btn_save;
		private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
		private MaterialSkin.Controls.MaterialFlatButton btn_edit;
		private MaterialSkin.Controls.MaterialFlatButton btn_new;
		private AppDataSet appDataSet;
		private System.Windows.Forms.BindingSource phoneBindingSource;
		private AppDataSetTableAdapters.phoneTableAdapter phoneTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
	}
}

