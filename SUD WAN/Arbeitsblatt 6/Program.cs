Console.WriteLine("Aufgabenblatt 6");
Ausfueren();

void Ausfueren()
{
    int[,] matrixA = MatrixErstellen("Bitte Matrix A eingaben");
    MatrixAusgeben(matrixA, "A");
    int[,] matrixAVertauscht = MatrixVertauschen(matrixA);
    MatrixAusgeben(matrixAVertauscht, "A Vertauscht");
    int[,] matrixB = MatrixErstellenMitFestenParametern(matrixA.GetLength(0), matrixA.GetLength(1), "Bitte Matrix B eingeben");
    MatrixAusgeben(MatrixVerrechnen(matrixA, matrixB), "Matrix C:");
}

int IntAusKonsole(string nachricht, string fehlermeldung)
{
    int zahl;
    bool isValid = false;

    do
    {
        Console.WriteLine(nachricht);
        if (int.TryParse(Console.ReadLine(), out zahl))
        {
            isValid = true;
        }
        else
        {
            Console.WriteLine(fehlermeldung);
        }
    } while (!isValid);
    return zahl;
}

int[,] MatrixErstellen(string beschreibung)
{
    Console.WriteLine(beschreibung);
    int m = IntAusKonsole("Bitte Anzahl von Zeilen eingeben", "Bitte Ganzzahlige Zahl eingeben");
    int n = IntAusKonsole("Bitte Anzahl von Spalten eingeben", "Bitte Ganzzahlige Zahl eingeben");
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = IntAusKonsole($"Zeile {i + 1}, Spalte {j + 1} eingeben;", "falsche Eingabe");
        }
    }
    Console.WriteLine();
    return matrix;
}
int[,] MatrixErstellenMitFestenParametern(int m, int n, string beschreibung)
{
    Console.WriteLine(beschreibung);
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = IntAusKonsole($"Zeile {i + 1}, Spalte {j + 1} eingeben;", "falsche Eingabe");
        }
    }
    Console.WriteLine();
    return matrix;

}

void MatrixAusgeben(int[,] matrix, string name)
{
    Console.Write("Matrix: " + name + "\n");

    int format = (matrix.Cast<int>().Max().ToString().Length + 2) * -1;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write("{0, " + format + "}", matrix[m, n]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixVertauschen(int[,] matrix)
{
    int[,] vertauschteMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            vertauschteMatrix[n, m] = matrix[m, n];
        }

    }
    return vertauschteMatrix;
}

int[,] MatrixVerrechnen(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixSumme = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int m = 0; m < matrixA.GetLength(0); m++)
    {
        for (int n = 0; n < matrixA.GetLength(1); n++)
        {
            matrixSumme[m, n] = matrixA[m, n] + matrixB[m, n];
        }

    }
    return matrixSumme;
}