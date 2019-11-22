using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByCompany
{
    public partial class Design_Program : Form
    {
        public Design_Program()
        {
            InitializeComponent();
        }

        private void Soduku_Fill_Matrix_Click(object sender, EventArgs e)
        {
            var input = new int[,] { { 0, 0, 0, 0,0,0,0,0,0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            Soduku_FillValues(input, 0, 0);
        }

        private void Soduku_FillValues(int[,] matrix, int rowIndex, int colIndex)
        {
            int NUM_ROWS = matrix.GetLength(0);
            int NUM_COLS = matrix.GetLength(1);
            if(rowIndex >= NUM_ROWS)
            {
                //Completed and exiting
                PrintMatrix(matrix);
                return;
            }

            int nextRow = rowIndex;
            int nextCol = colIndex + 1;
            if(nextCol >= NUM_COLS)
            {
                nextCol = 0;
                nextRow = rowIndex + 1;
            }

            // if that row,col is not filled
            if(matrix[rowIndex,colIndex] == 0)
            {
                for(int num = 1; num <= 9; num++)
                {
                    if(CanFillValue(matrix, rowIndex, colIndex, num))
                    {
                        matrix[rowIndex, colIndex] = num;
                        Soduku_FillValues(matrix, nextRow, nextCol);
                    }
                }
                matrix[rowIndex, colIndex] = 0;
            }
            else
            {
                Soduku_FillValues(matrix, nextRow, nextCol);
            }
        }

        private bool CanFillValue(int[,] matrix, int row, int col, int value)
        {
            int NUM_ROWS = matrix.GetLength(0);
            int NUM_COLS = matrix.GetLength(1);

            // Validating Columns
            for(int i=0;i<NUM_COLS; i++)
            {
                if(matrix[row, i] == value)
                    return false;
            }

            //validating Rows
            for(int i=0; i<NUM_ROWS; i++)
            {
                if (matrix[i, col] == value)
                    return false;
            }

            //validating 3X3 matrix
            int regionStartRow = (row / 3) * 3;
            int regionStartCol = (col / 3) * 3;

            for(int i = regionStartRow; i<regionStartRow+3;i++)
            {
                for(int j = regionStartCol; j < regionStartCol + 3; j++)
                {
                    if (matrix[i, j] == value)
                        return false;
                }
            }

            return true;
        }

        private void PrintMatrix(int[,] matrix)
        {
            for(int i = 0; i<matrix.GetLength(0);i++)
            {
                for(int j = 0; j <matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "    ");
                }
                Console.WriteLine();
            }
        }

        private void Soduku_Validate_Click(object sender, EventArgs e)
        {
            var input = new int[,] { 
                { 5, 3, 0, 0, 7, 0, 0, 0, 0 }, 
                { 6, 0, 0, 1, 9, 5, 0, 0, 0 }, 
                { 0, 9, 8, 0, 0, 0, 0, 6, 0 }, 
                { 8, 0, 0, 0, 6, 0, 0, 0, 3 }, 
                { 4, 0, 0, 8, 0, 3, 0, 0, 1 }, 
                { 7, 0, 0, 0, 2, 0, 0, 0, 6 }, 
                { 0, 6, 0, 0, 0, 0, 2, 8, 0 }, 
                { 0, 0, 0, 4, 1, 9, 0, 0, 5 }, 
                { 0, 0, 0, 0, 8, 0, 0, 7, 9 } };
            var res = ValidateSudoku_Matrix(input);
            var x = res;
        }

        private bool ValidateSudoku_Matrix(int[,] matrix)
        {
            for(int i = 0; i<9; i++)
            {
                var row = new HashSet<int>();
                var col = new HashSet<int>();
                var sub = new HashSet<int>();
                for(int j = 0; j < 9; j++)
                {
                    if (matrix[j, i] != 0 && row.Contains(matrix[j,i]))
                        return false;
                    row.Add(matrix[j,i]);

                    if (matrix[i, j] != 0 && col.Contains(matrix[i, j]))
                        return false;
                    col.Add(matrix[i, j]);

                    var x = (i % 3) * 3 + j % 3;
                    var y = (i / 3) * 3 + j / 3;
                    if (matrix[x, y] != 0 && sub.Contains(matrix[x, y]))
                        return false;
                    sub.Add(matrix[x, y]);
                }
            }
            return true;
        }
    }
}
