namespace CrudFormsApplication
{
    partial class Form1
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
            this._searchBox = new System.Windows.Forms.TextBox();
            this._search = new System.Windows.Forms.Button();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._new = new System.Windows.Forms.Button();
            this._delete = new System.Windows.Forms.Button();
            this._refresh = new System.Windows.Forms.Button();
            this._save = new System.Windows.Forms.Button();
            this._firstName = new System.Windows.Forms.Label();
            this._firstNameBox = new System.Windows.Forms.TextBox();
            this._lastNameBox = new System.Windows.Forms.TextBox();
            this._lastName = new System.Windows.Forms.Label();
            this._userNameBox = new System.Windows.Forms.TextBox();
            this._username = new System.Windows.Forms.Label();
            this._emailBox = new System.Windows.Forms.TextBox();
            this._email = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _searchBox
            // 
            this._searchBox.Location = new System.Drawing.Point(26, 35);
            this._searchBox.Multiline = true;
            this._searchBox.Name = "_searchBox";
            this._searchBox.Size = new System.Drawing.Size(417, 23);
            this._searchBox.TabIndex = 0;
            // 
            // _search
            // 
            this._search.Location = new System.Drawing.Point(466, 35);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(75, 23);
            this._search.TabIndex = 1;
            this._search.Text = "Search";
            this._search.UseVisualStyleBackColor = true;
            this._search.Click += new System.EventHandler(this.search_Click);
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Location = new System.Drawing.Point(26, 88);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(515, 296);
            this._dataGridView.TabIndex = 2;
            this._dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCellClick);
            // 
            // _new
            // 
            this._new.Location = new System.Drawing.Point(239, 407);
            this._new.Name = "_new";
            this._new.Size = new System.Drawing.Size(75, 23);
            this._new.TabIndex = 3;
            this._new.Text = "New";
            this._new.UseVisualStyleBackColor = true;
            this._new.Click += new System.EventHandler(this.new_Click);
            // 
            // _delete
            // 
            this._delete.Location = new System.Drawing.Point(333, 407);
            this._delete.Name = "_delete";
            this._delete.Size = new System.Drawing.Size(75, 23);
            this._delete.TabIndex = 4;
            this._delete.Text = "Delete";
            this._delete.UseVisualStyleBackColor = true;
            this._delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // _refresh
            // 
            this._refresh.Location = new System.Drawing.Point(425, 407);
            this._refresh.Name = "_refresh";
            this._refresh.Size = new System.Drawing.Size(75, 23);
            this._refresh.TabIndex = 5;
            this._refresh.Text = "Refresh";
            this._refresh.UseVisualStyleBackColor = true;
            this._refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // _save
            // 
            this._save.Location = new System.Drawing.Point(761, 304);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(75, 23);
            this._save.TabIndex = 6;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = true;
            this._save.Click += new System.EventHandler(this.save_Click);
            // 
            // _firstName
            // 
            this._firstName.Location = new System.Drawing.Point(588, 130);
            this._firstName.Name = "_firstName";
            this._firstName.Size = new System.Drawing.Size(65, 23);
            this._firstName.TabIndex = 7;
            this._firstName.Text = "First name";
            this._firstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _firstNameBox
            // 
            this._firstNameBox.Location = new System.Drawing.Point(659, 132);
            this._firstNameBox.Multiline = true;
            this._firstNameBox.Name = "_firstNameBox";
            this._firstNameBox.Size = new System.Drawing.Size(177, 23);
            this._firstNameBox.TabIndex = 8;
            // 
            // _lastNameBox
            // 
            this._lastNameBox.Location = new System.Drawing.Point(659, 175);
            this._lastNameBox.Multiline = true;
            this._lastNameBox.Name = "_lastNameBox";
            this._lastNameBox.Size = new System.Drawing.Size(177, 23);
            this._lastNameBox.TabIndex = 10;
            // 
            // _lastName
            // 
            this._lastName.Location = new System.Drawing.Point(591, 175);
            this._lastName.Name = "_lastName";
            this._lastName.Size = new System.Drawing.Size(62, 23);
            this._lastName.TabIndex = 9;
            this._lastName.Text = "Last name";
            this._lastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _userNameBox
            // 
            this._userNameBox.Location = new System.Drawing.Point(659, 218);
            this._userNameBox.Multiline = true;
            this._userNameBox.Name = "_userNameBox";
            this._userNameBox.Size = new System.Drawing.Size(177, 23);
            this._userNameBox.TabIndex = 12;
            // 
            // _username
            // 
            this._username.Location = new System.Drawing.Point(591, 218);
            this._username.Name = "_username";
            this._username.Size = new System.Drawing.Size(62, 23);
            this._username.TabIndex = 11;
            this._username.Text = "Username";
            this._username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _emailBox
            // 
            this._emailBox.Location = new System.Drawing.Point(659, 265);
            this._emailBox.Multiline = true;
            this._emailBox.Name = "_emailBox";
            this._emailBox.Size = new System.Drawing.Size(177, 23);
            this._emailBox.TabIndex = 14;
            // 
            // _email
            // 
            this._email.Location = new System.Drawing.Point(594, 268);
            this._email.Name = "_email";
            this._email.Size = new System.Drawing.Size(59, 23);
            this._email.TabIndex = 13;
            this._email.Text = "Email";
            this._email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 453);
            this.Controls.Add(this._emailBox);
            this.Controls.Add(this._email);
            this.Controls.Add(this._userNameBox);
            this.Controls.Add(this._username);
            this.Controls.Add(this._lastNameBox);
            this.Controls.Add(this._lastName);
            this.Controls.Add(this._firstNameBox);
            this.Controls.Add(this._firstName);
            this.Controls.Add(this._save);
            this.Controls.Add(this._refresh);
            this.Controls.Add(this._delete);
            this.Controls.Add(this._new);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._search);
            this.Controls.Add(this._searchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _searchBox;
        private System.Windows.Forms.Button _search;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.Button _new;
        private System.Windows.Forms.Button _delete;
        private System.Windows.Forms.Button _refresh;
        private System.Windows.Forms.Button _save;
        private System.Windows.Forms.Label _firstName;
        private System.Windows.Forms.TextBox _firstNameBox;
        private System.Windows.Forms.TextBox _lastNameBox;
        private System.Windows.Forms.Label _lastName;
        private System.Windows.Forms.TextBox _userNameBox;
        private System.Windows.Forms.Label _username;
        private System.Windows.Forms.TextBox _emailBox;
        private System.Windows.Forms.Label _email;
    }
}

