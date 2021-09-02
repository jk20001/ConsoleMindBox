using System;

namespace Mindbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            MindBoxLib.MindBoxTest MBT= new MindBoxLib.MindBoxTest();
            Console.WriteLine("Пожалуйста введите радиус круга или стороны треугольника через знак ;");
            string value = Console.ReadLine();  //Вводим строку и добавляем конечную ; для разбивки
            string[] mass = value.Split(';'); //Разбиваем строку по символу ;
            double Answear=0;
        
            if (mass.Length <= 1)
            {
                
                Answear = MBT.CalculateArea(Convert.ToDouble(mass[0]));
                Console.WriteLine("Площадь круга " + Answear);
            }
            else if (mass.Length==3)
            {
                Answear = MBT.CalculateArea(Convert.ToDouble(mass[0]), Convert.ToDouble(mass[1]), Convert.ToDouble(mass[2]));
                Console.WriteLine("Площадь треугольника " + Answear);
                if(MBT.RightAngleByThreeEdges(Convert.ToDouble(mass[0]), Convert.ToDouble(mass[1]), Convert.ToDouble(mass[2])))
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
                else
                {
                    Console.WriteLine("Треугольник не прямоугольный");
                }
            } else
            {
                Console.WriteLine("Вы неправильно ввели значения");
            }

            goto Start;
            
        }
        
      

        

    }
}

