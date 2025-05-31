namespace ClassmatesRpgBattleSim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartBattle = new Button();
            txtBattleLog = new TextBox();
            lblTurnInfo = new Label();
            btnResetBattle = new Button();
            btnSurrender = new Button();
            lblTimer = new Label();
            grpPlayer1 = new GroupBox();
            picPlayer1 = new PictureBox();
            lblPlayer1Name = new Label();
            lblPlayer1Type = new Label();
            lblPlayer1HealthStat = new Label();
            lblPlayer1Attack = new Label();
            grpPlayer2 = new GroupBox();
            picPlayer2 = new PictureBox();
            lblPlayer2Name = new Label();
            lblPlayer2Type = new Label();
            lblPlayer2HealthStat = new Label();
            lblPlayer2Attack = new Label();
            grpPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer1).BeginInit();
            grpPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer2).BeginInit();
            SuspendLayout();
            // 
            // btnStartBattle
            // 
            btnStartBattle.BackColor = Color.Gold;
            btnStartBattle.ForeColor = Color.Black;
            btnStartBattle.Location = new Point(399, 109);
            btnStartBattle.Margin = new Padding(4, 3, 4, 3);
            btnStartBattle.Name = "btnStartBattle";
            btnStartBattle.Size = new Size(117, 27);
            btnStartBattle.TabIndex = 0;
            btnStartBattle.Text = "Start Battle";
            btnStartBattle.UseVisualStyleBackColor = false;
            btnStartBattle.Click += BtnStartBattle_Click;
            // 
            // txtBattleLog
            // 
            txtBattleLog.BackColor = Color.FromArgb(44, 62, 80);
            txtBattleLog.Font = new Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBattleLog.ForeColor = Color.White;
            txtBattleLog.Location = new Point(23, 196);
            txtBattleLog.Margin = new Padding(4, 3, 4, 3);
            txtBattleLog.Multiline = true;
            txtBattleLog.Name = "txtBattleLog";
            txtBattleLog.ReadOnly = true;
            txtBattleLog.ScrollBars = ScrollBars.Vertical;
            txtBattleLog.Size = new Size(884, 461);
            txtBattleLog.TabIndex = 1;
            // 
            // lblTurnInfo
            // 
            lblTurnInfo.AutoSize = true;
            lblTurnInfo.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold);
            lblTurnInfo.Location = new Point(23, 31);
            lblTurnInfo.Margin = new Padding(4, 0, 4, 0);
            lblTurnInfo.Name = "lblTurnInfo";
            lblTurnInfo.Size = new Size(107, 21);
            lblTurnInfo.TabIndex = 2;
            lblTurnInfo.Text = "Battle Status";
            // 
            // btnResetBattle
            // 
            btnResetBattle.BackColor = Color.LightSkyBlue;
            btnResetBattle.Enabled = false;
            btnResetBattle.ForeColor = Color.Black;
            btnResetBattle.Location = new Point(260, 20);
            btnResetBattle.Name = "btnResetBattle";
            btnResetBattle.Size = new Size(100, 23);
            btnResetBattle.TabIndex = 3;
            btnResetBattle.Text = "Reset Battle";
            btnResetBattle.UseVisualStyleBackColor = false;
            btnResetBattle.Click += BtnResetBattle_Click;
            // 
            // btnSurrender
            // 
            btnSurrender.BackColor = Color.IndianRed;
            btnSurrender.Enabled = false;
            btnSurrender.ForeColor = Color.White;
            btnSurrender.Location = new Point(380, 20);
            btnSurrender.Name = "btnSurrender";
            btnSurrender.Size = new Size(100, 23);
            btnSurrender.TabIndex = 4;
            btnSurrender.Text = "Surrender";
            btnSurrender.UseVisualStyleBackColor = false;
            btnSurrender.Click += BtnSurrender_Click;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            lblTimer.Location = new Point(653, 31);
            lblTimer.Margin = new Padding(4, 0, 4, 0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(55, 19);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "Timer:";
            // 
            // grpPlayer1
            // 
            grpPlayer1.BackColor = Color.FromArgb(245, 245, 220);
            grpPlayer1.Controls.Add(picPlayer1);
            grpPlayer1.Controls.Add(lblPlayer1Name);
            grpPlayer1.Controls.Add(lblPlayer1Type);
            grpPlayer1.Controls.Add(lblPlayer1HealthStat);
            grpPlayer1.Controls.Add(lblPlayer1Attack);
            grpPlayer1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            grpPlayer1.Location = new Point(23, 69);
            grpPlayer1.Margin = new Padding(4, 3, 4, 3);
            grpPlayer1.Name = "grpPlayer1";
            grpPlayer1.Padding = new Padding(4, 3, 4, 3);
            grpPlayer1.Size = new Size(233, 104);
            grpPlayer1.TabIndex = 8;
            grpPlayer1.TabStop = false;
            grpPlayer1.Text = "Player 1";
            // 
            // picPlayer1
            // 
            picPlayer1.Location = new Point(7, 22);
            picPlayer1.Margin = new Padding(4, 3, 4, 3);
            picPlayer1.Name = "picPlayer1";
            picPlayer1.Size = new Size(75, 74);
            picPlayer1.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer1.TabIndex = 0;
            picPlayer1.TabStop = false;
            // 
            // lblPlayer1Name
            // 
            lblPlayer1Name.AutoSize = true;
            lblPlayer1Name.Font = new Font("Comic Sans MS", 9F);
            lblPlayer1Name.Location = new Point(89, 22);
            lblPlayer1Name.Margin = new Padding(4, 0, 4, 0);
            lblPlayer1Name.Name = "lblPlayer1Name";
            lblPlayer1Name.Size = new Size(42, 17);
            lblPlayer1Name.TabIndex = 1;
            lblPlayer1Name.Text = "Name:";
            // 
            // lblPlayer1Type
            // 
            lblPlayer1Type.AutoSize = true;
            lblPlayer1Type.Font = new Font("Comic Sans MS", 9F);
            lblPlayer1Type.Location = new Point(89, 40);
            lblPlayer1Type.Margin = new Padding(4, 0, 4, 0);
            lblPlayer1Type.Name = "lblPlayer1Type";
            lblPlayer1Type.Size = new Size(38, 17);
            lblPlayer1Type.TabIndex = 2;
            lblPlayer1Type.Text = "Type:";
            // 
            // lblPlayer1HealthStat
            // 
            lblPlayer1HealthStat.AutoSize = true;
            lblPlayer1HealthStat.Font = new Font("Comic Sans MS", 9F);
            lblPlayer1HealthStat.Location = new Point(89, 59);
            lblPlayer1HealthStat.Margin = new Padding(4, 0, 4, 0);
            lblPlayer1HealthStat.Name = "lblPlayer1HealthStat";
            lblPlayer1HealthStat.Size = new Size(49, 17);
            lblPlayer1HealthStat.TabIndex = 3;
            lblPlayer1HealthStat.Text = "Health:";
            // 
            // lblPlayer1Attack
            // 
            lblPlayer1Attack.AutoSize = true;
            lblPlayer1Attack.Font = new Font("Comic Sans MS", 9F);
            lblPlayer1Attack.Location = new Point(89, 77);
            lblPlayer1Attack.Margin = new Padding(4, 0, 4, 0);
            lblPlayer1Attack.Name = "lblPlayer1Attack";
            lblPlayer1Attack.Size = new Size(50, 17);
            lblPlayer1Attack.TabIndex = 4;
            lblPlayer1Attack.Text = "Attack:";
            // 
            // grpPlayer2
            // 
            grpPlayer2.BackColor = Color.FromArgb(245, 245, 220);
            grpPlayer2.Controls.Add(picPlayer2);
            grpPlayer2.Controls.Add(lblPlayer2Name);
            grpPlayer2.Controls.Add(lblPlayer2Type);
            grpPlayer2.Controls.Add(lblPlayer2HealthStat);
            grpPlayer2.Controls.Add(lblPlayer2Attack);
            grpPlayer2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            grpPlayer2.Location = new Point(674, 69);
            grpPlayer2.Margin = new Padding(4, 3, 4, 3);
            grpPlayer2.Name = "grpPlayer2";
            grpPlayer2.Padding = new Padding(4, 3, 4, 3);
            grpPlayer2.Size = new Size(233, 104);
            grpPlayer2.TabIndex = 9;
            grpPlayer2.TabStop = false;
            grpPlayer2.Text = "Player 2";
            // 
            // picPlayer2
            // 
            picPlayer2.Location = new Point(7, 22);
            picPlayer2.Margin = new Padding(4, 3, 4, 3);
            picPlayer2.Name = "picPlayer2";
            picPlayer2.Size = new Size(75, 74);
            picPlayer2.SizeMode = PictureBoxSizeMode.Zoom;
            picPlayer2.TabIndex = 0;
            picPlayer2.TabStop = false;
            // 
            // lblPlayer2Name
            // 
            lblPlayer2Name.AutoSize = true;
            lblPlayer2Name.Font = new Font("Comic Sans MS", 9F);
            lblPlayer2Name.Location = new Point(89, 22);
            lblPlayer2Name.Margin = new Padding(4, 0, 4, 0);
            lblPlayer2Name.Name = "lblPlayer2Name";
            lblPlayer2Name.Size = new Size(42, 17);
            lblPlayer2Name.TabIndex = 1;
            lblPlayer2Name.Text = "Name:";
            // 
            // lblPlayer2Type
            // 
            lblPlayer2Type.AutoSize = true;
            lblPlayer2Type.Font = new Font("Comic Sans MS", 9F);
            lblPlayer2Type.Location = new Point(89, 40);
            lblPlayer2Type.Margin = new Padding(4, 0, 4, 0);
            lblPlayer2Type.Name = "lblPlayer2Type";
            lblPlayer2Type.Size = new Size(38, 17);
            lblPlayer2Type.TabIndex = 2;
            lblPlayer2Type.Text = "Type:";
            // 
            // lblPlayer2HealthStat
            // 
            lblPlayer2HealthStat.AutoSize = true;
            lblPlayer2HealthStat.Font = new Font("Comic Sans MS", 9F);
            lblPlayer2HealthStat.Location = new Point(89, 59);
            lblPlayer2HealthStat.Margin = new Padding(4, 0, 4, 0);
            lblPlayer2HealthStat.Name = "lblPlayer2HealthStat";
            lblPlayer2HealthStat.Size = new Size(49, 17);
            lblPlayer2HealthStat.TabIndex = 3;
            lblPlayer2HealthStat.Text = "Health:";
            // 
            // lblPlayer2Attack
            // 
            lblPlayer2Attack.AutoSize = true;
            lblPlayer2Attack.Font = new Font("Comic Sans MS", 9F);
            lblPlayer2Attack.Location = new Point(89, 77);
            lblPlayer2Attack.Margin = new Padding(4, 0, 4, 0);
            lblPlayer2Attack.Name = "lblPlayer2Attack";
            lblPlayer2Attack.Size = new Size(50, 17);
            lblPlayer2Attack.TabIndex = 4;
            lblPlayer2Attack.Text = "Attack:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Images", "bg.jpg"));
            BackgroundImageLayout = ImageLayout.Stretch;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(933, 692);
            Controls.Add(grpPlayer2);
            Controls.Add(grpPlayer1);
            Controls.Add(lblTimer);
            Controls.Add(lblTurnInfo);
            Controls.Add(txtBattleLog);
            Controls.Add(btnStartBattle);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Classmates RPG Battle Simulator";
            grpPlayer1.ResumeLayout(false);
            grpPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer1).EndInit();
            grpPlayer2.ResumeLayout(false);
            grpPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayer2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.TextBox txtBattleLog;
        private System.Windows.Forms.Label lblTurnInfo;
        private System.Windows.Forms.Button btnResetBattle;
        private System.Windows.Forms.Button btnSurrender;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1Type;
        private System.Windows.Forms.Label lblPlayer1HealthStat;
        private System.Windows.Forms.Label lblPlayer1Attack;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer2Type;
        private System.Windows.Forms.Label lblPlayer2HealthStat;
        private System.Windows.Forms.Label lblPlayer2Attack;
        private System.Windows.Forms.PictureBox picPlayer2;
    }
}
