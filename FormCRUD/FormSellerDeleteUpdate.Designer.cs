namespace FormCRUD
{
	partial class FormSellerDeleteUpdate
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
			this.txbLastname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txbFirstname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txbTelephone = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txbAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txbStorename = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txbLastname
			// 
			this.txbLastname.Location = new System.Drawing.Point(142, 30);
			this.txbLastname.Name = "txbLastname";
			this.txbLastname.Size = new System.Drawing.Size(162, 25);
			this.txbLastname.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "姓氏";
			// 
			// txbFirstname
			// 
			this.txbFirstname.Location = new System.Drawing.Point(142, 61);
			this.txbFirstname.Name = "txbFirstname";
			this.txbFirstname.Size = new System.Drawing.Size(162, 25);
			this.txbFirstname.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(44, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "名字";
			// 
			// txbTelephone
			// 
			this.txbTelephone.Location = new System.Drawing.Point(142, 92);
			this.txbTelephone.Name = "txbTelephone";
			this.txbTelephone.Size = new System.Drawing.Size(162, 25);
			this.txbTelephone.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "連絡電話";
			// 
			// txbAddress
			// 
			this.txbAddress.Location = new System.Drawing.Point(142, 123);
			this.txbAddress.Name = "txbAddress";
			this.txbAddress.Size = new System.Drawing.Size(162, 25);
			this.txbAddress.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "聯絡地址";
			// 
			// txbStorename
			// 
			this.txbStorename.Location = new System.Drawing.Point(142, 154);
			this.txbStorename.Name = "txbStorename";
			this.txbStorename.Size = new System.Drawing.Size(162, 25);
			this.txbStorename.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "商店名稱";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(458, 281);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(146, 35);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "更新";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(12, 281);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(146, 35);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "刪除";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// FormSellerDeleteUpdate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 328);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txbStorename);
			this.Controls.Add(this.txbAddress);
			this.Controls.Add(this.txbTelephone);
			this.Controls.Add(this.txbFirstname);
			this.Controls.Add(this.txbLastname);
			this.Name = "FormSellerDeleteUpdate";
			this.Text = "FormSellerDeleteUpdate";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txbLastname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txbFirstname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txbTelephone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txbAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txbStorename;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
	}
}