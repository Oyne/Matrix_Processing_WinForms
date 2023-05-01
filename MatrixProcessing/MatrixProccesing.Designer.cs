namespace MatrixProcessing
{
    partial class MatrixProccesing
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixProccesing));
            MatrixGridView = new DataGridView();
            ResultMatrixGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ExportButton = new Button();
            SaveButton = new Button();
            groupBox1 = new GroupBox();
            OperationThreeRButton = new RadioButton();
            OperationTwoRButton = new RadioButton();
            OperationOneRButton = new RadioButton();
            OperationButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MatrixGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ResultMatrixGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // MatrixGridView
            // 
            MatrixGridView.AllowUserToAddRows = false;
            MatrixGridView.AllowUserToDeleteRows = false;
            MatrixGridView.AllowUserToResizeColumns = false;
            MatrixGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(64, 64, 64);
            MatrixGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            MatrixGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            MatrixGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            MatrixGridView.BorderStyle = BorderStyle.Fixed3D;
            MatrixGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MatrixGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MatrixGridView.DefaultCellStyle = dataGridViewCellStyle2;
            MatrixGridView.GridColor = Color.White;
            MatrixGridView.Location = new Point(18, 74);
            MatrixGridView.Name = "MatrixGridView";
            MatrixGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            MatrixGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MatrixGridView.RowHeadersVisible = false;
            MatrixGridView.RowHeadersWidth = 51;
            MatrixGridView.RowTemplate.Height = 29;
            MatrixGridView.Size = new Size(342, 334);
            MatrixGridView.TabIndex = 0;
            // 
            // ResultMatrixGridView
            // 
            ResultMatrixGridView.AllowUserToAddRows = false;
            ResultMatrixGridView.AllowUserToDeleteRows = false;
            ResultMatrixGridView.AllowUserToResizeColumns = false;
            ResultMatrixGridView.AllowUserToResizeRows = false;
            ResultMatrixGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ResultMatrixGridView.BackgroundColor = Color.FromArgb(64, 64, 64);
            ResultMatrixGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ResultMatrixGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ResultMatrixGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultMatrixGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            ResultMatrixGridView.DefaultCellStyle = dataGridViewCellStyle5;
            ResultMatrixGridView.GridColor = Color.White;
            ResultMatrixGridView.Location = new Point(567, 74);
            ResultMatrixGridView.Name = "ResultMatrixGridView";
            ResultMatrixGridView.ReadOnly = true;
            ResultMatrixGridView.RowHeadersVisible = false;
            ResultMatrixGridView.RowHeadersWidth = 51;
            ResultMatrixGridView.RowTemplate.Height = 29;
            ResultMatrixGridView.Size = new Size(342, 334);
            ResultMatrixGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 62);
            label1.TabIndex = 2;
            label1.Text = "Matrix";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(255, 224, 192);
            label2.Location = new Point(663, 9);
            label2.Name = "label2";
            label2.Size = new Size(153, 62);
            label2.TabIndex = 3;
            label2.Text = "Result";
            // 
            // ExportButton
            // 
            ExportButton.BackgroundImage = (Image)resources.GetObject("ExportButton.BackgroundImage");
            ExportButton.BackgroundImageLayout = ImageLayout.Center;
            ExportButton.FlatAppearance.BorderSize = 0;
            ExportButton.FlatStyle = FlatStyle.Flat;
            ExportButton.Location = new Point(468, 414);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(93, 86);
            ExportButton.TabIndex = 4;
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackgroundImage = (Image)resources.GetObject("SaveButton.BackgroundImage");
            SaveButton.BackgroundImageLayout = ImageLayout.Center;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Location = new Point(366, 414);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(93, 86);
            SaveButton.TabIndex = 5;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(OperationThreeRButton);
            groupBox1.Controls.Add(OperationTwoRButton);
            groupBox1.Controls.Add(OperationOneRButton);
            groupBox1.Controls.Add(OperationButton);
            groupBox1.ForeColor = Color.FromArgb(255, 224, 192);
            groupBox1.Location = new Point(367, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(194, 254);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operations";
            // 
            // OperationThreeRButton
            // 
            OperationThreeRButton.AutoSize = true;
            OperationThreeRButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OperationThreeRButton.Location = new Point(5, 128);
            OperationThreeRButton.Name = "OperationThreeRButton";
            OperationThreeRButton.Size = new Size(185, 42);
            OperationThreeRButton.TabIndex = 3;
            OperationThreeRButton.Text = "Operation 3";
            OperationThreeRButton.UseVisualStyleBackColor = true;
            // 
            // OperationTwoRButton
            // 
            OperationTwoRButton.AutoSize = true;
            OperationTwoRButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OperationTwoRButton.Location = new Point(5, 77);
            OperationTwoRButton.Name = "OperationTwoRButton";
            OperationTwoRButton.Size = new Size(185, 42);
            OperationTwoRButton.TabIndex = 2;
            OperationTwoRButton.Text = "Operation 2";
            OperationTwoRButton.UseVisualStyleBackColor = true;
            // 
            // OperationOneRButton
            // 
            OperationOneRButton.AutoSize = true;
            OperationOneRButton.Checked = true;
            OperationOneRButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            OperationOneRButton.Location = new Point(5, 26);
            OperationOneRButton.Name = "OperationOneRButton";
            OperationOneRButton.Size = new Size(185, 42);
            OperationOneRButton.TabIndex = 1;
            OperationOneRButton.TabStop = true;
            OperationOneRButton.Text = "Operation 1";
            OperationOneRButton.UseVisualStyleBackColor = true;
            // 
            // OperationButton
            // 
            OperationButton.FlatStyle = FlatStyle.Flat;
            OperationButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            OperationButton.Location = new Point(6, 179);
            OperationButton.Name = "OperationButton";
            OperationButton.Size = new Size(182, 69);
            OperationButton.TabIndex = 0;
            OperationButton.Text = "Operation";
            OperationButton.UseVisualStyleBackColor = true;
            OperationButton.Click += OperationButton_Click;
            // 
            // BackButton
            // 
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.FromArgb(255, 224, 192);
            BackButton.Location = new Point(372, 339);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(182, 69);
            BackButton.TabIndex = 7;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // MatrixProccesing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(925, 514);
            Controls.Add(BackButton);
            Controls.Add(groupBox1);
            Controls.Add(SaveButton);
            Controls.Add(ExportButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultMatrixGridView);
            Controls.Add(MatrixGridView);
            Name = "MatrixProccesing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Matrix Proccesing";
            Load += MatrixProccesing_Load;
            ((System.ComponentModel.ISupportInitialize)MatrixGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ResultMatrixGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MatrixGridView;
        private DataGridView ResultMatrixGridView;
        private Label label1;
        private Label label2;
        private Button ExportButton;
        private Button SaveButton;
        private GroupBox groupBox1;
        private RadioButton OperationThreeRButton;
        private RadioButton OperationTwoRButton;
        private RadioButton OperationOneRButton;
        private Button OperationButton;
        private Button BackButton;
    }
}