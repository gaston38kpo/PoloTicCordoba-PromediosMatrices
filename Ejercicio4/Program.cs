//////////////////////////////////
//      CLASE 8 - TAREA 3       //
// ALUMNO:  GIACOBINI GASTON    //
// FECHA:   19/05/2022          //
//////////////////////////////////

Console.Title = "PoloTic Cordoba - Tarea 3 - GIACOBINI GASTÓN 2022 - v1.0";
Console.BufferHeight = Console.WindowHeight = 33;
Console.BufferWidth = Console.WindowWidth = 100;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@"
                       █▀▀ ▄█  █▀▀ ▀█
                       █▄▄ ░█  █▄▄ █▄  █  █  █  █
   
                   ░░░░░░                          ░░░░░░
                   ░░                                  ░░
          █▀▀ ▄█   ░░        ▓▓      ▓▓      ▓▓        ░░
          █▀░ ░█   ░░        ▓▓      ▓▓      ▓▓        ░░
                   ░░  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ░░
          █▀▀ ▀█   ░░        ▓▓      ▓▓      ▓▓        ░░
          █▀░ █▄   ░░        ▓▓      ▓▓      ▓▓        ░░
                   ░░  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ░░
              ██   ░░        ▓▓      ▓▓      ▓▓        ░░
                   ░░        ▓▓      ▓▓      ▓▓        ░░
              ██   ░░  ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓  ░░
                   ░░        ▓▓      ▓▓      ▓▓        ░░
              ██   ░░        ▓▓      ▓▓      ▓▓        ░░
                   ░░                                  ░░
              ██   ░░░░░░                          ░░░░░░");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@"

                 █▀█ █▀█ █▀█ █▀▄▀█ █▀▀ █▀▄ █ ▄▀█   ▀█▀ █░█
                 █▀▀ █▀▄ █▄█ █░▀░█ ██▄ █▄▀ █ █▀█   ░█░ █▄█
                 
                           █▀▄▀█ ▄▀█ ▀█▀ █▀█ █ ▀█
                           █░▀░█ █▀█ ░█░ █▀▄ █ █▄
");
Console.ResetColor();
Console.Write("Filas ↓ : ");
int rows = int.Parse(s: Console.ReadLine());
Console.Write("Columnas → : ");
int columns = int.Parse(Console.ReadLine());

int[,] numbers = new int[rows, columns];

double[] averages = new double[columns];


Console.Clear();
Console.WriteLine($"Complete la matriz de {rows}x{columns}:\n");
for (int row = 0; row < rows; row++)
{
    Console.WriteLine($"Fila {row}");
    for (int column = 0; column < columns; column++)
    {
        Console.Write($"\tColumna {column}: ");
        numbers[row, column] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine();
}


Console.Clear();
Console.WriteLine($"\nMatriz de {rows}x{columns}:\n       {{");
for (int row = 0; row < rows; row++)
{
    Console.Write("\t{");
    for (int column = 0; column < columns; column++)
    {    
        Console.ForegroundColor = (column % 2 == 0) ? ConsoleColor.DarkCyan : ConsoleColor.Magenta;

        Console.Write($"{numbers[row, column]}{(column + 1 < columns ? ",\t" : "")}");    

        Console.ResetColor();
    }
    Console.WriteLine("},");
}
Console.WriteLine("       }");


Console.WriteLine("\n Promedios de cada columna:");

for (int column = 0; column < columns; column++)
{
    double totalColumn = 0;

    for (int row = 0; row < rows; row++)
    {
        totalColumn += numbers[row, column];
    }
    averages[column] = totalColumn / rows;
}

Console.Write("\t{");
for (int average = 0; average < averages.Length; average++)
{
    Console.ForegroundColor = (average % 2 == 0) ? ConsoleColor.DarkCyan : ConsoleColor.Magenta;
    Console.Write($"{ Math.Round(averages[average], 2)}{(average + 1 < averages.Length ? ",\t" : "")}");
    Console.ResetColor();
}
Console.WriteLine("}");


/*
// ========= VERSION CODEANDO PUNTO POR PUNTO ========= //

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
int[,] numbers;


//2) Determinar el tamaño de cada dimension (fila, columnas) mediante valores ingresados por pantalla
Console.WriteLine("Cuantas filas y columnas querrá la matriz?.");
Console.Write("Cuantas filas?: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Cuantas Columnas?: ");
int columns = int.Parse(Console.ReadLine());

numbers = new int[rows, columns];

//3) Declarar un vector de tipo double llamado promedios
double[] averages;


//4) Recorrer la matriz para su carga con elementos de tipo int
Console.WriteLine("CARGA DE LA MATRIZ");
for (int row = 0; row < rows; row++)
{
    for (int column = 0; column < columns; column++)
    {        
        numbers[row, column] = int.Parse(Console.ReadLine());        
    }
}


//5) Recorrer la matriz para mostrar cada valor de la matriz
Console.WriteLine($"\nMatriz de {rows}x{columns}:\n");
for (int row = 0; row < rows; row++)
{
    Console.Write("\t[");
    for (int column = 0; column < columns; column++)
    {
        Console.Write($"{numbers[row, column]}\t");
    }
    Console.WriteLine("],");
}


//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
Console.WriteLine("\n Promedios:");

averages = new double[columns];

for (int column = 0; column < columns; column++)
{
    double totalColumn = 0;
    
    for (int row = 0; row < rows; row++)
    {        
        totalColumn += numbers[row, column];
    }
    averages[column] = totalColumn / rows;
}


//7) Mostrar los promedios recorriendo el vector promedios
Console.WriteLine($"\t" + string.Join("\t", averages));

// Ejemplo matriz 3f x 3c
 
//{   c0   c1  c2
//f0  {11, 12, 13},
//f1  {22, 23, 24},
//f2  {33, 34, 35}
//}

 */
