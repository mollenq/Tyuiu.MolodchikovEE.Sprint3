using Tyuiu.MolodchikovEE.Sprint3.Task7.V27.Lib;
namespace Tyuiu.MolodchikovEE.Sprint3.Task7.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу, которая выводит таблицу значений функции (произвести *");
            Console.WriteLine("* табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести п*");
            Console.WriteLine("*проверку деления на ноль. При делении на ноль вернуть значение 0. Значени*");
            Console.WriteLine("*ия округлить до двух знаков после запятой.                               *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            var result = ds.GetMassFunction(x,y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}