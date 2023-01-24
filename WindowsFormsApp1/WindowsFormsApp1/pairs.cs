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
    public partial class pairs : Form
    {
        public pairs()
        {
            InitializeComponent();
        }

        private void button_back2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.f1.Visible = true;
            
        }
    }
}
