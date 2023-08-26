using OrsyxSudoku.BL;
using Paperless.Test;

namespace OrsyxSudoku.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly IInputFile _inputFile;

        public UnitTest1()
        {
            _inputFile = Helper.GetRequiredService<IInputFile>() ?? throw new ArgumentNullException(nameof(IInputFile));
        }

        [TestMethod]
        public void TestMethod1()
        {
            var matrixList = _inputFile.ReadFile();
            var result = true;
            foreach (var matrix in matrixList)
            {
                if (Soduko.ValidSoduko(matrix))
                {
                    result = false; break;
                };

            }

            Assert.IsTrue(result);
        }
    }
}