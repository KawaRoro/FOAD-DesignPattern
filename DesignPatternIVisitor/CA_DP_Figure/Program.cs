﻿using System;
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
            // Define points to use later
            Point myPoint = new Point(0, 0);
            Point myPointInMiddle = new Point(5, 5);
            Point myPointInTop = new Point(10, 10);
            double myRadius = 6.2;

            var random = new Random();
            Point myRandomPoint = new Point(random.Next(), random.Next());
            Point myRandomPoint2 = new Point(random.Next(), random.Next());
            Console.WriteLine(myRandomPoint);
            Console.WriteLine(myRandomPoint2);
            //myPoint = new Point(myPointInMiddle);

            // Init Without Container Figures
            Console.WriteLine("-----------Init Without Container Figures-----------");
            Square mySquare = new Square(myPoint, 2.5, 3.6); // Square(Point _point, double _height, double _width)
            mySquare.AcceptVisitor(new VisiteurForConsole());
            
            Circle myCircle = new Circle(myPoint, myRadius); // Circle(Point _point, double _radius)
            myCircle.AcceptVisitor(new VisiteurForConsole());

            Triangle myTriangle = new Triangle(myPoint , myPointInMiddle, myPointInTop); // Triangle(Point _point, Point _point2, Point _point3)
            myTriangle.AcceptVisitor(new VisiteurForConsole());

            Ligne myLigne = new Ligne(myPoint, myPointInMiddle); // Ligne(Point _point, Point _point2)
            myLigne.AcceptVisitor(new VisiteurForConsole());

            Console.WriteLine("-----------Init with Main Container Figures-----------");
            // Add a new Area
            Figures myAreaFigures = new Figures(myPoint); // 0,0

            myAreaFigures.containerFigures.Add(mySquare);
            myAreaFigures.containerFigures.Add(myCircle);
            myAreaFigures.containerFigures.Add(myTriangle);
            myAreaFigures.containerFigures.Add(myLigne);

            //myAreaFigures.Draw();
            myAreaFigures.AcceptVisitor(new VisiteurForConsole());

            Console.WriteLine("-----------ADD a Group of Square in Main Container Figures-----------");
            
            // Add a group of figure :
            Figures myAreaFigures2 = new Figures(0, 0);
            myAreaFigures2.CreateFiguresOneItem("square"); // = myAreaFigures.containerFigures.Add(mySquare);
            myAreaFigures2.CreateFiguresOneItem("square");
            myAreaFigures2.CreateFiguresOneItem("square");
            myAreaFigures2.CreateFiguresOneItem("square");

            //myAreaFigures2.Draw();
            myAreaFigures2.AcceptVisitor(new VisiteurForConsole());

            myAreaFigures.containerFigures.Add(myAreaFigures2);

            //myAreaFigures.Draw();
            myAreaFigures.AcceptVisitor(new VisiteurForConsole());

            Console.WriteLine("-----------Movements X and y in Container Figures-----------");

            Figures myAreaFigures3 = new Figures(0, 0);

            myAreaFigures3.AddFigure(mySquare);
            myAreaFigures3.AddFigure(myCircle);
            myAreaFigures3.AddFigure(myTriangle);
            myAreaFigures3.AddFigure(myLigne);

            myAreaFigures3.MoveFigure(mySquare, myPointInMiddle);
            if (myAreaFigures3.MoveFigure(myCircle, new Point(random.Next(int.MinValue, int.MaxValue), random.Next(int.MinValue, int.MaxValue))))
            {
                Console.WriteLine("-----------Movements ok-----------");
            }
            else
            {
                Console.WriteLine("-----------Movements not ok-----------");
            }
            myAreaFigures3.MoveFigure(myTriangle, new Point(random.Next(int.MinValue, int.MaxValue), random.Next(int.MinValue, int.MaxValue)) );
            myAreaFigures3.MoveFigure(myLigne, new Point(random.Next(int.MinValue, int.MaxValue), random.Next(int.MinValue, int.MaxValue)) );

            myAreaFigures3.AcceptVisitor(new VisiteurForConsole());

            Console.WriteLine("-----------SelfRemove Container in Figures-----------");
            // Remove all items in Figures
            myAreaFigures3.SelfRemoveFigures();
            // Check view
            myAreaFigures3.AcceptVisitor(new VisiteurForConsole());

            Console.WriteLine("-----------Add a LINE in Container in Figures-----------");
            myAreaFigures3.AddFigure(myLigne);
            myAreaFigures3.AcceptVisitor(new VisiteurForConsole());

            Console.WriteLine("-----------Delete a LINE in Container in Figures-----------");
            myAreaFigures3.DeleteFigure(myLigne);
            myAreaFigures3.AcceptVisitor(new VisiteurForConsole());

            Console.WriteLine("-----------Get Figure in Container in Figures-----------");
            // Create a new square2
            Square mySquare2 = new Square(myPointInMiddle, 2.5, 3.6); // Square(Point _point, double _height, double _width)
            mySquare2.AcceptVisitor(new VisiteurForConsole());
            Console.WriteLine("-----------Add a SQUARE in Container in Figures-----------");
            myAreaFigures3.AddFigure(mySquare2);

            Console.WriteLine("-----------Check Figure in Container by X and Y and return object-----------");
            Figure myFigureInFirst = myAreaFigures3.GetFigure(myPointInMiddle);
            Console.WriteLine(myFigureInFirst);
            myAreaFigures3.AcceptVisitor(new VisiteurForConsole());

            Console.ReadLine();

        }
    }
}
