//********************************************************
//*Практическая работа №6                                *
//* Выполнил:Кондаков.П.А,Группа 2ИСП                    *
//*Задание:составить программу работы алгоритма ветвления*
//********************************************************
using System;

namespace PR_5
 {  
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int x1,x2,y1,y2,AO,BO,x=0,y=0;// объявление переменных
            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Практическая работа №5");
            Console.Write("Введите координаты двух точек: \n");
           try
           { 
            Console.Write("x1= ");//Ввод данных
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2= ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1= ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2= ");
            y2 = Convert.ToInt32(Console.ReadLine());


            AO = (int)Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));//расчет длины отрезка
            BO = (int)Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));
            Console.WriteLine("Длина отрезка AO:");
            Console.WriteLine(AO);
            Console.WriteLine("Длина отрезка BO:");
            Console.WriteLine(BO);
            switch (AO < BO)
            {
               case (true):
                        {    
                Console.WriteLine("Точка B находиться ближе к началу координат");break;
                        }
                        case(false):
                        { 
                            switch(AO > BO)
                            { 
                             case(true): Console.WriteLine("Точка A находиться ближе к началу координат");break;
                              case(false):Console.WriteLine("Точки находятся равноудаленно");break;
                            
                            }
             
                        }
             break;

            }
           }      
            catch (Exception e)//обработка ошибок
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Что-то пошло не так.Ошибка:" + e.Message);
            }
           
                          
                                 
            Console.ReadKey();
        
    

        }
    }
}