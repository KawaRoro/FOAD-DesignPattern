using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Figures : Figure
    {
        public List<Figure> containerFigures { get; set; }

        public Figures(int x, int y) : base(x, y)
        {
            containerFigures = new List<Figure>();
            //this.Draw();
        }

        public List<Figure> AddFigures(string _figureType)
        {
            if (_figureType == "square")
            {
                Square mySquare = new Square(0, 0);
                //mySquare.Draw();
                containerFigures.Add(mySquare);
            }
            else if (_figureType == "circle")
            {
                Circle myCircle = new Circle(0, 0);
                //myCircle.Draw();
                containerFigures.Add(myCircle);
            }
            else if (_figureType == "triangle")
            {
                Triangle myTriangle = new Triangle(0, 0);
                //myTriangle.Draw();
                containerFigures.Add(myTriangle);
            }
            else if (_figureType == "ligne")
            {
                Ligne myLigne = new Ligne(0, 0);
                //myLigne.Draw();
                containerFigures.Add(myLigne);
            }

            return this.containerFigures;
        }

        /*public List<Figure> GetFigures()
        {
            return this.containerFigures;
        }*/

        public override void Draw()
        {
            Console.WriteLine("-----------Init Container Figures-----------");
            foreach (var myFigure in containerFigures)
            {
                myFigure.Draw();
            }
        }
    }
}
