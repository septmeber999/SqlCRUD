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
	public partial class FormSellerDeleteUpdate : Form
	{
		private readonly int sid;
		public FormSellerDeleteUpdate(int sid)
		{
			InitializeComponent();
			this.sid = sid;
			this.Load += FormSellerDeleteUpdate_Load;
		}
		Entities EN = new Entities();
		private void FormSellerDeleteUpdate_Load(object sender, EventArgs e)
		{
			var seller = from s in EN.Sellers
						 where sid == s.ID
						 select s;

			foreach(var s in seller)
			{
				txbFirstname.Text = s.FirstName;
				txbLastname.Text = s.LastName;
				txbTelephone.Text = s.ContactNumber;
				txbAddress.Text = s.Address;
				txbStorename.Text = s.StoreName;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var seller = from s in EN.Sellers
						 where sid == s.ID
						 select s;

			foreach(var s in seller)
			{
				s.FirstName = txbFirstname.Text;
				s.LastName = txbLastname.Text;
				s.ContactNumber= txbTelephone.Text;
				s.Address= txbAddress.Text;
				s.StoreName= txbStorename.Text;
			}
			EN.SaveChanges();
			MessageBox.Show("更新成功");
			NotifyOwner();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var seller = from s in EN.Sellers
						 where sid == s.ID
						 select s;
			EN.Sellers.Remove(seller.First());
			EN.SaveChanges();
			MessageBox.Show("刪除成功");
			NotifyOwner();

		}
		private void NotifyOwner()
		{
			IGridContainer con = this.Owner as IGridContainer;
			if (con != null) con.Display();

			this.DialogResult = DialogResult.OK;
		}
	}
}
