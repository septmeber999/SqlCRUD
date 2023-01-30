using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormCRUD
{
	public partial class FormHome : Form
	{
		public FormHome()
		{
			InitializeComponent();
		}
		Entities EN = new Entities();
		private void button1_Click(object sender, EventArgs e)
		{
			{
				if (comboBox1.Text == "Seller")
				{
					if (textBox1.Text != string.Empty)
					{
						var seller = from s in EN.Sellers
									 where s.Account.Contains(textBox1.Text)
									 select s;

						dataGridView1.DataSource = seller.ToList();
					}
					else
					{
						var seller = from s in EN.Sellers
									 select s;

						dataGridView1.DataSource = seller.ToList();
					}
				}
				else if (comboBox1.Text == "Member")
				{
					if (textBox1.Text != string.Empty)
					{
						var member = from m in EN.Members
									 where m.Account.Contains(textBox1.Text)
									 select m;

						dataGridView1.DataSource = member.ToList();
					}
					else
					{
						var member = from m in EN.Members
									 select m;

						dataGridView1.DataSource = member.ToList();
					}
				}
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (comboBox1.Text == "Seller")
			{
				var seller = from s in EN.Sellers
							 where s.Account.Contains(textBox1.Text)
							 select s;
				int sid = seller.ToList()[e.RowIndex].ID;
				FormSellerDeleteUpdate frm = new FormSellerDeleteUpdate(sid);
				frm.Owner= this;
				frm.ShowDialog();
			}
			else if (comboBox1.Text == "Member")
			{
				var member = from m in EN.Members
							 where m.Account.Contains(textBox1.Text)
							 select m;

				int mid = member.ToList()[e.RowIndex].ID;

				FormMemberDeleteUpdate frm = new FormMemberDeleteUpdate(mid);
				frm.Owner= this;
				frm.ShowDialog();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			FormCreatSeller frm= new FormCreatSeller();
			frm.ShowDialog();
		}
	}
}
