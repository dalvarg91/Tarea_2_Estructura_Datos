// See https://aka.ms/new-console-template for more information

int[,]matriz = new int[5,5];
int valor = 1;
int suma_total = 0;
int suma_esquinas = 0;
int suma_diagonal = 0;

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
        matriz[f,c]= valor++;
        suma_total += matriz[f, c];
        suma_esquinas = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4];
        suma_diagonal = matriz[0, 0] + matriz[0, 4] + matriz[1, 1] + matriz[1, 3] + matriz[2, 2] + matriz[3, 1] + matriz[3, 3] + matriz[4, 0] + matriz[4, 4];
        Console.Write($"  {matriz[f, c]}");
        
    }
    Console.WriteLine();
}
Console.WriteLine("\nLa suma de la matriz es: " + suma_total);
Console.WriteLine("\nLa suma de las esquinas es: " + suma_esquinas);
Console.WriteLine("\nLa suma de las diagonales es: " + suma_diagonal);


