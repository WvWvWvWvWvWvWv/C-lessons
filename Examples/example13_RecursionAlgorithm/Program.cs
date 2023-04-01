                     //
                     Console.Clear();
// string [,] table = new string[2, 5];
// table[1, 2]="слово";

// for ( int rows = 0; rows <2; rows++)
// {
//     for ( int columns = 0; columns<5;columns++)
//     {
//         System.Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }
////////////////////////////////////////////////

// void PrintArray(int[,] matr)
// {
// for (int i = 0 ; i<matr.GetLength(0);i++)
// {
//     for(int j = 0 ; j<matr.GetLength(1); j++)
//     {
//         System.Console.Write($"{matr[i,j]} ");
//     }
//     System.Console.WriteLine();
// }
// }
// void FillArray ( int[,]matr)
// {
//     for (int i = 0; i<matr.GetLength(0);i++)
//     {
//         for (int j = 0; j<matr.GetLength(1);j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int[,] matrix = new int [3,4];
// PrintArray(matrix);
// FillArray(matrix);
// PrintArray(matrix);
////////////////////////////////////////////////


// Факториал

// double Factorial(int n)
// {
//     if(n==1) return 1;
//     else return(n*Factorial(n-1));
// }
// for (int i = 1 ; i< 25 ; i++)
// {
//     System.Console.WriteLine($"{i}! =  {Factorial(i)}");
// }

// System.Console.WriteLine(Factorial(25));

// Фибоначи

// double Fibonachi(int n)
// {
//     if (n==1 || n == 2) return 1;
//     else return Fibonachi(n-1)+Fibonachi(n-2);
// }
// for ( int i= 1 ; i <50;i++)
// {
//     System.Console.WriteLine($"f{i}! = {Fibonachi(i)}");
// }

