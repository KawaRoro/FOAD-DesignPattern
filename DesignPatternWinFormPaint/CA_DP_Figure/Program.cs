using System;
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
            Console.WriteLine("-----------Init Without Container Figures-----------");
            Square mySquare = new Square(0,0);
            mySquare.Draw();
            Circle myCircle = new Circle(0,0);
            myCircle.Draw();
            Triangle myTriangle = new Triangle(0,0);
            myTriangle.Draw();
            Ligne myLigne = new Ligne(0, 0);
            myLigne.Draw();

            Figures mySceneFigures = new Figures(0,0);

            mySceneFigures.containerFigures.Add(mySquare);
            mySceneFigures.containerFigures.Add(myCircle);
            mySceneFigures.containerFigures.Add(myTriangle);
            mySceneFigures.containerFigures.Add(myLigne);

            mySceneFigures.Draw();

            Figures mySceneFigures2 = new Figures(0, 0);
            mySceneFigures2.AddFigures("square");
            mySceneFigures2.AddFigures("circle");
            mySceneFigures2.AddFigures("triangle");
            mySceneFigures2.AddFigures("ligne");

            mySceneFigures2.Draw();

            /*foreach (var myFigure in myContainerFigures.GetFigures())
            {
                myFigure.Draw();
            }*/

            Console.ReadLine();
        }
    }
}
