using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Accord;
using CA_DP_Figure;
using CL_DP_Figure;

namespace CA_DP_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point myPoint = new Point(0, 0);
            Point myPointInMiddle = new Point(5, 5);
            Point myPointInTop = new Point(10, 10);
            double myRadius = 6.2;
            //myPoint = new Point(myPointInMiddle);

            Console.WriteLine("-----------Init Without Container Figures-----------");
            Square mySquare = new Square(myPoint, 2.5, 3.6); // Square(Point _point, double _height, double _width)
            mySquare.Draw();
            Circle myCircle = new Circle(myPoint, myRadius); // Circle(Point _point, double _radius)
            myCircle.Draw();
            Triangle myTriangle = new Triangle(myPoint , myPointInMiddle, myPointInTop); // Triangle(Point _point, Point _point2, Point _point3)
            myTriangle.Draw();
            Ligne myLigne = new Ligne(myPoint, myPointInMiddle); // Ligne(Point _point, Point _point2)
            myLigne.Draw();

            // Add a new Area
            Figures myAreaFigures = new Figures(myPoint); // 0,0

            myAreaFigures.containerFigures.Add(mySquare);
            myAreaFigures.containerFigures.Add(myCircle);
            myAreaFigures.containerFigures.Add(myTriangle);
            myAreaFigures.containerFigures.Add(myLigne);

            myAreaFigures.Draw();

            Console.WriteLine("-----------Main Container Figures-----------");
            
            // Add a group of figure :
            Figures myAreaFigures2 = new Figures(0, 0);
            myAreaFigures2.CreateFiguresOneItem("square"); // = myAreaFigures.containerFigures.Add(mySquare);
            myAreaFigures2.CreateFiguresOneItem("square");
            myAreaFigures2.CreateFiguresOneItem("square");
            myAreaFigures2.CreateFiguresOneItem("square");

            //myAreaFigures2.Draw();

            myAreaFigures.containerFigures.Add(myAreaFigures2);

            myAreaFigures.Draw();

            Console.WriteLine("-----------Movements Container Figures-----------");

            Figures myAreaFigures3 = new Figures(0, 0);

            myAreaFigures3.AddFigure(mySquare);
            myAreaFigures3.AddFigure(myCircle);
            myAreaFigures3.AddFigure(myTriangle);
            myAreaFigures3.AddFigure(myLigne);

            myAreaFigures3.MoveFigure(mySquare, myPointInMiddle);
            myAreaFigures3.MoveFigure(myCircle, 2, 2);
            myAreaFigures3.MoveFigure(myTriangle, 3, 3);
            myAreaFigures3.MoveFigure(myLigne, 4, 4);
            myAreaFigures3.Draw();

            //Console.WriteLine("-----------SelfRemove Container in Figures-----------");
            // Remove all items in Figures
            //myAreaFigures3.SelfRemoveFigures();
            // Check view
            //myAreaFigures3.Draw();

            Console.WriteLine("-----------Add a LINE in Container in Figures-----------");
            myAreaFigures3.AddFigure(myLigne);
            myAreaFigures3.Draw();

            Console.WriteLine("-----------Delete a LINE in Container in Figures-----------");
            myAreaFigures3.DeleteFigure(myLigne);
            myAreaFigures3.Draw();

            Console.WriteLine("-----------Get Figure in Container in Figures-----------");

            Figure myFigureInFirst = myAreaFigures3.GetFigure(myPointInMiddle);
            Console.WriteLine(myFigureInFirst);
            myAreaFigures3.Draw();

            Console.ReadLine();

        }
    }
}
