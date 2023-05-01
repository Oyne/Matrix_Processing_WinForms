using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.Design.AxImporter;

namespace MatrixProcessing
{
    public partial class MatrixProccesing : Form
    {
        string file_name;
        MatrixOperations matrix;

        public MatrixProccesing(string file_name, MatrixOperations matrix)
        {
            this.file_name = file_name;
            this.matrix = matrix;
            InitializeComponent();
        }

        private void MatrixProccesing_Load(object sender, EventArgs e)
        {
            MatrixOutput(MatrixGridView, matrix.Value);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new TwoDimensionalIntArrayJsonConverter());

            SaveFileDialog ExportFileDialog = new SaveFileDialog();
            ExportFileDialog.InitialDirectory = "Desktop";
            ExportFileDialog.Title = "Export file";
            ExportFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            ExportFileDialog.AddExtension = true;

            if (ExportFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = ExportFileDialog.FileName;
                string json = JsonSerializer.Serialize(matrix.Value, options);
                File.WriteAllText(file_name, json);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (file_name != null)
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new TwoDimensionalIntArrayJsonConverter());

                string json = JsonSerializer.Serialize(matrix.Value, options);
                File.WriteAllText(file_name, json);
            }
            else
                MessageBox.Show("No file opened", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MatrixOutput(DataGridView Grid, int[,] matrix)
        {
            int row_col_count = matrix.GetLength(0);
            Grid.RowCount = 1;
            Grid.ColumnCount = 1;
            Grid.EnableHeadersVisualStyles = false;

            Grid.RowCount = row_col_count + 1;
            Grid.ColumnCount = row_col_count + 1;

            for (int i = 0; i < row_col_count + 1; i++)
            {
                Grid[i, 0].Value = i == 0 ? "i" : i;
                Grid[i, 0].Style.ForeColor = Color.FromArgb(192, 255, 255);
                Grid[0, i].Value = i == 0 ? "i" : i;
                Grid[0, i].Style.ForeColor = Color.FromArgb(192, 255, 255);
            }

            foreach (DataGridViewColumn dgvc in Grid.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < row_col_count; i++)
            {
                for (int j = 0; j < row_col_count; j++)
                    Grid[j + 1, i + 1].Value = matrix[i, j];
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            if (OperationOneRButton.Checked)
            {
                matrix.OperationOne();
                MatrixOutput(ResultMatrixGridView, matrix.Value);
            }
        }
    }
}
