using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ClassmatesRpgBattleSim.Models;

namespace ClassmatesRpgBattleSim
{
    public partial class CharacterSelectionForm : Form
    {
        private PictureBox characterImage;
        private Label characterName;
        private TextBox characterStatsBox;
        private TextBox characterDescriptionBox;
        private ComboBox characterType;
        private Button selectButton;
        private Button cancelButton;
        private TextBox nameInput;
        private PictureBox[] characterPortraits;
        private Panel detailsPanel;
        private int selectedCharacterIndex = 0;
        private readonly string[] characterTypes = { "CodeCrusher", "QuizMaster", "Debugger" };
        private Label classLabel;

        public string SelectedName { get; private set; } = string.Empty;
        public string SelectedType { get; private set; } = string.Empty;

        public CharacterSelectionForm()
        {
            InitializeComponent();
            InitializeCharacterSelection();
        }

        private void InitializeComponent()
        {
            this.Text = "Select Your Character";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // Theming: Form background
            this.BackColor = Color.FromArgb(200, 255, 200); // Light green
        }

        private void InitializeCharacterSelection()
        {
            // Remove ComboBox and use grid of portraits
            this.Controls.Clear();

            // Portrait grid panel (left)
            Panel gridPanel = new Panel
            {
                Location = new Point(30, 30),
                Size = new Size(240, 520),
                BackColor = Color.Transparent
            };
            characterPortraits = new PictureBox[characterTypes.Length];
            for (int i = 0; i < characterTypes.Length; i++)
            {
                characterPortraits[i] = new PictureBox
                {
                    Name = $"portrait_{characterTypes[i]}",
                    Size = new Size(200, 150),
                    Location = new Point(20, 20 + i * 170),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand,
                    Tag = i,
                    BackColor = Color.White
                };
                characterPortraits[i].Image = LoadCharacterImage(characterTypes[i]);
                characterPortraits[i].Click += Portrait_Click;
                gridPanel.Controls.Add(characterPortraits[i]);
            }

            // Details panel (right)
            detailsPanel = new Panel
            {
                Location = new Point(300, 30),
                Size = new Size(450, 520),
                BackColor = Color.FromArgb(245, 245, 220) // Notebook paper
            };

            // Large character image
            characterImage = new PictureBox
            {
                Location = new Point(125, 20),
                Size = new Size(200, 180),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };
            detailsPanel.Controls.Add(characterImage);

            // Character class label (now directly under the image)
            classLabel = new Label
            {
                Text = "Class: ",
                Location = new Point(125, 205), // X matches image, Y is image bottom + 5
                AutoSize = true,
                Font = new Font("Comic Sans MS", 10F, FontStyle.Bold)
            };
            detailsPanel.Controls.Add(classLabel);

            // Name label and input
            Label nameLabel = new Label
            {
                Text = "Character Name:",
                Location = new Point(30, 240),
                AutoSize = true,
                Font = new Font("Comic Sans MS", 10F)
            };
            detailsPanel.Controls.Add(nameLabel);
            nameInput = new TextBox
            {
                Location = new Point(160, 237),
                Width = 220,
                MaxLength = 20,
                Font = new Font("Comic Sans MS", 10F)
            };
            nameInput.TextChanged += NameInput_TextChanged;
            detailsPanel.Controls.Add(nameInput);

            // Stats label
            Label statsLabel = new Label
            {
                Text = "Stats:",
                Location = new Point(30, 260),
                AutoSize = true,
                Font = new Font("Comic Sans MS", 10F)
            };
            detailsPanel.Controls.Add(statsLabel);
            characterStatsBox = new TextBox
            {
                Location = new Point(30, 285),
                Size = new Size(390, 60),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Font = new Font("Comic Sans MS", 10F),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };
            detailsPanel.Controls.Add(characterStatsBox);

            // Description label
            Label descLabel = new Label
            {
                Text = "Description:",
                Location = new Point(30, 355),
                AutoSize = true,
                Font = new Font("Comic Sans MS", 10F)
            };
            detailsPanel.Controls.Add(descLabel);
            characterDescriptionBox = new TextBox
            {
                Location = new Point(30, 380),
                Size = new Size(390, 70),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Font = new Font("Comic Sans MS", 10F),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical
            };
            detailsPanel.Controls.Add(characterDescriptionBox);

            // Buttons
            selectButton = new Button
            {
                Text = "Select Character",
                Location = new Point(60, 470),
                Size = new Size(150, 35),
                Enabled = false,
                BackColor = Color.Gold,
                ForeColor = Color.Black,
                Font = new Font("Comic Sans MS", 11F, FontStyle.Bold)
            };
            selectButton.Click += SelectButton_Click;
            detailsPanel.Controls.Add(selectButton);

            cancelButton = new Button
            {
                Text = "Cancel",
                Location = new Point(240, 470),
                Size = new Size(150, 35),
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                Font = new Font("Comic Sans MS", 11F, FontStyle.Bold)
            };
            cancelButton.Click += CancelButton_Click;
            detailsPanel.Controls.Add(cancelButton);

            // Add panels to form
            this.Controls.Add(gridPanel);
            this.Controls.Add(detailsPanel);

            // Select the first character by default
            SelectCharacter(0);
        }

        private void Portrait_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is int idx)
            {
                SelectCharacter(idx);
            }
        }

        private void SelectCharacter(int idx)
        {
            selectedCharacterIndex = idx;
            for (int i = 0; i < characterPortraits.Length; i++)
            {
                characterPortraits[i].BorderStyle = (i == idx) ? BorderStyle.Fixed3D : BorderStyle.FixedSingle;
            }
            string type = characterTypes[idx];
            characterImage.Image = LoadCharacterImage(type);
            classLabel.Text = $"Class: {type}";
            nameInput.Text = nameInput.Text; // keep user input
            UpdateCharacterDisplay(type);
            UpdateSelectButtonState();
        }

        private void UpdateSelectButtonState()
        {
            selectButton.Enabled = !string.IsNullOrWhiteSpace(nameInput.Text);
        }

        private void CharacterType_SelectedIndexChanged(object sender, EventArgs e) { /* no longer used */ }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            UpdateSelectButtonState();
        }

        private void UpdateCharacterDisplay(string type)
        {
            // Create a temporary character to get stats
            ClassFighter tempCharacter = CreateTempCharacter(type);
            
            // Update character image
            characterImage.Image = LoadCharacterImage(type);

            // Update character stats
            characterStatsBox.Text = $"Health: {tempCharacter.MaxHealth}\r\n" +
                                $"Base Damage: {GetBaseDamage(type)}\r\n" +
                                $"Special: {GetSpecialAbility(type)}";

            // Update character description
            characterDescriptionBox.Text = GetCharacterDescription(type);
        }

        private Image LoadCharacterImage(string type)
        {
            string imagePath = Path.Combine("Images", $"{type.ToLower()}.png");
            
            if (File.Exists(imagePath))
            {
                try
                {
                    return Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Image Error", 
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Fallback to generated image if file not found or error occurs
            return GenerateDefaultImage(type);
        }

        private Image GenerateDefaultImage(string type)
        {
            // Create a simple colored rectangle as placeholder
            Bitmap bmp = new Bitmap(200, 200);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                Color color = type switch
                {
                    "CodeCrusher" => Color.Red,
                    "QuizMaster" => Color.Blue,
                    "Debugger" => Color.Green,
                    _ => Color.Gray
                };

                g.FillRectangle(new SolidBrush(color), 0, 0, 200, 200);
                
                // Add some basic shapes to differentiate characters
                switch (type)
                {
                    case "CodeCrusher":
                        g.FillEllipse(Brushes.White, 50, 50, 100, 100);
                        break;
                    case "QuizMaster":
                        g.DrawRectangle(Pens.White, 50, 50, 100, 100);
                        break;
                    case "Debugger":
                        g.DrawPolygon(Pens.White, new Point[] {
                            new Point(100, 50),
                            new Point(150, 150),
                            new Point(50, 150)
                        });
                        break;
                }
            }
            return bmp;
        }

        private ClassFighter CreateTempCharacter(string type)
        {
            return type switch
            {
                "CodeCrusher" => new CodeCrusher("Temp"),
                "QuizMaster" => new QuizMaster("Temp"),
                "Debugger" => new Debugger("Temp"),
                _ => throw new ArgumentException($"Unknown fighter type: {type}")
            };
        }

        private int GetBaseDamage(string type)
        {
            return type switch
            {
                "CodeCrusher" => 15,
                "QuizMaster" => 20,
                "Debugger" => 12,
                _ => 0
            };
        }

        private string GetSpecialAbility(string type)
        {
            return type switch
            {
                "CodeCrusher" => "20% chance for critical hits (2x damage)",
                "QuizMaster" => "15% chance for perfect answer (3x damage), 30% chance to miss",
                "Debugger" => "25% chance to analyze and reflect (2x damage + 5 bonus)",
                _ => "None"
            };
        }

        private string GetCharacterDescription(string type)
        {
            return type switch
            {
                "CodeCrusher" => "A powerful character that excels at dealing consistent damage. " +
                               "Their coding expertise allows them to occasionally land critical hits " +
                               "that deal massive damage to their opponents.",
                "QuizMaster" => "A high-risk, high-reward character that can either miss completely " +
                              "or land perfect answers for devastating damage. Their knowledge of " +
                              "quizzes and tests makes them unpredictable in battle.",
                "Debugger" => "A fit, professional programmer who always gets 8 hours of sleep and can still " +
                              "create the most powerful software that makes its foes bow before him. Once he makes " +
                              "his signature stance, expect that you will be hypnotized and bow afterward.",
                _ => "Unknown character type"
            };
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            if (characterType.SelectedItem != null && !string.IsNullOrWhiteSpace(nameInput.Text))
            {
                SelectedType = characterType.SelectedItem.ToString();
                SelectedName = nameInput.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
} 