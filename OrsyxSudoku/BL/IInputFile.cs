using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrsyxSudoku.BL
{
    public interface IInputFile
    {
        List<int[,]> ReadFile();
    }
}
