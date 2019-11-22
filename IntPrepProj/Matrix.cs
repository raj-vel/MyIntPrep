using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntPrepProj
{
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
        }

        private void PrintMatrix(int[,] inputMatrix, string strToBePrinted = "Printing Matrix......")
        {
            int xLen = inputMatrix.GetLength(0);
            int yLen = inputMatrix.GetLength(1);
            Console.WriteLine(strToBePrinted);
            Console.WriteLine();
            for (int i = 0; i < xLen; i++)
            {
                for (int j = 0; j < yLen; j++)
                {
                    Console.Write(inputMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void PrintMatrixString(string[,] inputMatrix, string strToBePrinted = "Printing Matrix......")
        {
            int xLen = inputMatrix.GetLength(0);
            int yLen = inputMatrix.GetLength(1);
            Console.WriteLine(strToBePrinted);
            Console.WriteLine();
            for (int i = 0; i < xLen; i++)
            {
                for (int j = 0; j < yLen; j++)
                {
                    Console.Write(inputMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void Make_Rows_Columns_Zero_Click(object sender, EventArgs e)
        {
            // Given a M X N matrix, if any of the matrix value is zero, make the rows and columns of that value as Zeros
            // Construct a matirx

            int[,] input = { { 1, 2, 3, 4 }, { 5, 6, 7, 8, }, { 9, 10, 0, 12 }, { 13, 14, 15, 16 }, { 1, 5, 9, 7 }, { 0, 5, 7, 9 } };
            PrintMatrix(input);
            int[] rowArray = new int[input.GetLength(0)];
            int[] colArray = new int[input.GetLength(1)];

            //iterate and add to array
            for(int i=0; i < input.GetLength(0); i++)
            {
                for(int j=0; j < input.GetLength(1); j++)
                {
                    if(input[i,j] == 0)
                    {
                        rowArray[i] = -1;
                        colArray[j] = -1;
                    }
                }
            }

            for(int i = 0; i<input.GetLength(0); i++)
            {
                for(int j = 0; j<input.GetLength(1); j++)
                {
                    if(rowArray[i] == -1 || colArray[j] == -1)
                    {
                        input[i, j] = 0;
                    }
                }
            }

            PrintMatrix(input, "Modified/Output Matrix: ");
        }

        private void Find_Number_In_Asc_Matrix_Click(object sender, EventArgs e)
        {
            int[,] ascMatrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int numberToBeFound = 10;
            PrintMatrix(ascMatrix);
            Console.WriteLine();
            Console.WriteLine(string.Format("Number to be found: {0}", numberToBeFound));
            Console.WriteLine();
            Console.WriteLine();
            int j = ascMatrix.GetLength(1) - 1;
            for (int i=0; i<ascMatrix.GetLength(0); i++)
            {
                if(ascMatrix[i, j] >= numberToBeFound)
                {
                    while(ascMatrix[i, j] > numberToBeFound)
                    {
                        j -= 1;
                    } 
                    if(ascMatrix[i, j] == numberToBeFound)
                    {
                        Console.WriteLine(string.Format("Number found in Index - {0},{1}", i, j));
                        return;
                    }
                }
            }
            Console.WriteLine("Number not found"); ;
        }

        private void Matrix_Rotate_Right_Click(object sender, EventArgs e)
        {
            int[,] input = { { 1, 2, 3,4 }, { 5, 6, 7,8 }, { 9,10,11,12 }, { 13,14,15,16} };
            PrintMatrix(input, "Matrix Before Rotation:");
            Console.WriteLine("");
            Console.WriteLine("");
            input = HorizontalSwap(input);
            PrintMatrix(input, "After Hortzontal Swap:");            
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            input = DiagonalSwap(input);
            PrintMatrix(input, "Final Rotated:");
        }

        private int[,] HorizontalSwap(int[,] inputMatrix)
        {
            int rowSize = inputMatrix.GetLength(0);
            int columnSize = inputMatrix.GetLength(1);
            int updatedRowSize = rowSize;
            int x = 0;
            int y = rowSize - 1;
            while (updatedRowSize / 2 >= 1)
            {
                for (int i = 0; i < columnSize; i++)
                {
                    int temp = inputMatrix[x, i];
                    inputMatrix[x, i] = inputMatrix[y, i];
                    inputMatrix[y, i] = temp;
                }
                x += 1;
                y -= 1;

                updatedRowSize = updatedRowSize / 2;
            }
            return inputMatrix;
        }

        private int[,] DiagonalSwap(int[,] inputMatrix)
        {
            int rowSize = inputMatrix.GetLength(0);
            int columnSize = inputMatrix.GetLength(1);
            int count = 1;
            int x = 0;
            while(count < rowSize)
            {
                for(int i=count; i<rowSize; i++)
                {
                    int temp = inputMatrix[x, i];
                    inputMatrix[x,i] = inputMatrix[i, x];
                    inputMatrix[i, x] = temp;
                }
                count += 1;
                x += 1;
            }
            return inputMatrix;
        }

        private void SpiralMatrix_Click(object sender, EventArgs e)
        {
            int n = 6;
            string direction = "right";
            int max = n * n;
            int[,] matrix = new int[n, n];
            int row = 0, col = 0;

            for (int i = 0; i < max; i++)
            {
                if (direction == "right" && (col >= n || matrix[row, col] != 0))
                {
                    direction = "down";
                    row++;
                    col--;
                }

                if (direction == "down" && (row >= n || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }

                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    row--;
                    col++;
                }

                if (direction == "up" && (row < 0 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }



                matrix[row, col] = i + 1;
                if (direction == "right")
                    col++;

                if (direction == "down")
                    row++;

                if (direction == "left")
                    col--;

                if (direction == "up")
                    row--;
            }
            PrintMatrix(matrix);

        }

        private void PrintMatrix(int[,] array)
        {
            for(int i=0; i<array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void SpiralMartixSimple_Click(object sender, EventArgs e)
        {
            int m = 15;
            int n = 14;
            Spiral(new int[m, n], m, n);
            //var res = Spiral(new string[m, n], 5, 4);
            //PrintMatrixString(res);
        }

        private string[,] SpiralMatrixSimple(string[,] matrix, int m, int n)
        {
            int row = 0;
            int col = 0;
            int lastRow = m - 1;
            int lastCol = n - 1;
            int counter = 65;

            while(row <= lastRow && col <= lastCol)
            {
                for(int i=col; i<=lastCol; i++)
                {
                    matrix[row, i] = Convert.ToChar(counter).ToString();
                    counter++;
                }
                row++;

                for(int i = row; i<= lastRow; i++)
                {
                    matrix[i, lastCol] = Convert.ToChar(counter).ToString();
                    counter++;
                }
                lastCol--;

                for(int i= lastCol; i>=col; i--)
                {
                    matrix[lastRow, i] = Convert.ToChar(counter).ToString();
                    counter++;
                }
                lastRow--;

                for(int i = lastRow; i>=row; i--)
                {
                    matrix[i, col] = Convert.ToChar(counter).ToString();
                    counter++;
                }
                col++;
            }
            return matrix;
        }
        
        private void Spiral(int[,] matrix, int m, int n)
        {
            int row = 0;
            int col = 0;
            int lastRow = m - 1;
            int lastCol = n - 1;
            int count = 0;

            while(row <= lastRow && col <= lastCol)
            {
                for(int i=col; i<=lastCol; i++)
                {
                    matrix[row, i] = ++count;
                }
                row++;

                for(int i=row; i<=lastRow; i++)
                {
                    matrix[i, lastCol] = ++count;
                }
                lastCol--;

                for(int i=lastCol; i>=col; i--)
                {
                    matrix[lastRow, i] = ++count;
                }
                lastRow--;

                for(int i=lastRow; i>=row; i--)
                {
                    matrix[i, col] = ++count;
                }
                col++;
            }

            PrintMatrix(matrix);
        }

        private void FindClosestEnemy_Click(object sender, EventArgs e)
        {
            int[,] input = { { 0, 0, 0, 0 }, { 1, 0, 0, 0 }, { 0, 0, 0, 2 }, { 0, 0, 0, 2 } };
            var res = FindPositions(input);
        }

        private int FindPositions(int[,] matrix)
        {
            Dictionary<int, Tuple<int, int>> enemy = new Dictionary<int, Tuple<int, int>>();
            
            var meRow = -1;
            var meCol = -1;
            int counter = 1;
            int minDistance = int.MaxValue;
            int rowLen = matrix.GetLength(0);
            int colLen = matrix.GetLength(1);

            for (int row = 0; row <= matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - 1; col++)
                {
                    if(matrix[row, col] == 1)
                    {
                        meRow = row;
                        meCol = col;
                    }
                    if (matrix[row, col] == 2)
                    {
                        enemy.Add(counter, Tuple.Create(row, col));
                        counter++;
                    }
                }
            }

            foreach (var obj in enemy)
            {
                int dist = CalcDistance(obj.Value, meRow, meCol, rowLen, colLen);
                minDistance = Math.Min(minDistance, dist);
            }
            return minDistance;
        }

        private int CalcDistance(Tuple<int, int> enemy, int meRow, int meCol, int rowLen, int colLen)
        {
            int distance = 0;
            var enemyRow = enemy.Item1;
            var enemyCol = enemy.Item2;

            int rowDistance = Math.Min(Math.Abs(enemyRow - meRow), Math.Abs(meRow - (enemyRow - rowLen)));
            int colDistance = Math.Min(Math.Abs(enemyCol - meCol), Math.Abs(meCol - (enemyCol - colLen)));

            distance = rowDistance + colDistance;
            return distance;
        }

        private void SpiralMatrixWithIndexGiven_Click(object sender, EventArgs e)
        {
            var res = SpiralMatrixWithIndex(6, 2, 2);
            PrintMatrix(res);

           //7 8 9
           //6 1 2
           //5 4 3
        }

        private int[,] SpiralMatrixWithIndex(int n, int row, int col)
        {
            int maxValue = n * n;
            List<string> directions = new List<string> { "Right", "Down", "Left", "Up" };
            string prevDir = "Up";
            int counter = 2;
            int[,] matrix = new int[n, n];
            matrix[row, col] = 1;
            int dirIndex = 0;

            while (counter <= maxValue)
            {
                if(dirIndex > 3)
                {
                    dirIndex = 0;
                }
                string dir = directions[dirIndex];

                if((dir == "Right" && matrix[row, col+1] != 0)
                    || (dir == "Down" && matrix[row + 1, col] != 0)
                    || (dir == "Left" && matrix[row, col - 1] != 0) 
                    || (dir == "Up" && matrix[row - 1, col] != 0))
                {
                    dir = prevDir;
                    dirIndex--;
                }

                switch (dir)
                {
                    case "Right":
                        matrix[row, col + 1] = counter;
                        col++;
                        break;
                    case "Down":
                        matrix[row+1, col] = counter;
                        row++;
                        break;
                    case "Left":
                        matrix[row, col-1] = counter;
                        col--;
                        break;
                    case "Up":
                        matrix[row-1, col] = counter;
                        row--;
                        break;
                }
                    prevDir = dir;

                counter++;
                dirIndex++;
            }
            return matrix;
        }

        private void FindNumInRowViceColViceAscMatrix_Click(object sender, EventArgs e)
        {

            int[,] arr = new int[,] { { 10, 20, 30, 40 }, { 12, 22, 33, 45 }, { 14, 24, 44, 47 }, { 16, 26, 46, 50 } };
            //int[,] arr = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            int x = 50;

            int row = 0;
            int col = arr.GetLength(1)-1;
            int rowIndex = -1;
            int colIndex = -1;

            while (row < arr.GetLength(0) && col >= 0)
            {
                if (arr[row, col] == x)
                {
                    rowIndex = row; colIndex = col;
                    break;
                }
                else if (arr[row, col] < x)
                {
                    row++;
                }
                else
                {
                    col--;
                }
            }
            PrintMatrix(arr);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(string.Format("The value {0} is found in Row {1} and Column {2}", x, rowIndex, colIndex));
        }

        private void FindTheMaxNeighbors_Click(object sender, EventArgs e)
        {
            string[,] input = new string[,] { { "A", "A", "B", "B", "B" }, { "A", "A", "B", "B", "B" }, {"A", "A", "B", "E", "E" }, { "C", "C", "D", "D", "E" }, { "D", "D", "D", "E", "E" } };
            int maxNeighbor = GetMaxNeighbor(input);
        }


        private int GetMaxNeighbor(string[,] arr)
        {
            if (arr != null)
            {
                int rowLen = arr.GetLength(0);
                int colLen = arr.GetLength(1);

                string maxString = "";
                int maxValue = -1;

                for (int row = 0; row < rowLen; row++)
                {
                    for (int col = 0; col < colLen; col++)
                    {
                        string currentValue = arr[row, col];
                        var neighboursList = GetNeighbors(arr, row, col, currentValue);
                        if (neighboursList.Count > maxValue)
                        {
                            maxString = currentValue;
                            maxValue = neighboursList.Count;
                        }
                    }
                }
                return maxValue;
            }
            return -1;
        }


        private List<string> GetNeighbors(string[,] arr, int row, int col, string currentValue)
        {
            List<string> neighborsList = new List<string>();
            for (int r1 = row - 1; r1 <= row + 1; r1++)
            {
                for (int c1 = col - 1; c1 <= col + 1; c1++)
                {
                    string neighbor = GetNeighbor(arr, r1, c1, currentValue);
                    if (neighbor != "" && !neighborsList.Contains(neighbor))
                    {
                        neighborsList.Add(neighbor);
                    }
                }
            }

            return neighborsList;
        }

        private string GetNeighbor(string[,] arr, int row, int col, string currentValue)
        {
            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);
            if (row < 0 || col < 0 || row >= rowLen || col >= colLen || arr[row, col] == currentValue)
            {
                return "";
            }

            return arr[row, col];

        }
    }
}
