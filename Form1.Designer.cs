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
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.cmbPlayer1Type = new System.Windows.Forms.ComboBox();
            this.lblPlayer1Health = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.cmbPlayer2Type = new System.Windows.Forms.ComboBox();
            this.lblPlayer2Health = new System.Windows.Forms.Label();
            this.btnStartBattle = new System.Windows.Forms.Button();
            this.txtBattleLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(20, 20);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1:";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Location = new System.Drawing.Point(100, 20);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(150, 20);
            this.txtPlayer1Name.TabIndex = 1;
            // 
            // cmbPlayer1Type
            // 
            this.cmbPlayer1Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer1Type.FormattingEnabled = true;
            this.cmbPlayer1Type.Items.AddRange(new object[] {
            "CodeCrusher",
            "QuizMaster"});
            this.cmbPlayer1Type.Location = new System.Drawing.Point(270, 20);
            this.cmbPlayer1Type.Name = "cmbPlayer1Type";
            this.cmbPlayer1Type.Size = new System.Drawing.Size(150, 21);
            this.cmbPlayer1Type.TabIndex = 2;
            // 
            // lblPlayer1Health
            // 
            this.lblPlayer1Health.AutoSize = true;
            this.lblPlayer1Health.Location = new System.Drawing.Point(440, 20);
            this.lblPlayer1Health.Name = "lblPlayer1Health";
            this.lblPlayer1Health.Size = new System.Drawing.Size(47, 13);
            this.lblPlayer1Health.TabIndex = 3;
            this.lblPlayer1Health.Text = "Health: 100";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(20, 60);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(48, 13);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Player 2:";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Location = new System.Drawing.Point(100, 60);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(150, 20);
            this.txtPlayer2Name.TabIndex = 5;
            // 
            // cmbPlayer2Type
            // 
            this.cmbPlayer2Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayer2Type.FormattingEnabled = true;
            this.cmbPlayer2Type.Items.AddRange(new object[] {
            "CodeCrusher",
            "QuizMaster"});
            this.cmbPlayer2Type.Location = new System.Drawing.Point(270, 60);
            this.cmbPlayer2Type.Name = "cmbPlayer2Type";
            this.cmbPlayer2Type.Size = new System.Drawing.Size(150, 21);
            this.cmbPlayer2Type.TabIndex = 6;
            // 
            // lblPlayer2Health
            // 
            this.lblPlayer2Health.AutoSize = true;
            this.lblPlayer2Health.Location = new System.Drawing.Point(440, 60);
            this.lblPlayer2Health.Name = "lblPlayer2Health";
            this.lblPlayer2Health.Size = new System.Drawing.Size(47, 13);
            this.lblPlayer2Health.TabIndex = 7;
            this.lblPlayer2Health.Text = "Health: 100";
            // 
            // btnStartBattle
            // 
            this.btnStartBattle.Location = new System.Drawing.Point(20, 100);
            this.btnStartBattle.Name = "btnStartBattle";
            this.btnStartBattle.Size = new System.Drawing.Size(100, 23);
            this.btnStartBattle.TabIndex = 8;
            this.btnStartBattle.Text = "Start Battle";
            this.btnStartBattle.UseVisualStyleBackColor = true;
            this.btnStartBattle.Click += new System.EventHandler(this.BtnStartBattle_Click);
            // 
            // txtBattleLog
            // 
            this.txtBattleLog.Location = new System.Drawing.Point(20, 140);
            this.txtBattleLog.Multiline = true;
            this.txtBattleLog.Name = "txtBattleLog";
            this.txtBattleLog.ReadOnly = true;
            this.txtBattleLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBattleLog.Size = new System.Drawing.Size(740, 400);
            this.txtBattleLog.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.txtBattleLog);
            this.Controls.Add(this.btnStartBattle);
            this.Controls.Add(this.lblPlayer2Health);
            this.Controls.Add(this.cmbPlayer2Type);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1Health);
            this.Controls.Add(this.cmbPlayer1Type);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblPlayer1);
            this.Name = "Form1";
            this.Text = "Classmates RPG Battle Simulator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.ComboBox cmbPlayer1Type;
        private System.Windows.Forms.Label lblPlayer1Health;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.ComboBox cmbPlayer2Type;
        private System.Windows.Forms.Label lblPlayer2Health;
        private System.Windows.Forms.Button btnStartBattle;
        private System.Windows.Forms.TextBox txtBattleLog;
    }
}
