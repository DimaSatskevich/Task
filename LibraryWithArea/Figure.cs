using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryWithArea
{
    public abstract class Figure
    {
        public string Name { get; set; }
        public Figure(string name)
        {
            Name = name;
        }
        public abstract double Area();
    }

    public class Tringle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Tringle(double a, double b, double c) : base("Треугольник")
        {
            A = a;
            B = b;
            C = c;
        }


        /// <summary>
        /// Метод вычисления площади треугольника по трём сторонам
        /// </summary>
        public override double Area()
        {
            double p = (A + B + C) / 2; // полупериметр треугольника
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool CheckTriangleForSquareness(Tringle tringle)
        {
            bool flag = false;
            if(A > B)
            {
                if(A > C)
                {
                    if(Math.Pow(A,2) == Math.Pow(B,2) + Math.Pow(C, 2))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            else 
            {
                if (B > C)
                {
                    if (Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
                else
                {
                    if(Math.Pow(C, 2) == Math.Pow(B, 2) + Math.Pow(A, 2))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }
    }

    public class Circle : Figure
    {
        public double R { get; set; }

        public Circle(double r) : base("Круг")
        {
            R = r;
        }

        /// <summary>
        /// Метод вычисления площади круга по радиусу
        /// </summary>
        public override double Area()
        {
            return (Math.PI * Math.Pow(R, 2));
        }
    }
    
}
