using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Figures : Figure
    {
        //public int x { get; set; } // protected // private 
        //public int y { get; set; } // protected // private 

        public List<Figure> containerFigures { get; set; }

        public Figures(int x, int y) : base(x, y)
        {
            containerFigures = new List<Figure>();
            //this.x = _x;
            //this.y = _y;
            //this.Draw();
        }
        public Figures(Point _point) : base(_point.x, _point.y)
        {
            containerFigures = new List<Figure>();
            //this.x = _x;
            //this.y = _y;
            //this.Draw();
        }

        public bool AddFigure(Figure _figure)
        {
            if (!containerFigures.Contains(_figure))
            {
                containerFigures.Add(_figure);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MoveFigure(Figure _figure ,int _x, int _y)
        {
            if (containerFigures.Contains(_figure))
            {
                _figure.x = _x;
                _figure.y = _y;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteFigure(Figure _figure)
        {
            if (!containerFigures.Contains(_figure))
            {
                return false;
            }
            else
            {
                containerFigures.Remove(_figure);
                return true;
            }
        }

        /*public bool SelfRemoveAllItemsInFigures(Figures _Figures)
        {
            foreach (var myFigure in _Figures.containerFigures)
            {
                containerFigures.Remove(myFigure);
            }
            return true;
        }*/

        public List<Figure> CreateFiguresOneItem(string _figureType)
        {
            switch (_figureType)
            {
                case "square":
                    Square mySquare = new Square(0, 0);
                    //mySquare.Draw();
                    containerFigures.Add(mySquare);
                    break;
                case "circle":
                    Circle myCircle = new Circle(0, 0);
                    //myCircle.Draw();
                    containerFigures.Add(myCircle);
                    break;
                case "triangle":
                    Triangle myTriangle = new Triangle(0, 0);
                    //myTriangle.Draw();
                    containerFigures.Add(myTriangle);
                    break;
                case "ligne":
                    Ligne myLigne = new Ligne(0, 0);
                    //myLigne.Draw();
                    containerFigures.Add(myLigne);
                    break;
                default:
                    Ligne myDefaultLigne = new Ligne(0, 0);
                    //myDefaultLigne.Draw();
                    containerFigures.Add(myDefaultLigne);
                    break;
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
