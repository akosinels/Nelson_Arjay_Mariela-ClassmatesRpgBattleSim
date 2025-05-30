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
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.txtBattleLog = new System.Windows.Forms.TextBox();
            this.lblTurnInfo = new System.Windows.Forms.Label();
            this.btnResetBattle = new System.Windows.Forms.Button();
            this.btnSurrender = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer1Type = new System.Windows.Forms.Label();
            this.lblPlayer1HealthStat = new System.Windows.Forms.Label();
            this.lblPlayer1Attack = new System.Windows.Forms.Label();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer2Type = new System.Windows.Forms.Label();
            this.lblPlayer2HealthStat = new System.Windows.Forms.Label();
            this.lblPlayer2Attack = new System.Windows.Forms.Label();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.Location = new System.Drawing.Point(20, 20);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(100, 23);
            this.btnStartBattle.TabIndex = 0;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.UseVisualStyleBackColor = true;
            this.btnStartBattle.Click += new System.EventHandler(this.BtnStartBattle_Click);
            // 
            // txtBattleLog
            // 
            this.txtBattleLog.Location = new System.Drawing.Point(20, 170);
            this.txtBattleLog.Multiline = true;
            this.txtBattleLog.Name = "txtBattleLog";
            this.txtBattleLog.ReadOnly = true;
            this.txtBattleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBattleLog.Size = new System.Drawing.Size(740, 400);
            this.txtBattleLog.TabIndex = 1;
            // 
            // lblTurnInfo
            // 
            this.lblTurnInfo.AutoSize = true;
            this.lblTurnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnInfo.Location = new System.Drawing.Point(140, 23);
            this.lblTurnInfo.Name = "lblTurnInfo";
            this.lblTurnInfo.Size = new System.Drawing.Size(100, 16);
            this.lblTurnInfo.TabIndex = 2;
            this.lblTurnInfo.Text = "Battle Status";
            // 
            // btnResetBattle
            // 
            this.btnResetBattle.Enabled = false;
            this.btnResetBattle.Location = new System.Drawing.Point(260, 20);
            this.btnResetBattle.Name = "btnResetBattle";
            this.btnResetBattle.Size = new System.Drawing.Size(100, 23);
            this.btnResetBattle.TabIndex = 3;
            this.btnResetBattle.Text = "Reset Battle";
            this.btnResetBattle.UseVisualStyleBackColor = true;
            this.btnResetBattle.Click += new System.EventHandler(this.BtnResetBattle_Click);
            // 
            // btnSurrender
            // 
            this.btnSurrender.Enabled = false;
            this.btnSurrender.Location = new System.Drawing.Point(380, 20);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(100, 23);
            this.btnSurrender.TabIndex = 4;
            this.btnSurrender.Text = "Surrender";
            this.btnSurrender.UseVisualStyleBackColor = true;
            this.btnSurrender.Click += new System.EventHandler(this.BtnSurrender_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(500, 23);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(49, 16);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "Timer:";
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.Controls.Add(this.picPlayer1);
            this.grpPlayer1.Controls.Add(this.lblPlayer1Name);
            this.grpPlayer1.Controls.Add(this.lblPlayer1Type);
            this.grpPlayer1.Controls.Add(this.lblPlayer1HealthStat);
            this.grpPlayer1.Controls.Add(this.lblPlayer1Attack);
            this.grpPlayer1.Location = new System.Drawing.Point(20, 60);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(200, 90);
            this.grpPlayer1.TabIndex = 8;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "Player 1";
            // 
            // picPlayer1
            // 
            this.picPlayer1.Location = new System.Drawing.Point(6, 19);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(64, 64);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer1.TabIndex = 0;
            this.picPlayer1.TabStop = false;
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.Location = new System.Drawing.Point(76, 19);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(38, 13);
            this.lblPlayer1Name.TabIndex = 1;
            this.lblPlayer1Name.Text = "Name:";
            // 
            // lblPlayer1Type
            // 
            this.lblPlayer1Type.AutoSize = true;
            this.lblPlayer1Type.Location = new System.Drawing.Point(76, 35);
            this.lblPlayer1Type.Name = "lblPlayer1Type";
            this.lblPlayer1Type.Size = new System.Drawing.Size(34, 13);
            this.lblPlayer1Type.TabIndex = 2;
            this.lblPlayer1Type.Text = "Type:";
            // 
            // lblPlayer1HealthStat
            // 
            this.lblPlayer1HealthStat.AutoSize = true;
            this.lblPlayer1HealthStat.Location = new System.Drawing.Point(76, 51);
            this.lblPlayer1HealthStat.Name = "lblPlayer1HealthStat";
            this.lblPlayer1HealthStat.Size = new System.Drawing.Size(41, 13);
            this.lblPlayer1HealthStat.TabIndex = 3;
            this.lblPlayer1HealthStat.Text = "Health:";
            // 
            // lblPlayer1Attack
            // 
            this.lblPlayer1Attack.AutoSize = true;
            this.lblPlayer1Attack.Location = new System.Drawing.Point(76, 67);
            this.lblPlayer1Attack.Name = "lblPlayer1Attack";
            this.lblPlayer1Attack.Size = new System.Drawing.Size(41, 13);
            this.lblPlayer1Attack.TabIndex = 4;
            this.lblPlayer1Attack.Text = "Attack:";
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.picPlayer2);
            this.grpPlayer2.Controls.Add(this.lblPlayer2Name);
            this.grpPlayer2.Controls.Add(this.lblPlayer2Type);
            this.grpPlayer2.Controls.Add(this.lblPlayer2HealthStat);
            this.grpPlayer2.Controls.Add(this.lblPlayer2Attack);
            this.grpPlayer2.Location = new System.Drawing.Point(560, 60);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(200, 90);
            this.grpPlayer2.TabIndex = 9;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player 2";
            // 
            // picPlayer2
            // 
            this.picPlayer2.Location = new System.Drawing.Point(6, 19);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(64, 64);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 0;
            this.picPlayer2.TabStop = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.Location = new System.Drawing.Point(76, 19);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(38, 13);
            this.lblPlayer2Name.TabIndex = 1;
            this.lblPlayer2Name.Text = "Name:";
            // 
            // lblPlayer2Type
            // 
            this.lblPlayer2Type.AutoSize = true;
            this.lblPlayer2Type.Location = new System.Drawing.Point(76, 35);
            this.lblPlayer2Type.Name = "lblPlayer2Type";
            this.lblPlayer2Type.Size = new System.Drawing.Size(34, 13);
            this.lblPlayer2Type.TabIndex = 2;
            this.lblPlayer2Type.Text = "Type:";
            // 
            // lblPlayer2HealthStat
            // 
            this.lblPlayer2HealthStat.AutoSize = true;
            this.lblPlayer2HealthStat.Location = new System.Drawing.Point(76, 51);
            this.lblPlayer2HealthStat.Name = "lblPlayer2HealthStat";
            this.lblPlayer2HealthStat.Size = new System.Drawing.Size(41, 13);
            this.lblPlayer2HealthStat.TabIndex = 3;
            this.lblPlayer2HealthStat.Text = "Health:";
            // 
            // lblPlayer2Attack
            // 
            this.lblPlayer2Attack.AutoSize = true;
            this.lblPlayer2Attack.Location = new System.Drawing.Point(76, 67);
            this.lblPlayer2Attack.Name = "lblPlayer2Attack";
            this.lblPlayer2Attack.Size = new System.Drawing.Size(41, 13);
            this.lblPlayer2Attack.TabIndex = 4;
            this.lblPlayer2Attack.Text = "Attack:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblTurnInfo);
            this.Controls.Add(this.txtBattleLog);
            this.Controls.Add(this.btnStartBattle);
            this.Name = "Form1";
            this.Text = "Classmates RPG Battle Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();

            // Theming: Form background
            this.BackColor = System.Drawing.Color.FromArgb(200, 255, 200); // Light green

            // Theming: Battle log (chalkboard look)
            this.txtBattleLog.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.txtBattleLog.ForeColor = System.Drawing.Color.White;
            this.txtBattleLog.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Theming: Group boxes (notebook paper look)
            this.grpPlayer1.BackColor = System.Drawing.Color.FromArgb(245, 245, 220); // Light beige
            this.grpPlayer2.BackColor = System.Drawing.Color.FromArgb(245, 245, 220);
            this.grpPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);

            // Theming: Labels (handwriting style)
            this.lblPlayer1Name.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblPlayer1Type.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblPlayer1HealthStat.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblPlayer1Attack.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblPlayer2Name.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblPlayer2Type.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblPlayer2HealthStat.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblPlayer2Attack.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.lblTurnInfo.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);

            // Theming: Buttons
            this.btnStartBattle.BackColor = System.Drawing.Color.Gold;
            this.btnStartBattle.ForeColor = System.Drawing.Color.Black;
            this.btnResetBattle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnResetBattle.ForeColor = System.Drawing.Color.Black;
            this.btnSurrender.BackColor = System.Drawing.Color.IndianRed;
            this.btnSurrender.ForeColor = System.Drawing.Color.White;
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
