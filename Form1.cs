using System;
using System.Windows.Forms;
using ClassmatesRpgBattleSim.Models;

namespace ClassmatesRpgBattleSim
{
    public partial class Form1 : Form
    {
        private ClassFighter? player1;
        private ClassFighter? player2;
        private bool battleInProgress = false;
        private int currentTurn = 0;
        private bool isPlayer1Turn = true;
        private System.Windows.Forms.Timer battleTimer = null!;
        private const int TURN_DELAY = 2500; // 2.5 seconds delay between turns
        private int remainingTime = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeBattleTimer();
        }

        private void InitializeBattleTimer()
        {
            battleTimer = new System.Windows.Forms.Timer();
            battleTimer.Interval = 100; // Update timer display every 100ms
            battleTimer.Tick += BattleTimer_Tick;
        }

        private void BattleTimer_Tick(object? sender, EventArgs e)
        {
            if (!battleInProgress || player1 == null || player2 == null) return;

            try
            {
                remainingTime -= battleTimer.Interval;
                UpdateTimerDisplay();

                if (remainingTime <= 0)
                {
                    if (isPlayer1Turn)
                    {
                        // Player 1 attacks
                        int damage1 = player1.Attack();
                        bool player2Alive = player2.TakeDamage(damage1);
                        LogBattle($"{player1.Name} attacks for {damage1} damage! {player2.Name} has {player2.Health} health remaining.");
                        UpdateHealthLabels();

                        if (!player2Alive)
                        {
                            EndBattle(player1);
                            return;
                        }
                    }
                    else
                    {
                        // Player 2 attacks
                        int damage2 = player2.Attack();
                        bool player1Alive = player1.TakeDamage(damage2);
                        LogBattle($"{player2.Name} attacks for {damage2} damage! {player1.Name} has {player1.Health} health remaining.");
                        UpdateHealthLabels();

                        if (!player1Alive)
                        {
                            EndBattle(player2);
                            return;
                        }

                        // Increment turn counter after both players have moved
                        currentTurn++;
                    }

                    // Switch turns and reset timer
                    isPlayer1Turn = !isPlayer1Turn;
                    remainingTime = TURN_DELAY;
                    UpdateBattleStatus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the turn: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopBattle();
            }
        }

        private void UpdateTimerDisplay()
        {
            if (!battleInProgress)
            {
                lblTimer.Text = "Timer: --";
                return;
            }

            double secondsRemaining = Math.Ceiling(remainingTime / 1000.0);
            lblTimer.Text = $"Timer: {secondsRemaining:F1}s";
        }

        private void BtnStartBattle_Click(object sender, EventArgs e)
        {
            try
            {
                if (battleInProgress)
                {
                    MessageBox.Show("A battle is already in progress!", "Battle Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get Player 1's character
                using (var selectionForm = new CharacterSelectionForm())
                {
                    if (selectionForm.ShowDialog() == DialogResult.OK)
                    {
                        player1 = CreateFighter(selectionForm.SelectedName, selectionForm.SelectedType);
                    }
                    else
                    {
                        return; // User cancelled
                    }
                }

                // Get Player 2's character
                using (var selectionForm = new CharacterSelectionForm())
                {
                    if (selectionForm.ShowDialog() == DialogResult.OK)
                    {
                        player2 = CreateFighter(selectionForm.SelectedName, selectionForm.SelectedType);
                    }
                    else
                    {
                        return; // User cancelled
                    }
                }

                // Initialize battle
                currentTurn = 1;
                isPlayer1Turn = true;
                battleInProgress = true;
                remainingTime = TURN_DELAY;

                // Update UI
                UpdateBattleStatus();
                UpdateTimerDisplay();
                EnableBattleControls(true);
                UpdateCharacterPanels();
                LogBattle("Battle started!");
                LogBattle($"{player1.Name} ({player1.GetType().Name}) vs {player2.Name} ({player2.GetType().Name})");
                LogBattle("----------------------------------------");

                // Start the battle timer
                battleTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                StopBattle();
            }
        }

        private void BtnResetBattle_Click(object sender, EventArgs e)
        {
            if (player1 != null && player2 != null)
            {
                StopBattle();
                player1.ResetHealth();
                player2.ResetHealth();
                currentTurn = 1;
                isPlayer1Turn = true;
                remainingTime = TURN_DELAY;
                UpdateHealthLabels();
                UpdateCharacterPanels();
                UpdateBattleStatus();
                UpdateTimerDisplay();
                LogBattle("----------------------------------------");
                LogBattle("Battle has been reset!");
                LogBattle("----------------------------------------");
            }
        }

        private void BtnSurrender_Click(object sender, EventArgs e)
        {
            if (!battleInProgress || player1 == null || player2 == null) return;

            ClassFighter winner = isPlayer1Turn ? player2 : player1;
            EndBattle(winner);
            LogBattle($"{winner.Name} wins by surrender!");
        }

        private ClassFighter CreateFighter(string name, string type)
        {
            return type switch
            {
                "CodeCrusher" => new CodeCrusher(name),
                "QuizMaster" => new QuizMaster(name),
                "Debugger" => new Debugger(name),
                _ => throw new ArgumentException($"Unknown fighter type: {type}")
            };
        }

        private void EndBattle(ClassFighter winner)
        {
            LogBattle("----------------------------------------");
            LogBattle($"{winner.Name} wins the battle!");
            StopBattle();
            UpdateBattleStatus();
        }

        private void StopBattle()
        {
            battleInProgress = false;
            battleTimer.Stop();
            EnableBattleControls(false);
            UpdateTimerDisplay();
            UpdateHealthLabels(); // Reset health labels to waiting state
            UpdateCharacterPanels();
        }

        private void LogBattle(string message)
        {
            txtBattleLog.AppendText(message + Environment.NewLine);
            txtBattleLog.ScrollToCaret();
        }

        private void UpdateHealthLabels()
        {
            if (player1 == null || player2 == null)
            {
                UpdateCharacterPanels();
                return;
            }
            UpdateCharacterPanels();
        }

        private void UpdateBattleStatus()
        {
            if (!battleInProgress)
            {
                lblTurnInfo.Text = "Battle Status: Not Started";
                return;
            }

            string currentPlayer = isPlayer1Turn ? player1?.Name ?? "Unknown" : player2?.Name ?? "Unknown";
            lblTurnInfo.Text = $"Turn {currentTurn}: {currentPlayer}'s Turn";
        }

        private void EnableBattleControls(bool enable)
        {
            btnResetBattle.Enabled = enable;
            btnSurrender.Enabled = enable;
            btnStartBattle.Enabled = !enable;
        }

        private int GetBaseAttack(ClassFighter fighter)
        {
            if (fighter is CodeCrusher)
                return 15;
            if (fighter is QuizMaster)
                return 20;
            if (fighter is Debugger)
                return 12;
            return 0;
        }

        private void UpdateCharacterPanels()
        {
            // Player 1
            if (player1 != null)
            {
                lblPlayer1Name.Text = $"Name: {player1.Name}";
                lblPlayer1Type.Text = $"Type: {player1.GetType().Name}";
                lblPlayer1HealthStat.Text = $"Health: {player1.Health}";
                lblPlayer1Attack.Text = $"Attack: {GetBaseAttack(player1)}";
                // Load image if available
                string imgPath = $"Images/{player1.GetType().Name}.png";
                if (System.IO.File.Exists(imgPath))
                    picPlayer1.Image = System.Drawing.Image.FromFile(imgPath);
                else
                    picPlayer1.Image = null;
            }
            else
            {
                lblPlayer1Name.Text = "Name:";
                lblPlayer1Type.Text = "Type:";
                lblPlayer1HealthStat.Text = "Health:";
                lblPlayer1Attack.Text = "Attack:";
                picPlayer1.Image = null;
            }

            // Player 2
            if (player2 != null)
            {
                lblPlayer2Name.Text = $"Name: {player2.Name}";
                lblPlayer2Type.Text = $"Type: {player2.GetType().Name}";
                lblPlayer2HealthStat.Text = $"Health: {player2.Health}";
                lblPlayer2Attack.Text = $"Attack: {GetBaseAttack(player2)}";
                // Load image if available
                string imgPath = $"Images/{player2.GetType().Name}.png";
                if (System.IO.File.Exists(imgPath))
                    picPlayer2.Image = System.Drawing.Image.FromFile(imgPath);
                else
                    picPlayer2.Image = null;
            }
            else
            {
                lblPlayer2Name.Text = "Name:";
                lblPlayer2Type.Text = "Type:";
                lblPlayer2HealthStat.Text = "Health:";
                lblPlayer2Attack.Text = "Attack:";
                picPlayer2.Image = null;
            }
        }
    }
}
