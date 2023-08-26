using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsyxSudoku.BL
{
    public static class Soduko
    {

        /// <summary>
        /// Validate an existing soduko matrix, it checks if there are no duplicates in a row, column, and area.
        /// It is checked by HashSets for the rows, columns and area.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static bool ValidSoduko(int[,] matrix)
        {
            HashSet<int>[] _rows = new HashSet<int>[9];
            HashSet<int>[] _columns = new HashSet<int>[9];
            HashSet<int>[] _areas = new HashSet<int>[9];

            for (int i = 0; i < 9; i++)
            {
                _rows[i] = new HashSet<int>();
                _columns[i] = new HashSet<int>();
                _areas[i] = new HashSet<int>();
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int num = matrix[i,j];
                    if (num == 0)
                        continue;

                    int _area_idx = (i / 3) * 3 + j / 3;

                    if (_rows[i].Contains(num) || 
                        _columns[j].Contains(num) ||
                        _areas[_area_idx].Contains(num))
                        return false;

                    _rows[i].Add(num);
                    _columns[j].Add(num);
                    _areas[_area_idx].Add(num);
                }
            }
            return true;
        }
    }
}
