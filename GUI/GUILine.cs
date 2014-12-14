using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmVisualizer.GUI
{
    public class GUILine : IDrawable, IDisposable
    {
        public virtual void Dispose() { }
        public Color color { get; set; }
        public Point LocationA { get; set; }
        public Point LocationB { get; set; }
        public GraphicsInstance graphicsInstance { get; set; }

        // some internal fields
        SolidBrush brush;
        Pen pen;
        int brushSize;

        public GUILine(GraphicsInstance graphicsInstance, Color color, Point locationA, Point locationB)
        {
            this.graphicsInstance = graphicsInstance;
            this.color = color;
            LocationA = locationA;
            LocationB = locationB;
            brushSize = 4;
            brush = new System.Drawing.SolidBrush(color);
            pen = new Pen(brush, brushSize);
        }

        public virtual void Draw()
        {

            Graphics g = graphicsInstance.GraphicsObj;
            Point biasedA = AddOffset(LocationA, graphicsInstance.Offset);
            Point biasedB = AddOffset(LocationB, graphicsInstance.Offset);

            // Offset the location so that the draw is done about the center of the object
            g.DrawLine(pen, biasedA, biasedB);
        }

        public bool Collision(Point p) 
        {
            return false;
        }

        public bool Collision(Rectangle rect)
        {
            /*
            Point biasedLoc = AddOffset(location, graphicsInstance.Offset);

            Point TLCorner = new Point((int)(biasedLoc.X * graphicsInstance.ScaleFactor) - size.Width / 2, 
                (int)(biasedLoc.X * graphicsInstance.ScaleFactor) - size.Height / 2);

            var thisRegion = new Rectangle(TLCorner, size);
            thisRegion.Inflate(new Size(brushSize, brushSize));

            return Rectangle.Intersect(thisRegion, rect) != Rectangle.Empty;
             */
            return false;
        }

        private Point AddOffset(Point old, Size offset)
        {
            return new Point(old.X + offset.Width, old.Y + offset.Height);
        }

        private Point SubtractOffset(Point old, Size offset)
        {
            return new Point(old.X - offset.Width, old.Y - offset.Height);
        }
    }
}
