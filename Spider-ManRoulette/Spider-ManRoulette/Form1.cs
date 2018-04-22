using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spider_ManRoulette
{
    public partial class Form1 : Form
    {
       //  Single defeat;
       
  
       int supervillain;
        public Form1()
        {
            InitializeComponent();


        }

         private void btnloadgun_Click(object sender, EventArgs e)
        {
           // defeat = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnspinbarrel_Click(object sender, EventArgs e)
        {Random defeat = new Random();
            this.Hide();
            
             supervillain = defeat.Next(1, 7);

            TransferDTO.supervillian = supervillain;
            Form2 form2 = new Form2();
            form2.ShowDialog();

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
