namespace MatrixProcessing
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            AuthorButton = new Button();
            MainMenuToolTip = new ToolTip(components);
            groupBox1 = new GroupBox();
            MaxLabel = new Label();
            MinLabel = new Label();
            SizeLabel = new Label();
            GenerateButton = new Button();
            MaxUpDown = new NumericUpDown();
            MinUpDown = new NumericUpDown();
            SizeUpDown = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SizeUpDown).BeginInit();
            SuspendLayout();
            // 
            // AuthorButton
            // 
            AuthorButton.BackgroundImageLayout = ImageLayout.Center;
            AuthorButton.FlatAppearance.BorderSize = 0;
            AuthorButton.FlatStyle = FlatStyle.Flat;
            AuthorButton.Image = (Image)resources.GetObject("AuthorButton.Image");
            AuthorButton.Location = new Point(223, 56);
            AuthorButton.Name = "AuthorButton";
            AuthorButton.Size = new Size(126, 130);
            AuthorButton.TabIndex = 0;
            MainMenuToolTip.SetToolTip(AuthorButton, "Information about author");
            AuthorButton.UseVisualStyleBackColor = true;
            AuthorButton.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MaxLabel);
            groupBox1.Controls.Add(MinLabel);
            groupBox1.Controls.Add(SizeLabel);
            groupBox1.Controls.Add(GenerateButton);
            groupBox1.Controls.Add(MaxUpDown);
            groupBox1.Controls.Add(MinUpDown);
            groupBox1.Controls.Add(SizeUpDown);
            groupBox1.ForeColor = Color.FromArgb(255, 224, 192);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 217);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Matrix Settings";
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(6, 124);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(37, 20);
            MaxLabel.TabIndex = 6;
            MaxLabel.Text = "Max";
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(6, 70);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(34, 20);
            MinLabel.TabIndex = 5;
            MinLabel.Text = "Min";
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Location = new Point(6, 28);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(71, 20);
            SizeLabel.TabIndex = 4;
            SizeLabel.Text = "Size [x, x]";
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.FromArgb(64, 64, 64);
            GenerateButton.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            GenerateButton.FlatStyle = FlatStyle.Flat;
            GenerateButton.Location = new Point(6, 167);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(193, 44);
            GenerateButton.TabIndex = 3;
            GenerateButton.Text = "Generate";
            MainMenuToolTip.SetToolTip(GenerateButton, "Generates matrix with specified size, min and max value");
            GenerateButton.UseVisualStyleBackColor = false;
            // 
            // MaxUpDown
            // 
            MaxUpDown.Location = new Point(83, 124);
            MaxUpDown.Name = "MaxUpDown";
            MaxUpDown.Size = new Size(114, 27);
            MaxUpDown.TabIndex = 2;
            MaxUpDown.ValueChanged += MaxUpDown_ValueChanged;
            // 
            // MinUpDown
            // 
            MinUpDown.Location = new Point(83, 70);
            MinUpDown.Name = "MinUpDown";
            MinUpDown.Size = new Size(114, 27);
            MinUpDown.TabIndex = 1;
            MinUpDown.ValueChanged += MinUpDown_ValueChanged;
            // 
            // SizeUpDown
            // 
            SizeUpDown.Location = new Point(83, 26);
            SizeUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            SizeUpDown.Name = "SizeUpDown";
            SizeUpDown.Size = new Size(114, 27);
            SizeUpDown.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(356, 234);
            Controls.Add(groupBox1);
            Controls.Add(AuthorButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SizeUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button AuthorButton;
        private ToolTip MainMenuToolTip;
        private GroupBox groupBox1;
        private Label MaxLabel;
        private Label MinLabel;
        private Label SizeLabel;
        private Button GenerateButton;
        private NumericUpDown MaxUpDown;
        private NumericUpDown MinUpDown;
        private NumericUpDown SizeUpDown;
    }
}