namespace lab_5
{
	partial class SearchForm
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
			this.cbFields = new System.Windows.Forms.ComboBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.bSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(161, 28);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.Size = new System.Drawing.Size(548, 141);
			this.dataGridView.TabIndex = 0;
			// 
			// cbFields
			// 
			this.cbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFields.FormattingEnabled = true;
			this.cbFields.Location = new System.Drawing.Point(12, 28);
			this.cbFields.Name = "cbFields";
			this.cbFields.Size = new System.Drawing.Size(132, 21);
			this.cbFields.TabIndex = 1;
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(12, 70);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(132, 20);
			this.tbSearch.TabIndex = 2;
			// 
			// bSearch
			// 
			this.bSearch.Location = new System.Drawing.Point(12, 146);
			this.bSearch.Name = "bSearch";
			this.bSearch.Size = new System.Drawing.Size(132, 23);
			this.bSearch.TabIndex = 3;
			this.bSearch.Text = "Найти!";
			this.bSearch.UseVisualStyleBackColor = true;
			this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 201);
			this.Controls.Add(this.bSearch);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.cbFields);
			this.Controls.Add(this.dataGridView);
			this.Name = "SearchForm";
			this.Text = "Поиск";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.ComboBox cbFields;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Button bSearch;
	}
}