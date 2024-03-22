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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()) && !string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                int length = Int32.Parse(textBox1.Text.Trim());
                int width = Int32.Parse(textBox2.Text.Trim());
                int res = 2 * (length + width);
                res.ToString();

                Result r = new Result("THE PERIMETER OF THE RECTANGLE IS : " + res);
                r.ShowDialog();
            }
            else
            {
                MessageBox.Show("No length or width entered", "Error");
            }
        }
    }
}
