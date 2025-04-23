using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbChoice1.Enabled = false;
            
        }


        private bool _IsValidToSend()
        {

            if (pbQuestionPhoto.Image == null && tbQusetion.Text == "")
            {
                MessageBox.Show("You must put a Question ", "Error Message", MessageBoxButtons.OK);
                return false;

            }
            else if (!rbEasy.Checked && !rbMedium.Checked && !rbHard.Checked)
            {
                MessageBox.Show("You must put a Question Level ", "Error Message", MessageBoxButtons.OK);
                return false;

            }
            else if (!rbBiology.Checked && !rbChemitry.Checked && !rbMath.Checked && !rbPhysics.Checked)
            {
                MessageBox.Show("You must put a Subject ", "Error Message", MessageBoxButtons.OK);
                return false;

            }
            else if (!rbRightAnswerA.Checked && !rbRightAnswerB.Checked && !rbRightAnswerC.Checked && !rbRightAnswerD.Checked)
            {
                MessageBox.Show("You must put a Right Answer ", "Error Message", MessageBoxButtons.OK);
                return false;
            }

            else if ((tbChoice1.Text == "" && tbChoice2.Text == "" && tbChoice3.Text == "")
                ||(tbChoice2.Text == "" && tbChoice3.Text == "" && tbChoice4.Text == "")
                ||(tbChoice1.Text == "" && tbChoice2.Text == "" && tbChoice4.Text == "")
                ||(tbChoice1.Text == "" && tbChoice3.Text == "" && tbChoice4.Text == ""))
            {
                MessageBox.Show("You must put more than 2 answers ", "Error Message", MessageBoxButtons.OK);
                return false;
            }
            else if ((rbRightAnswerA.Checked && tbChoice1.Text == "") ||
                (rbRightAnswerB.Checked && tbChoice2.Text == "")
                || (rbRightAnswerC.Checked && tbChoice3.Text == "") ||
                (rbRightAnswerD.Checked && tbChoice4.Text == ""))
            {
                MessageBox.Show("You must a right answer", "Error Message", MessageBoxButtons.OK);
                return false;
            }


            return true;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!_IsValidToSend()) return;


            // logic to backend

            Reset();
        }

 
        void Reset()
        {
           EnableDisableGroupBoxes(false);
            ResetTextBars();
            pbQuestionPhoto.Image = null;
            tbChoice1.Enabled = false;
        }
        void ResetTextBars()
        {
            tbChoice1.Text = string.Empty;
            tbChoice2.Text = string.Empty;
            tbChoice3.Text = string.Empty;
            tbChoice4.Text = string.Empty;
            tbQusetion.Text = string.Empty;
        }

        void EnableDisableGroupBoxes(bool IsEnable = true)
        {
         
 
                gbQuestionLevel.Enabled = IsEnable;
                gbRightAnswer.Enabled = IsEnable;
                gbSubject.Enabled = IsEnable;
         


        }


        private void pbQuestionPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                pbQuestionPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                tbChoice1.Enabled=true;
                EnableDisableGroupBoxes();

            }

        }

        private void tbChoice1_TextChanged(object sender, EventArgs e)
        {
            if (tbChoice1.Text != "")
            {
                tbChoice2.Enabled = true;
                rbRightAnswerA.Enabled = true;

            }
            else
            {

                rbRightAnswerB.Enabled = false;
                rbRightAnswerA.Enabled = false;
                tbChoice2.Enabled = false;
                tbChoice2.Text = "";
            }
        }
        private void tbChoice2_TextChanged(object sender, EventArgs e)
        {
            if (tbChoice2.Text != "" && tbChoice1.Text != "")
            {
              
                tbChoice3.Enabled = true;
                rbRightAnswerB.Enabled = true;
              
            }
            else
            {
                tbChoice3.Enabled = false;
                rbRightAnswerC.Enabled = false;
                rbRightAnswerB.Enabled = false;
                tbChoice3.Text = "";
            }
        }

        private void tbChoice3_TextChanged(object sender, EventArgs e)
        {
            if (tbChoice3.Text != "" && tbChoice1.Text != "" && tbChoice2.Text != "")
            {
                tbChoice4.Enabled = true;
                rbRightAnswerC.Enabled = true;
            }
            else
            {
                tbChoice4.Enabled = false;
                rbRightAnswerD.Enabled = false;
                rbRightAnswerC.Enabled = false;
                tbChoice4.Text = "";
            }
        }


        private void tbChoice4_TextChanged_1(object sender, EventArgs e)
        {
            if (tbChoice4.Text != "")
            {

                rbRightAnswerD.Enabled = true;
            }
            else
            {

                rbRightAnswerD.Enabled = false;
            }
        }

        private void tbQusetion_TextChanged(object sender, EventArgs e)
        {
            if(tbQusetion.Text != "" || pbQuestionPhoto.Image != null)
            {
                tbChoice1.Enabled = true;
                EnableDisableGroupBoxes();
               
            }else 
            {
                tbChoice1.Enabled = false;
                tbChoice1.Text = "";
               EnableDisableGroupBoxes(false) ;
            }
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            pbQuestionPhoto.Image = null;
            if (tbQusetion.Text == "")
            {
                EnableDisableGroupBoxes(false);
                tbChoice1.Text = "";
                tbChoice1.Enabled = false;
            }
        }
    }
}
