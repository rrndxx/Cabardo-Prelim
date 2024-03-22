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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            CIrcle c = new CIrcle();
            c.Show();
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            Triangle t = new Triangle();
            t.Show();
        }

        private void Square_Click(object sender, EventArgs e)
        {
            Square s = new Square();
            s.Show();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle();
            r.Show();
        }
    }
}
