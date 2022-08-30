
//_________________________Домашняя работа___________________________


//_________________________Задание_1_________________________________

 /*

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

*/



//_________________________________Задание_2___________________________

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*

double Proekcia (double xA, double yA, double zA, double xB, double yB, double zB) // создание проекции 
// и треугольника на минимальной точке y (на плоскости XZ)
{
    double ac   = yA - yB ;
    double bc  = Math.Sqrt ((xA - xB) * (xA - xB) + (zA - zB)*(zA - zB));
    double ab  = Math.Sqrt ((ac*ac) + (bc*bc));
    return ab;
}


Console.Write("Введите пожалуйста координату Х точки А: ");
double xxA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите пожалуйста координату Y точки А: ");
double yyA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите пожалуйста координату Z точки А: ");
double zzA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите пожалуйста координату Х точки B: ");
double xxB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите пожалуйста координату Y точки B: ");
double yyB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите пожалуйста координату Z точки B: ");
double zzB = Convert.ToDouble(Console.ReadLine());

double resultat = Proekcia(xxA, yyA, zzA, xxB, yyB, zzB);

Console.WriteLine(" ");
Console.WriteLine($" -> {resultat}");
Console.WriteLine(" ");
Console.WriteLine("Конец программы.");

*/


//_________________________________Задание_3___________________________


/*

Console.Write("Пожалуйста введите число: ");
double num1 = Convert.ToDouble( Console.ReadLine());

void Res (double chislo)
{
    for (int i = 1; i<=num1; i++) 
    {
    double resul = Math.Pow(i, 3);
    if (resul != Math.Pow(num1, 3))
    {
        Console.Write(resul+ ", ");
    }
    else
    {
        Console.Write(resul+ " ");
    }
    }
}

Res(num1);

Console.WriteLine("");

*/
