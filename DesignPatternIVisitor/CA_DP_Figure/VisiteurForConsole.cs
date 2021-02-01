﻿using CL_DP_Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_DP_Figure
{
    class VisiteurForConsole : IVisitorForFigure
    {
        //public object Visitor { get; set; }

        public void VisitorForFigure(Figures _figures)
        {
            Console.WriteLine("-----------Init Container Figures-----------");
        }

        public void VisitorForFigure(Ligne _ligne)
        {
            Console.WriteLine($"Création d'une ligne aux coordonnées { _ligne.pointFigure.x } et { _ligne.pointFigure.y } jusqu'à  { _ligne.point2.x } et { _ligne.point2.y }");
        }

        public void VisitorForFigure(Circle _circle)
        {
            Console.WriteLine($"Création d'un cercle aux coordonnées { _circle.pointFigure.x } et { _circle.pointFigure.y } avec un rayon de { _circle.Radius }");
        }

        public void VisitorForFigure(Rectangle _rectangle)
        {
            Console.WriteLine($"Création d'un rectangle aux coordonnées { _rectangle.pointFigure.x } et { _rectangle.pointFigure.y } d'une hauteur de { _rectangle.Height } et d'une largeur de { _rectangle.Width }");
        }

        public void VisitorForFigure(Triangle _triangle)
        {
            Console.WriteLine($"Création d'un triangle aux coordonnées :{ _triangle.pointFigure.x } et { _triangle.pointFigure.y } Point 2:{ _triangle.point2.x } et { _triangle.point2.y } Point 3:{ _triangle.point3.x } et { _triangle.point3.y }");
        }
    }
}
