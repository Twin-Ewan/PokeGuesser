namespace Pokemon_Guesser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.OutputBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GenGroup = new System.Windows.Forms.GroupBox();
            this.SettingsSave = new System.Windows.Forms.Button();
            this.GenAll = new System.Windows.Forms.CheckBox();
            this.Gen1 = new System.Windows.Forms.CheckBox();
            this.Gen2 = new System.Windows.Forms.CheckBox();
            this.Gen4 = new System.Windows.Forms.CheckBox();
            this.Gen5 = new System.Windows.Forms.CheckBox();
            this.Gen3 = new System.Windows.Forms.CheckBox();
            this.Gen7 = new System.Windows.Forms.CheckBox();
            this.Gen8 = new System.Windows.Forms.CheckBox();
            this.Gen6 = new System.Windows.Forms.CheckBox();
            this.Gen9 = new System.Windows.Forms.CheckBox();
            this.PokeDisplay = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.PunishAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.GenGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pokémon Guesser";
            // 
            // InputBox
            // 
            this.InputBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.InputBox.Location = new System.Drawing.Point(19, 219);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(413, 22);
            this.InputBox.TabIndex = 14;
            this.InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // OutputBox
            // 
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.FormattingEnabled = true;
            this.OutputBox.ItemHeight = 15;
            this.OutputBox.Location = new System.Drawing.Point(18, 247);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(414, 229);
            this.OutputBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Input Your Guess Here!";
            // 
            // GenGroup
            // 
            this.GenGroup.Controls.Add(this.SettingsSave);
            this.GenGroup.Controls.Add(this.GenAll);
            this.GenGroup.Controls.Add(this.Gen1);
            this.GenGroup.Controls.Add(this.Gen2);
            this.GenGroup.Controls.Add(this.Gen4);
            this.GenGroup.Controls.Add(this.Gen5);
            this.GenGroup.Controls.Add(this.Gen3);
            this.GenGroup.Controls.Add(this.Gen7);
            this.GenGroup.Controls.Add(this.Gen8);
            this.GenGroup.Controls.Add(this.Gen6);
            this.GenGroup.Controls.Add(this.Gen9);
            this.GenGroup.Location = new System.Drawing.Point(18, 44);
            this.GenGroup.Name = "GenGroup";
            this.GenGroup.Size = new System.Drawing.Size(255, 137);
            this.GenGroup.TabIndex = 0;
            this.GenGroup.TabStop = false;
            this.GenGroup.Text = "Pokémon";
            // 
            // SettingsSave
            // 
            this.SettingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsSave.Location = new System.Drawing.Point(139, 100);
            this.SettingsSave.Name = "SettingsSave";
            this.SettingsSave.Size = new System.Drawing.Size(97, 28);
            this.SettingsSave.TabIndex = 11;
            this.SettingsSave.Text = "Save";
            this.SettingsSave.UseVisualStyleBackColor = true;
            this.SettingsSave.Click += new System.EventHandler(this.SettingsSave_Click);
            // 
            // GenAll
            // 
            this.GenAll.AutoSize = true;
            this.GenAll.Location = new System.Drawing.Point(6, 108);
            this.GenAll.Name = "GenAll";
            this.GenAll.Size = new System.Drawing.Size(101, 20);
            this.GenAll.TabIndex = 10;
            this.GenAll.Text = "All of Above";
            this.GenAll.UseVisualStyleBackColor = true;
            // 
            // Gen1
            // 
            this.Gen1.AutoSize = true;
            this.Gen1.Location = new System.Drawing.Point(6, 22);
            this.Gen1.Name = "Gen1";
            this.Gen1.Size = new System.Drawing.Size(64, 20);
            this.Gen1.TabIndex = 1;
            this.Gen1.Text = "Gen 1";
            this.Gen1.UseVisualStyleBackColor = true;
            // 
            // Gen2
            // 
            this.Gen2.AutoSize = true;
            this.Gen2.Location = new System.Drawing.Point(83, 22);
            this.Gen2.Name = "Gen2";
            this.Gen2.Size = new System.Drawing.Size(64, 20);
            this.Gen2.TabIndex = 2;
            this.Gen2.Text = "Gen 2";
            this.Gen2.UseVisualStyleBackColor = true;
            // 
            // Gen4
            // 
            this.Gen4.AutoSize = true;
            this.Gen4.Location = new System.Drawing.Point(6, 48);
            this.Gen4.Name = "Gen4";
            this.Gen4.Size = new System.Drawing.Size(64, 20);
            this.Gen4.TabIndex = 4;
            this.Gen4.Text = "Gen 4";
            this.Gen4.UseVisualStyleBackColor = true;
            // 
            // Gen5
            // 
            this.Gen5.AutoSize = true;
            this.Gen5.Location = new System.Drawing.Point(83, 48);
            this.Gen5.Name = "Gen5";
            this.Gen5.Size = new System.Drawing.Size(64, 20);
            this.Gen5.TabIndex = 5;
            this.Gen5.Text = "Gen 5";
            this.Gen5.UseVisualStyleBackColor = true;
            // 
            // Gen3
            // 
            this.Gen3.AutoSize = true;
            this.Gen3.Location = new System.Drawing.Point(172, 22);
            this.Gen3.Name = "Gen3";
            this.Gen3.Size = new System.Drawing.Size(64, 20);
            this.Gen3.TabIndex = 3;
            this.Gen3.Text = "Gen 3";
            this.Gen3.UseVisualStyleBackColor = true;
            // 
            // Gen7
            // 
            this.Gen7.AutoSize = true;
            this.Gen7.Location = new System.Drawing.Point(6, 74);
            this.Gen7.Name = "Gen7";
            this.Gen7.Size = new System.Drawing.Size(64, 20);
            this.Gen7.TabIndex = 7;
            this.Gen7.Text = "Gen 7";
            this.Gen7.UseVisualStyleBackColor = true;
            // 
            // Gen8
            // 
            this.Gen8.AutoSize = true;
            this.Gen8.Location = new System.Drawing.Point(83, 74);
            this.Gen8.Name = "Gen8";
            this.Gen8.Size = new System.Drawing.Size(64, 20);
            this.Gen8.TabIndex = 8;
            this.Gen8.Text = "Gen 8";
            this.Gen8.UseVisualStyleBackColor = true;
            // 
            // Gen6
            // 
            this.Gen6.AutoSize = true;
            this.Gen6.Location = new System.Drawing.Point(172, 48);
            this.Gen6.Name = "Gen6";
            this.Gen6.Size = new System.Drawing.Size(64, 20);
            this.Gen6.TabIndex = 6;
            this.Gen6.Text = "Gen 6";
            this.Gen6.UseVisualStyleBackColor = true;
            // 
            // Gen9
            // 
            this.Gen9.AutoSize = true;
            this.Gen9.Location = new System.Drawing.Point(172, 74);
            this.Gen9.Name = "Gen9";
            this.Gen9.Size = new System.Drawing.Size(64, 20);
            this.Gen9.TabIndex = 9;
            this.Gen9.Text = "Gen 9";
            this.Gen9.UseVisualStyleBackColor = true;
            // 
            // PokeDisplay
            // 
            this.PokeDisplay.Image = ((System.Drawing.Image)(resources.GetObject("PokeDisplay.Image")));
            this.PokeDisplay.Location = new System.Drawing.Point(455, 0);
            this.PokeDisplay.Name = "PokeDisplay";
            this.PokeDisplay.Size = new System.Drawing.Size(600, 480);
            this.PokeDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokeDisplay.TabIndex = 18;
            this.PokeDisplay.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Location = new System.Drawing.Point(279, 54);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(46, 16);
            this.ScoreText.TabIndex = 19;
            this.ScoreText.Text = "Score:";
            // 
            // PunishAmount
            // 
            this.PunishAmount.Location = new System.Drawing.Point(282, 152);
            this.PunishAmount.MaxLength = 2;
            this.PunishAmount.Name = "PunishAmount";
            this.PunishAmount.Size = new System.Drawing.Size(121, 22);
            this.PunishAmount.TabIndex = 13;
            this.PunishAmount.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Punishment Amount";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Location = new System.Drawing.Point(282, 73);
            this.ScoreBox.MaxLength = 12;
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(121, 22);
            this.ScoreBox.TabIndex = 12;
            this.ScoreBox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1062, 485);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PunishAmount);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.PokeDisplay);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.GenGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pokémon Guesser";
            this.GenGroup.ResumeLayout(false);
            this.GenGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PokeDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.ListBox OutputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GenGroup;
        private System.Windows.Forms.CheckBox Gen6;
        private System.Windows.Forms.CheckBox Gen7;
        private System.Windows.Forms.CheckBox Gen8;
        private System.Windows.Forms.CheckBox Gen9;
        private System.Windows.Forms.CheckBox Gen1;
        private System.Windows.Forms.CheckBox Gen2;
        private System.Windows.Forms.CheckBox Gen4;
        private System.Windows.Forms.CheckBox Gen5;
        private System.Windows.Forms.CheckBox Gen3;
        private System.Windows.Forms.CheckBox GenAll;
        private System.Windows.Forms.Button SettingsSave;
        private System.Windows.Forms.PictureBox PokeDisplay;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.TextBox PunishAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ScoreBox;
    }
}

