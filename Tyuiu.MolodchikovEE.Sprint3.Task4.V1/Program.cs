using Tyuiu.MolodchikovEE.Sprint3.Task4.V1.Lib;
namespace Tyuiu.MolodchikovEE.Sprint3.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Использование операторов continue и break в циклах                      *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                            *");
            Console.WriteLine("* Выполнил: Молодчиков Егор Евгеньевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*На отрезке, где x принимает значения от -5 до 5, вычислить значение функц*");
            Console.WriteLine("*ции y=sin(x)/x. При х = 0 прервать цикл. Полученные значения суммировать.*");
            Console.WriteLine("*.                                                                        *");

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


            double result = ds.Calculate(x, y);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}