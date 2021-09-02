using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxLib
{

    
    public class MindBoxTest
    {
        /// <summary>
        /// Возвращает площадь круга по радиусу при задании одного параметра (радиуса круга) и площадь треугольника при задании трех параметров (длин сторон треугольника)
        /// </summary>
        /// <param name="Radius"></param>
        /// <returns> Площадь фигуры </returns>
        /// 
        public double CalculateArea(double Radius) //Функция расчета площади круга через радиус
        {
            return Math.Round((Math.Pow(Radius, 2) * Math.PI),10);
        }




        /// <summary>
        /// Возвращает площадь круга по радиусу при задании одного параметра (радиуса круга) и площадь треугольника при задании трех параметров (длин сторон треугольника)
        /// </summary>
        /// <param name="EdgeA"></param>
        /// <param name="EdgeB"></param>
        /// <param name="EdgeC"></param>
        /// <returns></returns>
        /// 
        public double CalculateArea(double EdgeA, double EdgeB, double EdgeC)//Функция расчета площади квадрата по трем сторонам
        {
            double p = ((EdgeA + EdgeB + EdgeC) / 2);
            return Math.Round(Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC)),10);
        }




        /// <summary>
        /// Определяет является ли треугольник прямоугольным по трем его сторонам и возвращает bool
        /// </summary>
        /// <param name="EdgeA"></param>
        /// <param name="EdgeB"></param>
        /// <param name="EdgeC"></param>
        /// <returns></returns>
        public bool RightAngleByThreeEdges(double EdgeA, double EdgeB, double EdgeC)// Функция определяющая является ли треугольник прямоугольным
        { bool right = false;
            double BiggestEdge = FindBiggestEdgeOfTriangle(EdgeA, EdgeB, EdgeC);
            if (BiggestEdge== EdgeA)
            {
                right= Math.Pow(EdgeA,2) == Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2);
            } 
            else if(BiggestEdge == EdgeB)
            {
                right = Math.Pow(EdgeB, 2) == Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2);
            }
            else
            {
                right = Math.Pow(EdgeC, 2) == Math.Pow(EdgeB, 2) + Math.Pow(EdgeA, 2);
            }
            return right;
        }





        /// <summary>
        /// Возвращает длину наибольшей стороны треугольника
        /// </summary>
        /// <param name="EdgeA"></param>
        /// <param name="EdgeB"></param>
        /// <param name="EdgeC"></param>
        /// <returns></returns>
        public double FindBiggestEdgeOfTriangle(double EdgeA, double EdgeB, double EdgeC)// Функция определяющая длину наибольшей стороны треугольника
        {
            
            double BiggestEdge = 0;
            if (EdgeA > BiggestEdge) BiggestEdge = EdgeA;
            if (EdgeB > BiggestEdge) BiggestEdge = EdgeB;
            if (EdgeC > BiggestEdge) BiggestEdge = EdgeC;
            return BiggestEdge;
        }


    }
}
