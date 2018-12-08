using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamblingProblem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Deck d = new Deck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
