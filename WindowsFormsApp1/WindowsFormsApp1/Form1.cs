using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			Program.f1 = this;
			InitializeComponent();
		}
		settings f2;
		pairs f3;
		//Form1 f1;
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button_pairs_Click(object sender, EventArgs e)
		{
			f3 = new pairs();
			f3.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button3_MouseCaptureChanged(object sender, EventArgs e)
		{
			this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.heart;
		}
		private void button1_MouseCaptureChanged(object sender, EventArgs e)
		{
			this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close__1_ ;
		}

        private void button_setings_Click(object sender, EventArgs e)
        {
			f2 = new settings();
			f2.Show();
			this.Hide();
			//if (f2.ShowDialog() == DialogResult.OK)
				//this.Show();

		}
    }
}
