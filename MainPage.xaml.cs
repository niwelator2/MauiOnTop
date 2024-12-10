using System;
using System.Linq; // Ensure you include this for the Sum() method
using Microsoft.Maui.Controls;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        private readonly Random _random = new Random(); // Random number generator
        private int _totalGameScore = 0; // Total game score

        public MainPage()
        {
            InitializeComponent();

            // Initialize dice with placeholder images (dice_1.png)
            Dice1.Source = "kostkac.png";
            Dice2.Source = "kostkac.png";
            Dice3.Source = "kostkac.png";
            Dice4.Source = "kostkac.png";
            Dice5.Source = "kostkac.png";
            Dice6.Source = "kostkac.png";
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {
            // Generate random dice rolls
            int[] rolls = new int[6];
            for (int i = 0; i < 6; i++)
            {
                rolls[i] = _random.Next(1, 7); // Random dice values between 1 and 6
            }

            // Update dice images dynamically based on random rolls
            Dice1.Source = $"dice_{rolls[0]}.png";
            Dice2.Source = $"dice_{rolls[1]}.png";
            Dice3.Source = $"dice_{rolls[2]}.png";
            Dice4.Source = $"dice_{rolls[3]}.png";
            Dice5.Source = $"dice_{rolls[4]}.png";
            Dice6.Source = $"dice_{rolls[5]}.png";

            // Calculate the result of this roll
            int currentRollScore = rolls.Sum(); // Add up the values of all dice
            _totalGameScore += currentRollScore; // Add current roll to the total game score

            // Display results
            CurrentRollResult.Text = $"Wynik tego losowania: {currentRollScore}";
            GameResult.Text = $"Wynik gry: {_totalGameScore}";
        }

        private void OnResetClicked(object sender, EventArgs e)
        {
            // Reset game state
            _totalGameScore = 0; // Reset total score
            CurrentRollResult.Text = "Wynik tego losowania: 0"; // Reset roll result
            GameResult.Text = "Wynik gry: 0"; // Reset total game result

            // Reset dice images to placeholders (dice_1.png)
            Dice1.Source = "kostkac.png";
            Dice2.Source = "kostkac.png";
            Dice3.Source = "kostkac.png";
            Dice4.Source = "kostkac.png";
            Dice5.Source = "kostkac.png";
            Dice6.Source = "kostkac.png";
        }
    }
}