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
        /// <summary>
        /// Name of file where matrix would be saved. 
        /// </summary>
        string file_name;

        /// <summary>
        /// Name of file where results would be saved.
        /// </summary>
        string result_file_name;

        /// <summary>
        /// Instance of MatrixOperations.
        /// </summary>
        MatrixOperations matrix;

        /// <summary>
        /// Matrix for saving results
        /// </summary>
        int[,] matrix_result;

        /// <summary>
        /// String for saving results
        /// </summary>
        string string_result;

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
                result_file_name = ExportFileDialog.FileName;
                string json;

                if (OperationOneRButton.Checked)
                {
                    json = JsonSerializer.Serialize(matrix_result, options);
                    File.WriteAllText(result_file_name, json);
                }
                else
                {
                    json = JsonSerializer.Serialize(string_result);
                    File.WriteAllText(result_file_name, json);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions();
            options.Converters.Add(new TwoDimensionalIntArrayJsonConverter());

            SaveFileDialog SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.InitialDirectory = "Desktop";
            SaveFileDialog.Title = "Export file";
            SaveFileDialog.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            SaveFileDialog.AddExtension = true;

            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                file_name = SaveFileDialog.FileName;
                string json = JsonSerializer.Serialize(matrix.Value, options);
                File.WriteAllText(file_name, json);
            }
        }

        /// <summary>
        /// Prints matrix in dataGridView
        /// </summary>
        /// <param name="Grid">Grid where matrix would be displayed.</param>
        /// <param name="matrix">A matrix that needs to be displayed.</param>
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
                for (int j = 0; j < row_col_count; j++)
                    Grid[j + 1, i + 1].Value = matrix[i, j];
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            if (OperationOneRButton.Checked)
            {
                matrix_result = matrix.OperationOne();
                MatrixOutput(ResultMatrixGridView, matrix_result);
                ResultTextBox.Text = $"Matrix rows were sorted";

            }
            else if (OperationTwoRButton.Checked)
            {
                int d = matrix.OperationTwo();
                string_result = $"D = {d}";
                ResultTextBox.Text = string_result;
            }
            else if (OperationThreeRButton.Checked)
            {
                int[,] positions = matrix.OperationThree();
                MatrixOutput(ResultMatrixGridView, matrix.Value);
                for (int i = 0; i < positions.GetLength(0); i++)
                    ResultMatrixGridView[positions[i, 1] + 1, positions[i, 0] + 1].Style.ForeColor = Color.FromArgb(192, 255, 192);
                string_result = $"Number of prime numbers = {positions.GetLength(0)}";
                ResultTextBox.Text = string_result;
            }
        }
    }
}
