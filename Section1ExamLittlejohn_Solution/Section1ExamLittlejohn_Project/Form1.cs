/*
   Name: Stone Littlejohn
   Class: Obj-Orient Prg Using C#
   Trimester: Fall 2025
   Due Date: Sep 29, 2025
*/
namespace Section1ExamLittlejohn_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "A"; }
        private void btnB_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "B"; }
        private void btnC_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "C"; }
        private void btnD_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "D"; }
        private void btnE_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "E"; }
        private void btnF_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "F"; }
        private void btnG_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "G"; }
        private void btnH_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "H"; }
        private void btnI_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "I"; }
        private void btnJ_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "J"; }
        private void btnK_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "K"; }
        private void btnL_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "L"; }
        private void btnM_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "M"; }
        private void btnN_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "N"; }
        private void btnO_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "O"; }
        private void btnP_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "P"; }
        private void btnQ_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "Q"; }
        private void btnR_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "R"; }
        private void btnS_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "S"; }
        private void btnT_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "T"; }
        private void btnU_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "U"; }
        private void btnV_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "V"; }
        private void btnW_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "W"; }
        private void btnX_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "X"; }
        private void btnY_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "Y"; }
        private void btnZ_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "Z"; }

        private void btn0_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "0"; }
        private void btn1_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "1"; }
        private void btn2_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "2"; }
        private void btn3_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "3"; }
        private void btn4_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "4"; }
        private void btn5_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "5"; }
        private void btn6_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "6"; }
        private void btn7_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "7"; }
        private void btn8_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "8"; }
        private void btn9_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "9"; }

        private void btnDot_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + "."; }
        private void btnBlankSpace_Click(object sender, EventArgs e) { txtMessageBuilder.Text = txtMessageBuilder.Text + " "; }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessageBuilder.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblLastMessageSent.Text = txtMessageBuilder.Text;
            txtMessageBuilder.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainTable_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}