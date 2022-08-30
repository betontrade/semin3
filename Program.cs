// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

*/




//_________________________Домашняя работа___________________________

//_________________________Задание_1_________________________________

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



int DlinnaChisla (int n)// вычисление количества символов в числе
{
    int i;

    int count = n; // вычисление длинны числа
    for (i = 1; count >= 10; i++)
    {
    count = count / 10;
    }
return i;
}


Console.Write("Пожалуйста введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); // ввод числа

int dlinna = DlinnaChisla (num); // длинна числа


void YesOrNo (int dannie)
{
    for (int i = 1; i <=dlinna/2; i++)
    {
        int delitel = Convert.ToInt32(Math.Pow(10, dlinna-i ));

        int pervak = (num / delitel ) % 10; 

        int procentor = Convert.ToInt32(Math.Pow(10, i ));

        int delzerk = Convert.ToInt32(Math.Pow(10, i-1 ));

        int zerkalnoe = (num % procentor ) / delzerk ;

        if (pervak != zerkalnoe) // если сравниваемые числа не равны
        {
            Console.WriteLine( num+ " -> нет");
            break;
        }

        if (i == dlinna / 2 ) // если вообще все сравниваемые числа равны
        {
            Console.WriteLine( num+ " -> да");
        }
    }
}

YesOrNo(num);





//_________________________________Задание_2___________________________


