namespace AssaultCubeGameHack
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
            this.components = new System.ComponentModel.Container();
            this.TitleLBL = new System.Windows.Forms.Label();
            this.HealthBT = new System.Windows.Forms.Button();
            this.AmmoBT = new System.Windows.Forms.Button();
            this.ExitBT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PlayerDataBox = new System.Windows.Forms.GroupBox();
            this.BulletProofLBL = new System.Windows.Forms.Label();
            this.AngleLBL = new System.Windows.Forms.Label();
            this.PositionLBL = new System.Windows.Forms.Label();
            this.AmmoLBL = new System.Windows.Forms.Label();
            this.HealthLBL = new System.Windows.Forms.Label();
            this.SelectProcessLBL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HealthHLBL = new System.Windows.Forms.Label();
            this.AmmoHLBL = new System.Windows.Forms.Label();
            this.PlayerDataBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("맑은 고딕", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.TitleLBL.Location = new System.Drawing.Point(50, 30);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(714, 81);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "AssaultCube GameHack";
            // 
            // HealthBT
            // 
            this.HealthBT.Location = new System.Drawing.Point(64, 237);
            this.HealthBT.Name = "HealthBT";
            this.HealthBT.Size = new System.Drawing.Size(129, 29);
            this.HealthBT.TabIndex = 1;
            this.HealthBT.Text = "Health Hack";
            this.HealthBT.UseVisualStyleBackColor = true;
            this.HealthBT.Click += new System.EventHandler(this.HealthBT_Click);
            // 
            // AmmoBT
            // 
            this.AmmoBT.Location = new System.Drawing.Point(64, 276);
            this.AmmoBT.Name = "AmmoBT";
            this.AmmoBT.Size = new System.Drawing.Size(129, 29);
            this.AmmoBT.TabIndex = 2;
            this.AmmoBT.Text = "Ammo Hack";
            this.AmmoBT.UseVisualStyleBackColor = true;
            this.AmmoBT.Click += new System.EventHandler(this.AmmoBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.Location = new System.Drawing.Point(672, 363);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(94, 29);
            this.ExitBT.TabIndex = 3;
            this.ExitBT.Text = "닫기";
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // PlayerDataBox
            // 
            this.PlayerDataBox.Controls.Add(this.BulletProofLBL);
            this.PlayerDataBox.Controls.Add(this.AngleLBL);
            this.PlayerDataBox.Controls.Add(this.PositionLBL);
            this.PlayerDataBox.Controls.Add(this.AmmoLBL);
            this.PlayerDataBox.Controls.Add(this.HealthLBL);
            this.PlayerDataBox.Location = new System.Drawing.Point(440, 142);
            this.PlayerDataBox.Name = "PlayerDataBox";
            this.PlayerDataBox.Size = new System.Drawing.Size(324, 183);
            this.PlayerDataBox.TabIndex = 5;
            this.PlayerDataBox.TabStop = false;
            this.PlayerDataBox.Text = "Player Data";
            this.PlayerDataBox.Enter += new System.EventHandler(this.PlayerDataBox_Enter);
            // 
            // BulletProofLBL
            // 
            this.BulletProofLBL.AutoSize = true;
            this.BulletProofLBL.Location = new System.Drawing.Point(12, 134);
            this.BulletProofLBL.Name = "BulletProofLBL";
            this.BulletProofLBL.Size = new System.Drawing.Size(88, 20);
            this.BulletProofLBL.TabIndex = 4;
            this.BulletProofLBL.Text = "BulletProof:";
            // 
            // AngleLBL
            // 
            this.AngleLBL.AutoSize = true;
            this.AngleLBL.Location = new System.Drawing.Point(156, 86);
            this.AngleLBL.Name = "AngleLBL";
            this.AngleLBL.Size = new System.Drawing.Size(52, 20);
            this.AngleLBL.TabIndex = 3;
            this.AngleLBL.Text = "Angle:";
            this.AngleLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // PositionLBL
            // 
            this.PositionLBL.AutoSize = true;
            this.PositionLBL.Location = new System.Drawing.Point(156, 36);
            this.PositionLBL.Name = "PositionLBL";
            this.PositionLBL.Size = new System.Drawing.Size(67, 20);
            this.PositionLBL.TabIndex = 2;
            this.PositionLBL.Text = "Position:";
            // 
            // AmmoLBL
            // 
            this.AmmoLBL.AutoSize = true;
            this.AmmoLBL.Location = new System.Drawing.Point(12, 86);
            this.AmmoLBL.Name = "AmmoLBL";
            this.AmmoLBL.Size = new System.Drawing.Size(57, 20);
            this.AmmoLBL.TabIndex = 1;
            this.AmmoLBL.Text = "Ammo:";
            // 
            // HealthLBL
            // 
            this.HealthLBL.AutoSize = true;
            this.HealthLBL.Location = new System.Drawing.Point(12, 36);
            this.HealthLBL.Name = "HealthLBL";
            this.HealthLBL.Size = new System.Drawing.Size(57, 20);
            this.HealthLBL.TabIndex = 0;
            this.HealthLBL.Text = "Health:";
            // 
            // SelectProcessLBL
            // 
            this.SelectProcessLBL.AutoSize = true;
            this.SelectProcessLBL.Location = new System.Drawing.Point(64, 152);
            this.SelectProcessLBL.Name = "SelectProcessLBL";
            this.SelectProcessLBL.Size = new System.Drawing.Size(182, 20);
            this.SelectProcessLBL.TabIndex = 6;
            this.SelectProcessLBL.Text = "프로세스를 선택해주세요.";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HealthHLBL
            // 
            this.HealthHLBL.AutoSize = true;
            this.HealthHLBL.Location = new System.Drawing.Point(283, 241);
            this.HealthHLBL.Name = "HealthHLBL";
            this.HealthHLBL.Size = new System.Drawing.Size(69, 20);
            this.HealthHLBL.TabIndex = 7;
            this.HealthHLBL.Text = "동작안함";
            // 
            // AmmoHLBL
            // 
            this.AmmoHLBL.AutoSize = true;
            this.AmmoHLBL.Location = new System.Drawing.Point(283, 280);
            this.AmmoHLBL.Name = "AmmoHLBL";
            this.AmmoHLBL.Size = new System.Drawing.Size(69, 20);
            this.AmmoHLBL.TabIndex = 8;
            this.AmmoHLBL.Text = "동작안함";
            this.AmmoHLBL.Click += new System.EventHandler(this.AmmoBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AmmoHLBL);
            this.Controls.Add(this.HealthHLBL);
            this.Controls.Add(this.SelectProcessLBL);
            this.Controls.Add(this.PlayerDataBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.AmmoBT);
            this.Controls.Add(this.HealthBT);
            this.Controls.Add(this.TitleLBL);
            this.Name = "Form1";
            this.Text = "AssaultCube GameHack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PlayerDataBox.ResumeLayout(false);
            this.PlayerDataBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLBL;
        private Button HealthBT;
        private Button AmmoBT;
        private Button ExitBT;
        private ComboBox comboBox1;
        private GroupBox PlayerDataBox;
        private Label HealthLBL;
        private Label PositionLBL;
        private Label AmmoLBL;
        private Label AngleLBL;
        private Label BulletProofLBL;
        private Label SelectProcessLBL;
        private System.Windows.Forms.Timer timer1;
        private Label HealthHLBL;
        private Label AmmoHLBL;
    }
}