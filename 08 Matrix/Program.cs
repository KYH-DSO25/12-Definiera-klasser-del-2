/*
*   8.  Definiera en klass Matrix<T> som håller en matris av tal (t. ex.
*       heltal, flyttal och decimaltal)
*   
*   9.  Implementera en indexerare this[ row , col ] för åtkomst av
*       matrisens celler.
*       
*   10. ** Implementera operatorerna + och – (addition och subtraktion av
*       matriser av samma storlek) och * för matrismultiplikation. Kasta ett
*       undantag när operationen inte kan utföras. Implementera operatorn
*       true (kolla efter element som inte är noll)
*/
using Multidimensional.Arrays;

class Program
{
    static readonly Random rnd = new Random();

    static void Main()
    {
        var matrix1 = new Matrix<int>(3, 3,
            1, 2, 0,
            0, 1, 1,
            2, 0, 1);

        var matrix2 = new Matrix<int>(3, 3);

        for (uint row = 0; row < matrix2.Rows; row++)
            for (uint col = 0; col < matrix2.Columns; col++)
                matrix2[row, col] = rnd.Next(10);

        Console.WriteLine("First Matrix ({0}x{1}) is:", matrix1.Rows, matrix1.Columns);
        Console.WriteLine(matrix1);

        Console.WriteLine("Second Matrix ({0}x{1}) is:", matrix2.Rows, matrix2.Columns);
        Console.WriteLine(matrix2);

        Console.WriteLine("Accumulation of the Matrices:");
        Console.WriteLine(matrix1 + matrix2);

        Console.WriteLine("Subtraction of the Matrices:");
        Console.WriteLine(matrix1 - matrix2);

        Console.WriteLine("Multiplication of the Matrices:");
        Console.WriteLine(matrix1 * matrix2);

        Console.WriteLine("First matrix: {0}", matrix1 ? "Non-empty!" : "Empty!");
        Console.WriteLine("New matrix: {0}\n", new Matrix<double>(1, 1) ? "Non-empty!" : "Empty!");
    }
}