using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
	public partial class Medicine : Form
	{
		Login mylogin;
		Aptek myaptek;
		public Medicine(Login login, Aptek aptek)
		{
			InitializeComponent();
			myaptek = aptek;
			mylogin = login;
		}

		private void Medicine_FormClosing(object sender, FormClosingEventArgs e)
		{
			mylogin.Close();
		}

		private void Add_Click(object sender, EventArgs e)
		{

			if (txtDermanAdi.Text =="" || txtDermantipi.Text == "" || txtDermanqitmeti.Text == "") {
				MessageBox.Show("Zehmet olmasa bos saheleri doldurun", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			Derman myderman = new Derman();
			myderman.Dermannovu = txtDermantipi.Text;
			myderman.Name = txtDermanAdi.Text;
			myderman.price = double.Parse(txtDermanqitmeti.Text);
			myaptek.AddMedicine(myderman);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = myaptek.GetDerman();
			comboBox1.DataSource = null;
			comboBox1.DataSource = myaptek.GetDerman();
			txtDermantipi.Text = "";
			txtDermanAdi.Text = "";
			txtDermanqitmeti.Text = "";


		}

		private void delete_Click(object sender, EventArgs e)
		{
			int index = int.Parse( comboBox1.SelectedValue.ToString().Substring(0,2).Trim());
			myaptek.DeleteMedicine(index);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = myaptek.GetDerman();
			comboBox1.DataSource = null;
			comboBox1.DataSource = myaptek.GetDerman();
		}

		private int upindex;
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
			upindex = id;
			Derman derman = myaptek.GetDerman(id);
			txtDermanAdi.Text = derman.Name;
			txtDermantipi.Text = derman.Dermannovu;
			txtDermanqitmeti.Text =derman.price.ToString();
		}

		private void update_Click(object sender, EventArgs e)
		{
			string type = txtDermantipi.Text;
			string name = txtDermanAdi.Text;
			double price = double.Parse(txtDermanqitmeti.Text);

			if (txtDermanAdi.Text == "" || txtDermantipi.Text == "" || txtDermanqitmeti.Text == "")
			{
				MessageBox.Show("Zehmet olmasa bos saheleri doldurun", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			myaptek.Update(upindex, type, name, price);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = myaptek.GetDerman();

			txtDermanAdi.Text = "";
			txtDermanqitmeti.Text = "";
			txtDermantipi.Text = "";
		}
	}
}
