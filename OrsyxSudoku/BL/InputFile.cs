using IronXL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsyxSudoku.BL
{
    public class InputFile : IInputFile
    {
        private const int rowCount = 9;
        private const int columnCount = 9;
        private const string basePath = "c:\\temp";

        /// <summary>
        /// Read excel file and take all soduko matrix to a list of matrix
        /// </summary>
        /// <returns></returns>
        public List<int[,]> ReadFile()
        {
            List<int[,]> matrixList = new List<int[,]>();
           
            int currRow = 0;
            int currCol = 0;
            int matrixNum = 0;
            int k = 0;
            int col = 0;
            int startMatrixIdx = 0;
            try
            {
                WorkBook workBook = WorkBook.Load($"{basePath}\\sudoku.xlsx");
                WorkSheet workSheet = workBook.WorkSheets.First();
                matrixList.Add(new int[rowCount, columnCount]);
                for (int i = 0; i < workSheet.RowCount + 1; i++)
                {
                    for (k = currCol; k < workSheet.ColumnCount; k++)
                    {
                        var cell = workSheet.GetCellAt(i, k);
                        var val = cell.Value;
                        if (val != null)
                        {
                            // check if getting to the end of matrix (8,8)
                            if ((currRow != 0 && currRow % (rowCount - 1) == 0) && (currCol != 0 && (currCol + 1) % columnCount == 0))
                            {
                                matrixList.Add(new int[rowCount, columnCount]);
                                matrixNum++;
                                break;
                            }
                            // check if end of matrix row
                            if (currCol != 0 &&  (currCol + 1) % columnCount == 0)
                            {
                                currCol =  startMatrixIdx;
                                col = 0;
                                break;
                            }
                            int[,] mat = matrixList[matrixNum];
                            mat[currRow, col] = Convert.ToInt32(val);
                        }
                        currCol++;
                        col++;

                    }

                    // check if end of row
                    if (currRow != 0 && currRow % (rowCount - 1) == 0)
                    {
                        currRow = 0;
                        currCol++;
                        startMatrixIdx = currCol;
                        i = -1;
                        col = 0;
                        continue;
                    }
                    else
                        currRow++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            return matrixList;
        }
    }
}
