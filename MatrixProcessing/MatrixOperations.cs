using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace MatrixProcessing
{
    public class MatrixOperations
    {

        /// <summary>
        /// Matrix of integers.
        /// </summary>
        private int[,]? _matrix = null;

        /// <summary>
        /// Array property.
        /// </summary>
        public int[,]? Value { get => _matrix; set => _matrix = value; }


        /// <summary>
        /// Generates array with specified values.
        /// </summary>
        /// <param name="size">Size of matrix.</param>
        /// <param name="min">Min element of matrix.</param>
        /// <param name="max">Max element of matrix.</param>
        public void GenerateMatrix(int size, int min, int max)
        {
            _matrix = new int[size, size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++) _matrix[i, j] = random.Next(min, max + 1);
        }

        /// <summary>
        /// Clears array
        /// </summary>
        public void Clear()
        {
            _matrix = null;
        }

        /// <summary>
        /// Find min, max element of array and median.
        /// </summary>
        /// <returns>Min, max, median.</returns>
        public void OperationOne()
        {
            if (_matrix is not null)

                for (int row = 0; row < _matrix.GetLength(0); row++)

                    for (int col = 0; col < _matrix.GetLength(1); col++)

                        for (int i = col + 1; i < _matrix.GetLength(1); i++)
                        {
                            if (_matrix[row, col] > _matrix[row, i])
                            {
                                int tmp = _matrix[row, i];
                                _matrix[row, i] = _matrix[row, col];
                                _matrix[row, col] = tmp;
                            }
                        }
        }

        /// <summary>
        /// Sort elements in descending order.
        /// </summary>
        public void OperationTwo()
        {
        
        }

        /// <summary>
        /// Calculate sum and number of elements of the array, 
        /// in which number created from last and third from end digits, element also must be even.
        /// </summary>
        /// <returns>Number, sum.</returns>
        public void OperationThree()
        {
        }


        /// <summary>
        /// Calculate sum and number of elements of the array, 
        /// in which number created from first and second digit, element also divisible by 5
        /// </summary>
        /// <returns>Number, sum.</returns>
        public void OperationFour()
        {
        }
    }

    public class TwoDimensionalIntArrayJsonConverter : JsonConverter<int[,]>
    {
        public override int[,]? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var jsonDoc = JsonDocument.ParseValue(ref reader);

            var rowLength = jsonDoc.RootElement.GetArrayLength();
            var columnLength = jsonDoc.RootElement.EnumerateArray().First().GetArrayLength();

            int[,] grid = new int[rowLength, columnLength];

            int row = 0;
            foreach (var array in jsonDoc.RootElement.EnumerateArray())
            {
                int column = 0;
                foreach (var number in array.EnumerateArray())
                {
                    grid[row, column] = number.GetInt32();
                    column++;
                }
                row++;
            }

            return grid;
        }
        public override void Write(Utf8JsonWriter writer, int[,] value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            for (int i = 0; i < value.GetLength(0); i++)
            {
                writer.WriteStartArray();
                for (int j = 0; j < value.GetLength(1); j++)
                {
                    writer.WriteNumberValue(value[i, j]);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
        }
    }
}
