// *Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.*

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int Exponentiation(int numberA, int numberB)
// {
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " +  exponentiation);

//   *Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int a = int.Parse(Console.ReadLine());
//     int s = 0;
//        while (a > 0)
//             {
 
//                 s = s + a % 10;
//                 a = a /10 ;
 
//             }
//  Console.WriteLine("Ответ: "+ s);


// *Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int [] numbers = new int[8];

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 100);
    // Console.Write(" " + Method (i) + " ");
 }

Console.Write('[' + string.Join(", ", numbers) + ']');