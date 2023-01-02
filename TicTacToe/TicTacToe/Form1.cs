namespace TicTacToe
{
    public partial class Form1 : Form
    {

        public enum Player
        { 
            X,O
        }

        Player currentPlayer;
        Random random= new Random();
        int playerWinCount = 0;                                                  //win count for player
        int cpuWinCount = 0;                                                    //win count for CPU
        List<Button> buttons;                                                   //List of buttons
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {

            /*
             After the click button turn to DarkSalmon and the button is disable 
            from any changes
             */
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled= false;                                     //Disable the button from any changes
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();
            }


        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            /*
             After click turn the button to Cyan and disable from any changes.
             */
            var button = (Button) sender;

            currentPlayer= Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled= false;                                                 //Disable the button from any changes
            button.BackColor= Color.Cyan;
            buttons.Remove(button);
            CheckGame();
            CPUTimer.Start();
        }

        private void RestartGameButton(object sender, EventArgs e)
        {
            //restart game
            RestartGame();
        }

        private void CheckGame() 
        {
            //Checks the condition for player to wins
            if ((button1.Text == "X" && button2.Text == "X" && button3.Text == "X") 
                || (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
                || (button7.Text == "X" && button8.Text == "X" && button9.Text == "X") 
                || (button1.Text == "X" && button5.Text == "X" && button7.Text == "X") 
                || (button9.Text == "X" && button5.Text == "X" && button3.Text == "X") 
                || (button1.Text == "X" && button6.Text == "X" && button9.Text == "X") 
                || (button2.Text == "X" && button5.Text == "X" && button8.Text == "X") 
                || (button3.Text == "X" && button4.Text == "X" && button7.Text == "X"))
            {
                CPUTimer.Stop();                                                    //Stops the CPU timer 
                MessageBox.Show("Player Wins !!");                                  //Prints the pop up message
                playerWinCount++;                                                   //increment the win of the player
                label1.Text= "Player Wins: " + playerWinCount;                      //Prints the count in the label_1
                RestartGame();                                                      //restarts the game 
            }

            //Check the winning condition for CPU to win
            else if ((button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                || (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                || (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                || (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
                || (button9.Text == "O" && button5.Text == "O" && button3.Text == "O")
                || (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
                || (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                || (button3.Text == "O" && button4.Text == "O" && button7.Text == "O"))
            {
                CPUTimer.Stop();                                                     //Stops the CPU timer
                MessageBox.Show("CPU Wins !!");                                      //Print pop up message
                cpuWinCount++;                                                       //increment the count of win for CPU
                label2.Text = "CPU Wins: " + cpuWinCount;                            //Prints the count in Label_2
                RestartGame();                                                       //restarts the game
            }
        }

        private void RestartGame()
        { 
            buttons = new List<Button> { button1,button2,button3,button4,button5,button6,button7,button8,button9 };

            foreach (Button x in buttons)
            {
                x.Enabled= true;
                x.Text = "";
                x.BackColor= DefaultBackColor;
            }
        }

    }
}