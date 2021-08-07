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
        private static bool isGameStart = false;
        private static bool isPlayer1 = true;
       
        private static readonly bool[] checkedFields = new bool[]{false, false, false,
                                                                  false, false, false,
                                                                  false, false, false};
        
        public MainForm()
        {
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            isGameStart = true;
            startButton.Visible = false;
            errorLabel.Text = "";
            winLabel.Text = "";
            playerLabel1.BackColor = Color.LightGreen;
            playerLabel2.BackColor = Color.LightGray;
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

                if (FieldCage.IsPlayerWin(fieldCage.Value))
                {
                    string result;
                    if (isPlayer1)
                    {
                        result = "Player 1 (X) won!!!";
                    }
                    else
                    {
                        result = "Player 2 (O) won!!!";
                    }
                    winLabel.Text = result;
                    startButton.Text = "Restart";
                    startButton.Visible = true;
                    isGameStart = false;
                }
                else
                {
                    ChangePlayer();
                    ChangePlayerColors();
                }
            }
            catch (Exception error) 
            {
                errorLabel.Text = error.Message;
            }
        }

        private void ChangePlayerColors()
        {
            if (playerLabel1.BackColor == Color.LightGreen)
            {
                playerLabel1.BackColor = Color.LightGray;
                playerLabel2.BackColor = Color.LightGreen;
            }
            else
            {
                playerLabel1.BackColor = Color.LightGreen;
                playerLabel2.BackColor = Color.LightGray;
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
