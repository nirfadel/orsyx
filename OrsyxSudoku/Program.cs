using OrsyxSudoku.BL;

int[,] matrix = new int[9, 9] {
            { 0, 0, 8, 3, 1, 7, 0, 0, 7 },
            { 0, 0, 4, 2, 0, 5, 1, 0, 9 },
            { 0, 0, 0, 0, 4, 0, 0, 7, 0 },
            { 3, 2, 7, 1, 6, 0, 9, 0, 4 },
            { 9, 0, 1, 4, 5, 0, 0, 0, 0 },
            { 0, 4, 5, 7, 0, 0, 8, 0, 0 },
            { 0, 3, 0, 0, 0, 1, 0, 6, 0 },
            { 8, 7, 2, 6, 0, 4, 0, 0, 0 },
            { 4, 1, 6, 0, 7, 0, 0, 8, 0 }
        };

if (Soduko.ValidSoduko(matrix))
    Console.WriteLine("Valid");
else
    Console.WriteLine("Invalid");

Console.Read();
