namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int players = 2; //even = 0 move; odd = X move
        public int moves = 0; //counting moves;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (players % 2 !=0)
            {
                button.Text = "O";
                players++;
                moves++;
            }
            else
            {
                button.Text = "X";
                players++;
                moves++;
            }

            if (CheckWinner() == true)
            {
                if (button.Text == "X")
                {
                    MessageBox.Show("X wins!");
                    Close();
                }
                else
                {
                    MessageBox.Show("O wins!");
                    Close();
                }

                if (CheckDraw() == true)
                {
                    MessageBox.Show("Issa draw!");
                    Close();
                }
            }
            bool CheckWinner()
            {
                //horizontal checks
                if ((A.Text == D.Text) && (D.Text == G.Text) && A.Text != "")
                    return true;
                else if ((B.Text == E.Text) && (E.Text == H.Text) && B.Text != "")
                    return true;
                else if ((C.Text == F.Text) && (F.Text == I.Text) && C.Text != "")
                    return true;

                //vertical checks
                if ((A.Text == B.Text) && (B.Text == C.Text) && A.Text != "")
                    return true;
                else if ((D.Text == E.Text) && (E.Text == F.Text) && D.Text != "")
                    return true;
                else if ((G.Text == H.Text) && (H.Text == I.Text) && G.Text != "")
                    return true;

                //diagonal checks
                if ((A.Text == E.Text) && (E.Text == I.Text) && A.Text != "")
                    return true;
                else if ((G.Text == E.Text) && (E.Text == C.Text) && G.Text != "")
                    return true;
                else
                    return false;
            }
            
            bool CheckDraw()
            {
                if (moves == 9)
                    return true;
                else
                    return false;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}