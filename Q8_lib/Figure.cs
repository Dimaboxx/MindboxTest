using System;
using System.Collections.Generic;
using System.Text;

namespace Q8_lib
{

    public abstract class Figure
    {
       

    }

    public class Circle : Figure
    {
        public double Radius { get; set; }
    }

    public class Triangle : Figure
    {
        public List<double> Sides { get; set; }
    }


}
