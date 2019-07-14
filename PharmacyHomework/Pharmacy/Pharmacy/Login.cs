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
	public partial class Login : Form
	{
		
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string Login = textUsername.Text.Trim();
			string Pass = txtPassword.Text.Trim();


			if (Login !="admin" || Pass !="123" ) {
				MessageBox.Show("Please enter correct username or pass","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
				return;
			}

			
			Aptek ZeferanAptek = new Aptek("Zeferan");
			Medicine medicine = new Medicine(this,ZeferanAptek);
			medicine.Show();
			medicine.dataGridView1.DataSource = ZeferanAptek.GetDerman();
			medicine.comboBox1.DataSource = ZeferanAptek.GetDerman();
			this.Hide();
		}
	}
}
