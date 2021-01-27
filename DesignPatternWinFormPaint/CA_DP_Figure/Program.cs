﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CA_DP_Figure;
using CL_DP_Figure;

namespace CA_DP_Figure
{
    class Program
    {
        static void Main(string[] args)
        {

            Square mySquare = new Square(0,0);
            mySquare.Draw();
            Circle myCircle = new Circle(0,0);
            myCircle.Draw();
            Triangle myTriangle = new Triangle(0, 0);
            myTriangle.Draw();

            Figures myContainerFigures = new Figures(0, 0);

            /*foreach (var Figure in myContainerFigures)
            {
                Figure.Draw();
            }*/

            Console.ReadLine();
        }
    }
}
