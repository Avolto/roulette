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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            //Form1 parent
        }
        int supervillain = TransferDTO.supervillian;
       
        
        //you have 2 uses of spidersense 
        private int spidersense = 2;
        private Boolean AmIUsingSpidersense = false;
       
        

        //the "gun" is loaded. This is the variable that is loaded into defeat
        public void btnloadgun_Click(object sender, EventArgs e)
        {
            //defeat = 1;
        }

        //This is what happens when Mask On is selected. It randomly chooses a number from 1-6 and selects the villain that will be the players downdfall
        public void btnspinbarrel_Click(object sender, EventArgs e)
        {
            //Random defeat = new Random();
            //int supervillain = defeat.Next(1, 7);
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        public void btngreengoblin_Click_1(object sender, EventArgs e)
        {

            if (supervillain == 1 && AmIUsingSpidersense == false)
            {
                this.Hide();
                //you lose
                Form4 form4 = new Form4();
                form4.ShowDialog();
                form4.Show();
            }

            if (supervillain == 1 && AmIUsingSpidersense == true)
            {
                this.Hide();
                //you win
                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
            }

            //reset the ss to false for the next round
            if (AmIUsingSpidersense == true)
            {
                AmIUsingSpidersense = false;
            }

            //if this is not the villain that can kill you and whether spidersense is activated or not the villain is disabled after you click it meaning you defeat that one and can select another villain
            if (supervillain != 1 && spidersense == 0 || spidersense == 1 || spidersense == 2)
            {
                btngreengoblin.Enabled = false;
                
            }

        }

        private void btnvenom_Click_1(object sender, EventArgs e)
        {
            if (supervillain == 2 && AmIUsingSpidersense == false)
            {
                this.Hide();
                //you lose
                Form4 form4 = new Form4();
                form4.ShowDialog();
                form4.Show();
            }

            if (supervillain == 2 && AmIUsingSpidersense == true)
            {
                this.Hide();
                //you win
                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
            }

            //reset the ss to false for the next round
            if (AmIUsingSpidersense == true)
            {
                AmIUsingSpidersense = false;
            }

            //if this is not the villain that can kill you and whether spidersense is activated or not the villain is disabled after you click it meaning you defeat that one and can select another villain
            if (supervillain != 2 && spidersense == 0 || spidersense == 1 || spidersense == 2)
            {
                btnvenom.Enabled = false;
            }

            
        }

        private void btnmrnegative_Click_1(object sender, EventArgs e)
        {
            if (supervillain == 3 && AmIUsingSpidersense == false)
            {
                this.Hide();
                //you lose
                Form4 form4 = new Form4();
                form4.ShowDialog();
                form4.Show();
            }

            if (supervillain == 3 && AmIUsingSpidersense == true)
            {
                this.Hide();
                //you win
                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
            }

            //reset the ss to false for the next round
            if (AmIUsingSpidersense == true)
            {
                AmIUsingSpidersense = false;
            }

            //if this is not the villain that can kill you and whether spidersense is activated or not the villain is disabled after you click it meaning you defeat that one and can select another villain
            if (supervillain != 3 && spidersense == 0 || spidersense == 1 || spidersense == 2)
            {
                btnmrnegative.Enabled = false;
            }
        }

        private void btnlizard_Click_1(object sender, EventArgs e)
        {
            if (supervillain == 4 && AmIUsingSpidersense == false)
            {
                this.Hide();
                //you lose
                Form4 form4 = new Form4();
                form4.ShowDialog();
                form4.Show();
            }

            if (supervillain == 4 && AmIUsingSpidersense == true)
            {
                this.Hide();
                //you win
                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
            }

            //reset the ss to false for the next round
            if (AmIUsingSpidersense == true)
            {
                AmIUsingSpidersense = false;
            }

            //if this is not the villain that can kill you and whether spidersense is activated or not the villain is disabled after you click it meaning you defeat that one and can select another villain
            if (supervillain != 4 && spidersense == 0 || spidersense == 1 || spidersense == 2)
            {
                btnlizard.Enabled = false;
            }
        }

        private void btnmorlun_Click_1(object sender, EventArgs e)
        {
            if (supervillain == 5 && AmIUsingSpidersense == false)
            {
                this.Hide();
                //you lose
                Form4 form4 = new Form4();
                form4.ShowDialog();
                form4.Show();
            }

            if (supervillain == 5 && AmIUsingSpidersense == true)
            {
                this.Hide();
                //you win
                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
            }

            //reset the ss to false for the next round
            if (AmIUsingSpidersense == true)
            {
                AmIUsingSpidersense = false;
            }

            //if this is not the villain that can kill you and whether spidersense is activated or not the villain is disabled after you click it meaning you defeat that one and can select another villain
            if (supervillain != 5 && spidersense == 0 || spidersense == 1 || spidersense == 2)
            {
                btnmorlun.Enabled = false;
            }
        }

        private void btnoctavius_Click_1(object sender, EventArgs e)
        {
            if (supervillain == 6 && AmIUsingSpidersense == false)
            {
                this.Hide();
                //you lose
                Form4 form4 = new Form4();
                form4.ShowDialog();
                form4.Show();
            }

            if (supervillain == 6 && AmIUsingSpidersense == true)
            {
                this.Hide();
                //you win
                Form3 form3 = new Form3();
                form3.ShowDialog();
                form3.Show();
            }

            //reset the ss to false for the next round
            if (AmIUsingSpidersense == true)
            {
                AmIUsingSpidersense = false;
            }

            //if this is not the villain that can kill you and whether spidersense is activated or not the villain is disabled after you click it meaning you defeat that one and can select another villain
            if (supervillain != 6 && spidersense == 0 || spidersense == 1 || spidersense == 2)
            {
                btnoctavius.Enabled = false;
            }
        }

       
       

        private void btnspidersense_Click_1(object sender, EventArgs e)
        {
            //spidersense is reduced by 1 each time it is clicked 
            spidersense -= 1;
            AmIUsingSpidersense = true;

            //you have run out of spidersense button is disabled
            if (spidersense == 0)
            {
                btnspidersense.Enabled = false;
            }

        }

      
    }
}
