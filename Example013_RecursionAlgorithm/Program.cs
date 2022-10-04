// string[,] table = new string[2, 5];//2 строки 5 столбцов
// //table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// //индексы столбцов
// //] table[1,0] table[1,1] table[1,2] table[1,4]
// table [1, 2] = "слово";
// for (int rows =0; rows<2; rows++)
// {
//     for(int columns = 0; columns<5; columns++)
//     {
//         Console.WriteLine($" {table[rows, columns]} ");
//     }
// }
//в этом примере показали как вывести "слово" в нужном месте, сейчас пробую с
//числами






    // int[,]matrix =  new int [3,4];
// for (int i =0;i<3; i++)//цикл щелкает строки
// {             //выше вместо <3 можно указать matrix.GetLength(1)
//                 //указывает на первую строчку int [3]
//     for (int j =0;j<4; j++)
//     {            // вместо <4 matrix.GetLength(2)
//                     //укажет на первую строку int[4]
//         Console.Write($"{matrix[i,j]} ");//выводим числа через пробел
//     }
//     Console.WriteLine(); //следующую строку принудительно выводим на новой строке 
// }
// //в результате видим
// //0 0 0 0
// //0 0 0 0
// //0 0 0 0
// //0 0 0 0


// // //теперь вышеуказанную мтарицу заполним случайными числами
// // //создаем метод

// void PrintArray(int[,] matr)
// {
//     for (int i =0; i< matr.GetLength(0); i++)
//     {
//         for (int j =0; j< matr.GetLength(1); j++) 
//         {
//           Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// int[,]matrix =  new int [3, 4];
// //на печать выведем матрицу определенную строкой выше
// PrintArray(matrix);



// // теперь опишем дополнительный метод который заполнит 
// //нашу матрицу случ числами
// void PrintArray(int[,] matr)
// {
//     for (int i =0; i< matr.GetLength(0); i++)
//     {
//         for (int j =0; j< matr.GetLength(1); j++) 
//         {
//           Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }
// void FillArray(int[,] matr)
// {
//     for (int i =0; i< matr.GetLength(0); i++)
//     {
//         for (int j =0; j< matr.GetLength(1); j++) 
//         {
//             matr[i,j]= new Random().Next(1,10);
//         }
//     }
// }

// int[,]matrix =  new int [3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();//пробел между строками
// PrintArray(matrix);
// //на экране видим 
// // 0 0 0 0
// // 0 0 0 0
// // 0 0 0 0

// // 5 7 1 2
// // 2 4 5 9
// // 9 7 5 1






// void PrintArray(int[,] image)
// {
// for (int i =0; i< image.GetLength(0); i++)
// // вместо
// //for (int i = 0; i < 3; i++)
// {//for (int j =0; j< matrix.GetLength(1); j++)
//     for (int j = 0; j < 4; j++)
//     {
//         Console.Write($"{image[i, j]} ");//сделали вывод чисел через пробел
//     //а когда пробежится по всем числам
//     }
//     //сделаем переход на новую строку
//     Console.WriteLine();
// }
// }
// void FillArray(int[,] ima)
// {
//     for (int i =0; i< ima.GetLength(0); i++)
//     {
//         for (int j =0; j< ima.GetLength(1); j++) 
//         {
//             image[i,j]= new Random().Next(1,10);
//         }
//     }
// }

// int [,] image = new int[3, 4];
// PrintArray(im);
// // FillArray(imag);
// Console.WriteLine();
// PrintArray(im);



//Двумерные массивы

// int[,] pic = new int[,]

// {//единицами в массиве нарисовано сердце, говорим чтоб вместо нулей печатал
// //пробел и напечатал только единицы
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
// {0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0},
// {0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0},
// {0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 0},
// {0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0},
// {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
// {0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
// {0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0},
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
// };
// void PrintImage(int[,] image)
// {
//     for (int i =0; i< image.GetLength(0); i++)
//     {
//         for (int j =0; j< image.GetLength(1); j++) 
//         {
//             if (image[i,j]==0) Console.Write($" ");//заменили нули пробелами
//             else Console.Write($"+");//единицы плюсами
//             //image[i,j]= new Random().Next(1,10);
//         }
//        Console.WriteLine(); 
//     }
// }
// //теперь создаем метод который закрашиваетсердце(FillImage)
// //сначала указываем координаты точки, с которой начнем закрашивать 7 ряд 6 знак
// void FillImage (int row, int col)
// {
//     if (pic [row, col] == 0)
//     {
//         pic [row, col]=1;
//         FillImage(row-1, col);
//         FillImage(row, col-1);
//         FillImage(row+1, col);
//         FillImage(row, col+1);
//     }

// }

// PrintImage(pic);//сначала вывеет контур
// FillImage(7,6);//выбрали любую точку внутри
// PrintImage(pic); //выведет заполненную фигуру





// //Напишем метод который будет принимать число, факториал которого необходимо вычислить
// int Factorial (int n)
// {
//     //1! ==1
//     //0! ==1
//     if (n==1) return 1;
//     else return (n * Factorial(n-1));
// }

// Console.WriteLine(Factorial(3));// факториал 3 = 1х2х3=6
// // вычислили факториал числа




// возьмем цикл чтобы вычислить факториалы маасива данных от 1 до 40
// int Factorial (int n)
// {
//     //1! ==1
//     //0! ==1
//     if (n==1) return 1;
//     else return (n * Factorial(n-1));
// }

// for (int i=1; i<40; i++)
// Console.WriteLine($"{i}! = {Factorial(i)}"); // просим расписать каждуюс строчку
// в результ видим что значения с минусом и потом вообще ноль, переполнение бызы
// но есть тип данных которые базе переварит меняем int на double



// double Factorial (double n)
// {
//     //1! ==1
//     //0! ==1
//     if (n==1) return 1;
//     else return (n * Factorial(n-1));
// }

// for (double i=1; i<40; i++)
// Console.WriteLine($"{i}! = {Factorial(i)}");
// получили положительные числа Е+29 означает что полученное число нужно 
//умножить на 10 в степени 29





//Поищем число фибоначи:
//f(1)=1
//f(2)=1
//f(n)=f(n-1)+f(n-2)

// int Fibo(int n)
// {
//     if (n==1 || n==2) return 1;//если число 1 или 2 нам вернет единицу
//     else  return Fibo(n-1)+ Fibo(n-2);//в другом случае вернет другой рез
// }
// for(int i=1;i<10; i++) // взяли первые 10 чисел
// {
//     Console.WriteLine(Fibo(i));
// }

// // получили числа теперь если число гораздо больше используем дабл:





// double Fibo(int n)
// {
//     if (n==1 || n==2) return 1;//если число 1 или 2 нам вернет единицу
//     else  return Fibo(n-1)+ Fibo(n-2);//в другом случае вернет другой рез
// }
// for(int i=1;i<50; i++) // взяли первые 50 чисел
// {
//     Console.WriteLine(Fibo(i));
// }
//тут мы видим что примерно на 40 числе система начала очень тормозить





