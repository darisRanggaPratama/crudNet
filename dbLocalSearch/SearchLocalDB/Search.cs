using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace SearchLocalDB
{
	public partial class Browse : MaterialSkin.Controls.MaterialForm
	{
		public Browse()
		{
			InitializeComponent();
			var skinManager = MaterialSkinManager.Instance;
			skinManager.AddFormToManage(this);
			skinManager.Theme = MaterialSkinManager.Themes.DARK;
			skinManager.ColorScheme = new ColorScheme(
				Primary.BlueGrey800, Primary.BlueGrey900,
				Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
		}

		private void Browse_Load(object sender, EventArgs e)
		{
			
			this.phoneTableAdapter.Fill(this.appDataSet.phone);
			Edit(false);
		}

		private void Edit(bool value)
		{
			txt_phone.Enabled = value;
			txt_name.Enabled = value;
			txt_email.Enabled = value;
			txt_address.Enabled = value;
		}

		private void btn_new_Click(object sender, EventArgs e)
		{
			try
			{
				Edit(true);
				appDataSet.phone.AddphoneRow(appDataSet.phone.NewphoneRow());
				phoneBindingSource.MoveLast();
				txt_phone.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				appDataSet.phone.RejectChanges();
			}
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			Edit(true);
			txt_phone.Focus();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			Edit(false);
			phoneBindingSource.ResetBindings(false);
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			try
			{
				Edit(false);
				phoneBindingSource.EndEdit();
				phoneTableAdapter.Update(appDataSet.phone);
				dataGridView.Refresh();
				txt_phone.Focus();
				MessageBox.Show("Your data has been successfully saved",
					"Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				appDataSet.phone.RejectChanges();
			}
		}

			private void txt_search_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (!string.IsNullOrEmpty(txt_search.Text))
				{
					phoneBindingSource.Filter = string.Format(
						   "PhoneNumber = '{0}' OR FullName LIKE '*{1}*'  OR Email = '{2}' OR Address LIKE '*{3}*'",
						   txt_phone.Text, txt_name.Text, txt_email.Text, txt_address.Text);
				} else
				{
					phoneBindingSource.Filter = string.Empty;
				}
			}
		}

		private void dataGridView_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Are you sure want to delete this record?", "Message", 
					MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
				{
					phoneBindingSource.RemoveCurrent();
				}

				
			}
		}
	}
}
