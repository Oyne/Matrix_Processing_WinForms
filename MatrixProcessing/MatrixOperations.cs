using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Security.Cryptography.Xml;
using System.Drawing.Drawing2D;

namespace MatrixProcessing
{
    public class MatrixOperations
    {

        /// <summary>
        /// Matrix of integers.
        /// </summary>
        private int[,]? _matrix = null;

        /// <summary>
        /// Matrix property.
        /// </summary>
        public int[,]? Value { get => _matrix; set => _matrix = value; }


        /// <summary>
        /// Generates Matrix with specified values.
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
        /// Clears Matrix
        /// </summary>
        public void Clear()
        {
            _matrix = null;
        }

        /// <summary>
        /// Sort elements of array in ascending order in rows, display them in 2d array
        /// </summary>
        /// <returns>Min, max, median.</returns>
        public int[,] OperationOne()
        {
            int[,] copy = (int[,])_matrix.Clone();
            if (copy is not null)
                for (int row = 0; row < copy.GetLength(0); row++)
                    for (int col = 0; col < copy.GetLength(1); col++)
                        for (int i = col + 1; i < copy.GetLength(1); i++)
                            if (copy[row, col] > copy[row, i])
                            {
                                int tmp = copy[row, i];
                                copy[row, i] = copy[row, col];
                                copy[row, col] = tmp;
                            }
   
            return copy;
        }

        /// <summary>
        /// Calculates Sr
        /// </summary>
        /// <returns>Sr of matrix</returns>
        private int Sr()
        {

            int sum = 0;
            for (int i = 0; i < _matrix.GetLength(0); i++)
                for (int j = 0; j < _matrix.GetLength(1); j++)
                    sum += _matrix[i, j];
            
            return sum / _matrix.Length;
        }

        /// <summary>
        /// Calculate variance of array elements
        /// </summary>
        public int OperationTwo()
        {
            int sum = 0;
            for (int i = 0; i < _matrix.GetLength(0); i++)
                for (int j = 0; j < _matrix.GetLength(1); j++)
                    sum += (int)Math.Pow((_matrix[i, j] - Sr()), 2);
           
            return sum / (_matrix.Length - 1);
        }

        /// <summary>
        /// Using Trial division method find number of prime numbers with even sum of indicies
        /// </summary>
        /// <returns>Number, sum.</returns>
        public int[,] OperationThree()
        {
            List<int> x = new List<int>();
            List<int> y = new List<int>();

            for (int i = 0; i < _matrix.GetLength(0); i++)
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    bool flag = true;
                    for (int el = 1; el <= Math.Sqrt(_matrix[i, j]); el++)
                    {
                        if (_matrix[i, j] % el == 0 && el != 1)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            x.Add(i);
                            y.Add(j);
                        }
                    }
                }
         
            int[,] positions = new int[x.Count, 2];
            for (int i = 0; i < positions.GetLength(0); i++)
            {
                positions[i, 0] = x[i];
                positions[i, 1] = y[i];
            }
            return positions;
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
