using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    class Form1
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;

        private void buttonStart_Click()
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Enter your name", "The game can not be started yet.");
                return;
            }
            game = new Game(textName.Text, new List<string> { "Player 1", "Player 2" }, textProgress);
            buttonStart.Enabled = false;
            textName.Enabled = false;
            buttonAsk.Enabled = true;
            UpdateForm();
        }

        private void buttonAsk_Click()
        {
            textProgress.Text = "";
            if (listHand.SelectedIndex < 0)
            {
                MessageBox.Show("Choose a card.");
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += "The winner is..." + Environment.NewLine + game.GetWinnerName();
                textMatches.Text = game.DescribeMatches();
                buttonAsk.Enabled = false;
            }
            else
                UpdateForm();
        }

        private void UpdateForm()
        {
            listHand.Items.Clear();
            foreach (string cardName in game.GetPlayerCardNames())
                listHand.Items.Add(cardName);
            textMatches.Text = game.DescribeMatches();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();
        }
    }
