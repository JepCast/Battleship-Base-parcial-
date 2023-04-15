int[,] tablero = new int[5, 5];

void paso1_crear_tablero()
{
    for (int f=0; f<tablero.GetLength(0); f++)
    {
        for (int c=0; c<tablero.GetLength(1); c++)
        { tablero[f, c] = 0; }
    }

}

void paso2()
{
    tablero[4, 3] = 1;
    tablero[1, 1] = 1;
    tablero[2, 1] = 1;
    tablero[3, 4] = 1;
}
void paso3()
{
    string caracterA = "";
    for (int i = 0; i < tablero.GetLength(0); i++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            switch (tablero[i, c])
            {
                case 0:
                    caracterA = "-";
                    break;
                case 1:
                    caracterA = "B";
                    break;
                case -1:
                    caracterA = "*";
                    break;
                case -2:
                    caracterA = "X";
                    break;
                default:
                    caracterA = "-";
                    break;
            }
            Console.Write(caracterA + " ");
        }
        Console.WriteLine();
    }
}
void paso4()
{
    int fila, columna = 0;
    Console.Clear();
    do
    {
        Console.Write("Ingresa la fila: ");
        fila = int.Parse(Console.ReadLine());
        Console.Write("Ingresa la columna: ");
        columna = int.Parse(Console.ReadLine());

        if (tablero[fila, columna] == 1)
        {
            Console.Beep();
            tablero[fila, columna] = -1;
        }
        else
        {
            tablero[fila, columna] = -2;
        }
        Console.Clear();
        paso3();
    } while (true);
}
paso1_crear_tablero();
paso2();
paso3();
paso4();