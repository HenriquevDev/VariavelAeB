using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VariavelAeB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrocarValores_Click(object sender, EventArgs e)
        {
            int A, B, temp;



            A = int.Parse(txtA.Text);
            B = int.Parse(txtB.Text);



            temp = A;
            A = B;
            B = temp;



            txtA.Text = A.ToString();
            txtB.Text = B.ToString();
        }
    }
}
