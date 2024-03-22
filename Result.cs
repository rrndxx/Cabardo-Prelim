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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        public Result(string r) : this()
        {
            label1.Text = r;
        }
    
    }
}
