using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskC_08.Interface
{
    interface IShapeSeries
    {
        public int CurrentShapeArea { get; set; }

        public void GetNextArea();

        public void ResetSeries();
    }

    class SquareSeries : IShapeSeries
    {
        public int Side { get; set; }
        public int CurrentShapeArea { get; set ; }

        public void GetNextArea()
        {
            Side++;
            CurrentShapeArea = Side* Side;
        }

        public void ResetSeries()
        {
            Side = 0;
            CurrentShapeArea =0;
        }
    }
    class CircleSeries : IShapeSeries
    {
        public int radius { get; set; }
        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            radius++;
            CurrentShapeArea = (int)Math.PI* radius* radius;
        }

        public void ResetSeries()
        {
            radius = 0;
            CurrentShapeArea = 0;
        }
    }
    

}
