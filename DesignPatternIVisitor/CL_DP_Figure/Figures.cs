using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_DP_Figure
{
    public class Figures : Figure
    {
        protected Point pointFigures { get; set; }

        public List<Figure> containerFigures { get; set; }

        public Figures(int _x, int _y) : base(_x, _y)
        {
            containerFigures = new List<Figure>();
            pointFigures = new Point(_x, _y);
            //this.Draw();
        }
        public Figures(Point _point) : base(_point.x, _point.y)
        {
            containerFigures = new List<Figure>();
            pointFigures = new Point(_point.x, _point.y);
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
                _figure.pointFigure.x = _x;
                _figure.pointFigure.y = _y;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MoveFigure(Figure _figure, Point _point)
        {
            if (containerFigures.Contains(_figure))
            {
                _figure.pointFigure.x = _point.x;
                _figure.pointFigure.y = _point.y;
                return true;
            }
            return false;
        }

        public Figure GetFigure(Point _point)
        {
            Figure myFigureToGet = null;
            if (containerFigures != null)
            {
                var resultlist = containerFigures.ToList();
                foreach (Figure value in resultlist)
                {
                    if ((value.pointFigure.x == _point.x) && (value.pointFigure.y == _point.y))
                    {
                        myFigureToGet = value;
                    }
                }
                return myFigureToGet;
            }
            else
            {
                return null;
            }
        }

        public bool DeleteFigure(Figure _figure)
        {
            if (containerFigures.Contains(_figure))
            {
                containerFigures.Remove(_figure);
                return true;
            }
            return false;
        }

        public bool SelfRemoveFigures()
        {
            if(containerFigures != null)
            {
                var resultlist = containerFigures.ToList();
                foreach (Figure value in resultlist)
                {
                    DeleteFigure(value);
                }
                containerFigures = new List<Figure>();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Figure> CreateFiguresOneItem(string _figureType)
        {
            switch (_figureType)
            {
                case "square":
                    Square mySquare = new Square(new Point(0, 0), 2, 2);
                    //mySquare.Draw();
                    containerFigures.Add(mySquare);
                    break;
                case "circle":
                    Circle myCircle = new Circle(new Point(0, 0), 6);
                    //myCircle.Draw();
                    containerFigures.Add(myCircle);
                    break;
                case "triangle":
                    Triangle myTriangle = new Triangle(new Point(0, 0), new Point(1, 1), new Point(1, 2));
                    //myTriangle.Draw();
                    containerFigures.Add(myTriangle);
                    break;
                case "ligne":
                    Ligne myLigne = new Ligne(new Point(0, 0), new Point(5, 5));
                    //myLigne.Draw();
                    containerFigures.Add(myLigne);
                    break;
                default:
                    Ligne myDefaultLigne = new Ligne(new Point(0, 0), new Point(5, 5));
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
            foreach (Figure myFigure in containerFigures)
            {
                myFigure.Draw();
            }
        }

        public override void AcceptVisitor(IVisitorForFigure _visitor)
        {
            _visitor.VisitorForFigure(this);
            var resultlist = containerFigures.ToList();
            foreach (Figure figure in resultlist)
            {
                figure.AcceptVisitor(_visitor);
            }
        }
    }
}
