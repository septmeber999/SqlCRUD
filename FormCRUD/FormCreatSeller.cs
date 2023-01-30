using CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCRUD
{
	public partial class FormCreatSeller : Form
	{
		public FormCreatSeller()
		{
			InitializeComponent();
		}
		Entities EN = new Entities();
		private void button1_Click(object sender, EventArgs e)
		{
			CRUDTool tool= new CRUDTool();
			if (tool.RegexAccount(txbAccount.Text))
			{
				lbAcountER.Text = "請輸入正確帳號格式";
				txbAccount.Clear();
				return;
			}
			if (tool.RegexPassword(txbPassword.Text))
			{
				lbPasswordER.Text = "請輸入正確密碼格式";
				txbPassword.Clear();
				return;
			}
			string date = dateTimePicker1.Value.ToString("yyyy/MM/dd");
			Sellers sellers= new Sellers();
			sellers.Account = txbAccount.Text;
			sellers.Password = txbPassword.Text;
			sellers.LastName = txbLastname.Text;
			sellers.FirstName = txbFirstname.Text;
			sellers.IdentityNumber = txbIdnum.Text;
			sellers.ContactNumber = txbTelephone.Text;
			sellers.Address = txbAddress.Text;
			sellers.StoreName = txbStorename.Text;
			sellers.BirthDate = DateTime.Parse(date);
			sellers.WasSuspended = false;
			sellers.SuspensionStatus = false;
			sellers.RegisterDate = DateTime.Now;
			sellers.LastLogin = DateTime.Now;

			EN.Sellers.Add(sellers);
			EN.SaveChanges();
			txbAccount.Clear();
			txbPassword.Clear();
			txbLastname.Clear();
			txbFirstname.Clear();
			txbIdnum.Clear();
			txbTelephone.Clear();
			txbAddress.Clear();
			txbStorename.Clear();
			MessageBox.Show("創建成功");
		}
	}
}
