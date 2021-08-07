using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        private bool isGameStart = false;
        private bool isPlayer1 = true;
        private int score1 = 0,
            score2 = 0;
        private readonly bool[] checkedFields = {false, false, false,
                                                 false, false, false,
                                                 false, false, false};
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Button[] fieldCages = { field1, field2, field3, field4, field5, field6, field7, field8, field9 };
            foreach (Button cage in fieldCages)
            {
                cage.Text = "";
                cage.BackColor = Color.White;
            }
            for (int i = 0; i < checkedFields.Length; i++)
            {
                checkedFields[i] = false;
            }
            isGameStart = true;
            startButton.Visible = false;
            errorLabel.Text = "";
            winLabel.Text = "";
            playerLabel1.BackColor = Color.LightGreen;
            playerLabel2.BackColor = Color.LightCyan;
            FieldCage.PosX_List = new List<int>();
            FieldCage.PosO_List = new List<int>();
        }
        private void FieldClick(int cagePosition, Button field)
        {
            try
            {
                if (!isGameStart)
                {
                    throw new Exception("Game was not started");
                }
                else if (checkedFields[cagePosition - 1])
                {
                    throw new Exception("Field is already occupied");
                }

                errorLabel.Text = "";

                FieldCage fieldCage = new FieldCage(cagePosition, isPlayer1);

                field.Text = fieldCage.Value.ToString();
                checkedFields[cagePosition - 1] = true;

                CheckIfWon(fieldCage.Value);
                CheckIfDraw();
                ChangePlayer();
                ChangePlayerColors();
            }
            catch (Exception error) 
            {
                errorLabel.Text = error.Message;
            }
        }

        private void CheckIfWon(FieldCage.Values value)
        {
            if (FieldCage.IsPlayerWin(value))
            {
                string result;
                if (isPlayer1)
                {
                    result = "Player 1 (X) won!!!";
                    score1++;
                }
                else
                {
                    result = "Player 2 (O) won!!!";
                    score2++;
                }

                ChangeFieldColor(FieldCage.GetWonCombination());

                winLabel.Text = result;
                startButton.Text = "Restart";
                startButton.Visible = true;
                isGameStart = false;
                score.Text = $"{score1} : {score2}";
            }
        }
        private void CheckIfDraw()
        {
            bool allOccupied = true;
            foreach (bool value in checkedFields)
            {
                if (value == false)
                {
                    allOccupied = false;
                }
            }
            if (allOccupied)
            {
                winLabel.Text = "There is a draw!!!";
                startButton.Text = "Restart";
                startButton.Visible = true;
                isGameStart = false;
            }
        }
        private void ChangeFieldColor(int[] combination)
        {
            Button[] fieldCages = { field1, field2, field3, field4, field5, field6, field7, field8, field9 };
            foreach (int num in combination)
            {
                for (int i = 0; i < fieldCages.Length; i++)
                {
                    if (num == i + 1)
                    {
                        fieldCages[i].BackColor = Color.LightGreen;
                        break;
                    }
                }
            }
        }
        private void ChangePlayerColors()
        {
            if (playerLabel1.BackColor == Color.LightGreen)
            {
                playerLabel1.BackColor = Color.LightCyan;
                playerLabel2.BackColor = Color.LightGreen;
            }
            else
            {
                playerLabel1.BackColor = Color.LightGreen;
                playerLabel2.BackColor = Color.LightCyan;
            }
        }
        private void ChangePlayer()
        {
            if (isPlayer1)
            {
                isPlayer1 = false;
            }
            else
            {
                isPlayer1 = true;
            }
        }

        private void Field1_Click(object sender, EventArgs e)
        {
            FieldClick(1, field1);
        }

        private void Field2_Click(object sender, EventArgs e)
        {
            FieldClick(2, field2);
        }

        private void Field3_Click(object sender, EventArgs e)
        {
            FieldClick(3, field3);
        }

        private void Field4_Click(object sender, EventArgs e)
        {
            FieldClick(4, field4);
        }

        private void Field5_Click(object sender, EventArgs e)
        {
            FieldClick(5, field5);
        }

        private void Field6_Click(object sender, EventArgs e)
        {
            FieldClick(6, field6);
        }

        private void Field7_Click(object sender, EventArgs e)
        {
            FieldClick(7, field7);
        }

        private void Field8_Click(object sender, EventArgs e)
        {
            FieldClick(8, field8);
        }

        private void Field9_Click(object sender, EventArgs e)
        {
            FieldClick(9, field9);
        }

    }
}
