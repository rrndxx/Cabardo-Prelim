using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabardo_Prelim
{
    public partial class CIrcle : Form
    {
        public CIrcle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                int radius = Int32.Parse(textBox1.Text.Trim());
                double circum = 2 * Math.PI * radius;
                circum.ToString();

                Result c = new Result("THE CIRCUMFERENCE OF THE CIRCLE IS : " + circum);
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("No radius entered", "Error");
            }
        }
    }
}
