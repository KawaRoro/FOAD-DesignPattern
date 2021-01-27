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
            Square mySquare = new Square(1,1);
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
            mySceneFigures2.CreateFiguresOneItem("square");
            mySceneFigures2.CreateFiguresOneItem("square");
            mySceneFigures2.CreateFiguresOneItem("square");
            mySceneFigures2.CreateFiguresOneItem("square");

            mySceneFigures2.Draw();

            mySceneFigures.containerFigures.Add(mySceneFigures2);

            mySceneFigures.Draw();

            Console.WriteLine("-----------Movements Container Figures-----------");

            Figures mySceneFigures3 = new Figures(0, 0);

            if (mySceneFigures3.AddFigure(myLigne))
            {
                mySceneFigures3.MoveFigure(myLigne, 2, 2);
                mySceneFigures3.Draw();
            }

            if (mySceneFigures3.DeleteFigure(myLigne))
            {
                mySceneFigures3.Draw();
            }
            else
            {
                Console.WriteLine("Marche po");
            }

            /*if (mySceneFigures3.SelfRemoveAllItemsInFigures(mySceneFigures3))
            {
                //mySceneFigures3.Draw();
            }*/



            /*foreach (var myFigure in myContainerFigures.GetFigures())
            {
                myFigure.Draw();
            }*/

            Console.ReadLine();
        }
    }
}
