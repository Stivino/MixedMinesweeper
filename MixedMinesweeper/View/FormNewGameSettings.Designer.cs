namespace MixedMinesweeper.View
{
    partial class FormNewGameSettings
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
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMines = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.numericUpDown_GreenMines = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_YellowMines = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_BlueMines = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_RedMines = new System.Windows.Forms.NumericUpDown();
            this.lblBlueMines = new System.Windows.Forms.Label();
            this.lblRedMines = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_FieldWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_FieldHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Beginner = new System.Windows.Forms.RadioButton();
            this.radioButton_Intermediate = new System.Windows.Forms.RadioButton();
            this.radioButton_Expert = new System.Windows.Forms.RadioButton();
            this.groupBoxMines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GreenMines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_YellowMines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BlueMines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RedMines)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldHeight)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(283, 403);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(89, 37);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Start";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neues Spiel";
            // 
            // groupBoxMines
            // 
            this.groupBoxMines.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxMines.Controls.Add(this.numericUpDown_GreenMines);
            this.groupBoxMines.Controls.Add(this.numericUpDown_YellowMines);
            this.groupBoxMines.Controls.Add(this.numericUpDown_BlueMines);
            this.groupBoxMines.Controls.Add(this.label8);
            this.groupBoxMines.Controls.Add(this.lblRedMines);
            this.groupBoxMines.Controls.Add(this.label7);
            this.groupBoxMines.Controls.Add(this.lblBlueMines);
            this.groupBoxMines.Controls.Add(this.numericUpDown_RedMines);
            this.groupBoxMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMines.Location = new System.Drawing.Point(12, 216);
            this.groupBoxMines.Name = "groupBoxMines";
            this.groupBoxMines.Size = new System.Drawing.Size(357, 158);
            this.groupBoxMines.TabIndex = 17;
            this.groupBoxMines.TabStop = false;
            this.groupBoxMines.Text = "Anzahl Minen";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(9, 414);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 26;
            // 
            // numericUpDown_GreenMines
            // 
            this.numericUpDown_GreenMines.BackColor = System.Drawing.Color.YellowGreen;
            this.numericUpDown_GreenMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_GreenMines.Location = new System.Drawing.Point(267, 122);
            this.numericUpDown_GreenMines.Name = "numericUpDown_GreenMines";
            this.numericUpDown_GreenMines.Size = new System.Drawing.Size(75, 24);
            this.numericUpDown_GreenMines.TabIndex = 25;
            this.numericUpDown_GreenMines.ValueChanged += new System.EventHandler(this.numericUpDown_Mines_ValueChanged);
            // 
            // numericUpDown_YellowMines
            // 
            this.numericUpDown_YellowMines.BackColor = System.Drawing.Color.Yellow;
            this.numericUpDown_YellowMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_YellowMines.Location = new System.Drawing.Point(266, 92);
            this.numericUpDown_YellowMines.Name = "numericUpDown_YellowMines";
            this.numericUpDown_YellowMines.Size = new System.Drawing.Size(75, 24);
            this.numericUpDown_YellowMines.TabIndex = 24;
            this.numericUpDown_YellowMines.ValueChanged += new System.EventHandler(this.numericUpDown_Mines_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "Grüne Minen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 22;
            this.label7.Text = "Gelbe Minen";
            // 
            // numericUpDown_BlueMines
            // 
            this.numericUpDown_BlueMines.BackColor = System.Drawing.Color.LightSkyBlue;
            this.numericUpDown_BlueMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_BlueMines.Location = new System.Drawing.Point(267, 62);
            this.numericUpDown_BlueMines.Name = "numericUpDown_BlueMines";
            this.numericUpDown_BlueMines.Size = new System.Drawing.Size(75, 24);
            this.numericUpDown_BlueMines.TabIndex = 21;
            this.numericUpDown_BlueMines.ValueChanged += new System.EventHandler(this.numericUpDown_Mines_ValueChanged);
            // 
            // numericUpDown_RedMines
            // 
            this.numericUpDown_RedMines.BackColor = System.Drawing.Color.Tomato;
            this.numericUpDown_RedMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_RedMines.Location = new System.Drawing.Point(266, 32);
            this.numericUpDown_RedMines.Name = "numericUpDown_RedMines";
            this.numericUpDown_RedMines.Size = new System.Drawing.Size(76, 24);
            this.numericUpDown_RedMines.TabIndex = 20;
            this.numericUpDown_RedMines.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_RedMines.ValueChanged += new System.EventHandler(this.numericUpDown_Mines_ValueChanged);
            // 
            // lblBlueMines
            // 
            this.lblBlueMines.AutoSize = true;
            this.lblBlueMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueMines.Location = new System.Drawing.Point(52, 64);
            this.lblBlueMines.Name = "lblBlueMines";
            this.lblBlueMines.Size = new System.Drawing.Size(89, 18);
            this.lblBlueMines.TabIndex = 19;
            this.lblBlueMines.Text = "Blaue Minen";
            // 
            // lblRedMines
            // 
            this.lblRedMines.AutoSize = true;
            this.lblRedMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedMines.Location = new System.Drawing.Point(51, 34);
            this.lblRedMines.Name = "lblRedMines";
            this.lblRedMines.Size = new System.Drawing.Size(84, 18);
            this.lblRedMines.TabIndex = 18;
            this.lblRedMines.Text = "Rote Minen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown_FieldHeight);
            this.groupBox1.Controls.Add(this.numericUpDown_FieldWidth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spielfeldgröße";
            // 
            // numericUpDown_FieldWidth
            // 
            this.numericUpDown_FieldWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_FieldWidth.Location = new System.Drawing.Point(94, 30);
            this.numericUpDown_FieldWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_FieldWidth.Name = "numericUpDown_FieldWidth";
            this.numericUpDown_FieldWidth.Size = new System.Drawing.Size(74, 24);
            this.numericUpDown_FieldWidth.TabIndex = 11;
            this.numericUpDown_FieldWidth.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numericUpDown_FieldHeight
            // 
            this.numericUpDown_FieldHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_FieldHeight.Location = new System.Drawing.Point(268, 30);
            this.numericUpDown_FieldHeight.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_FieldHeight.Name = "numericUpDown_FieldHeight";
            this.numericUpDown_FieldHeight.Size = new System.Drawing.Size(74, 24);
            this.numericUpDown_FieldHeight.TabIndex = 13;
            this.numericUpDown_FieldHeight.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Länge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Höhe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Expert);
            this.groupBox2.Controls.Add(this.radioButton_Intermediate);
            this.groupBox2.Controls.Add(this.radioButton_Beginner);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 59);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voreinstellung";
            // 
            // radioButton_Beginner
            // 
            this.radioButton_Beginner.AutoSize = true;
            this.radioButton_Beginner.Checked = true;
            this.radioButton_Beginner.Location = new System.Drawing.Point(6, 23);
            this.radioButton_Beginner.Name = "radioButton_Beginner";
            this.radioButton_Beginner.Size = new System.Drawing.Size(84, 22);
            this.radioButton_Beginner.TabIndex = 0;
            this.radioButton_Beginner.TabStop = true;
            this.radioButton_Beginner.Text = "Anfänger";
            this.radioButton_Beginner.UseVisualStyleBackColor = true;
            this.radioButton_Beginner.CheckedChanged += new System.EventHandler(this.radioButton_Beginner_CheckedChanged);
            // 
            // radioButton_Intermediate
            // 
            this.radioButton_Intermediate.AutoSize = true;
            this.radioButton_Intermediate.Location = new System.Drawing.Point(124, 23);
            this.radioButton_Intermediate.Name = "radioButton_Intermediate";
            this.radioButton_Intermediate.Size = new System.Drawing.Size(125, 22);
            this.radioButton_Intermediate.TabIndex = 1;
            this.radioButton_Intermediate.Text = "Fortgeschritten";
            this.radioButton_Intermediate.UseVisualStyleBackColor = true;
            this.radioButton_Intermediate.CheckedChanged += new System.EventHandler(this.radioButton_Intermediate_CheckedChanged);
            // 
            // radioButton_Expert
            // 
            this.radioButton_Expert.AutoSize = true;
            this.radioButton_Expert.Location = new System.Drawing.Point(284, 23);
            this.radioButton_Expert.Name = "radioButton_Expert";
            this.radioButton_Expert.Size = new System.Drawing.Size(57, 22);
            this.radioButton_Expert.TabIndex = 2;
            this.radioButton_Expert.Text = "Profi";
            this.radioButton_Expert.UseVisualStyleBackColor = true;
            this.radioButton_Expert.CheckedChanged += new System.EventHandler(this.radioButton_Expert_CheckedChanged);
            // 
            // FormNewGameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 490);
            this.MinimumSize = new System.Drawing.Size(400, 490);
            this.Name = "FormNewGameSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormNewGameSettings";
            this.Load += new System.EventHandler(this.FormNewGameSettings_Load);
            this.groupBoxMines.ResumeLayout(false);
            this.groupBoxMines.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_GreenMines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_YellowMines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BlueMines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RedMines)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldHeight)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMines;
        private System.Windows.Forms.NumericUpDown numericUpDown_GreenMines;
        private System.Windows.Forms.NumericUpDown numericUpDown_YellowMines;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_BlueMines;
        private System.Windows.Forms.NumericUpDown numericUpDown_RedMines;
        private System.Windows.Forms.Label lblBlueMines;
        private System.Windows.Forms.Label lblRedMines;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_FieldHeight;
        private System.Windows.Forms.NumericUpDown numericUpDown_FieldWidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Expert;
        private System.Windows.Forms.RadioButton radioButton_Intermediate;
        private System.Windows.Forms.RadioButton radioButton_Beginner;
    }
}