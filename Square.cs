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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                int side = Int32.Parse(textBox1.Text.Trim());
                int res = side * 4;
                res.ToString();

                Result s = new Result("THE PERIMETER OF THE SQUARE IS : " + res);
                s.ShowDialog();
            }
            else
            {
                MessageBox.Show("No side entered", "Error");
            }
        }
    }
}
