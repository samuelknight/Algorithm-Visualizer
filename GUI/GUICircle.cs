using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace AlgorithmVisualizer.GUI
{
    public class GUICircle : IGUIEntity
    {
        public event EntityMovedHandler EntityMoved;
        public event EntityDisposingArgs Disposing;

        public Color color { get; private set; }
        Size size { get; set; }
        public Point location { get; private set; }
        public GraphicsInstance graphicsInstance { get; set; }

        // some internal fields
        SolidBrush brush;
        Pen pen;
        int brushSize;

        public GUICircle(GraphicsInstance graphicsInstance, Color color, Size size, Point location)
        {
            this.graphicsInstance = graphicsInstance;
            this.color = color;
            this.size = size;
            this.location = location;
            brushSize = 4;
            brush = new System.Drawing.SolidBrush(color);
            pen = new Pen(brush, brushSize);
        }

        public virtual void Draw()
        {
            Graphics g = graphicsInstance.GraphicsObj;
            Point biasedLoc = AddOffset(location, graphicsInstance.Offset);

            // Offset the location so that the draw is done about the center of the object
            g.FillEllipse(
                brush,
                biasedLoc.X - size.Width / 2,
                biasedLoc.Y - size.Height / 2, 
                size.Width, size.Height);
        }

        public virtual void Move(Point p)
        {
            var tmp = location;
            location = SubtractOffset(p, graphicsInstance.Offset);
            
            if (EntityMoved != null)
                EntityMoved(tmp, location);
        }

        public bool Collision(Point p) 
        {
            // equation for ellipse:
            // (x/r_x)^2 + x/r_y)^2 = 1
            // If the left expression evaluates to >=1, the point is inside the ellipse!

            Point biasedLoc = AddOffset(location, graphicsInstance.Offset); 

            double dx, dy, radius_x, radius_y;
            dx = Math.Abs(p.X - (biasedLoc.X * graphicsInstance.ScaleFactor));
            dy = Math.Abs(p.Y - (biasedLoc.Y * graphicsInstance.ScaleFactor));
            radius_x = size.Width / 2;
            radius_y = size.Height / 2;

            return (Math.Pow(dx/radius_x, 2) + Math.Pow(dy/radius_y, 2)) <= 1;
        }

        public bool Collision(Rectangle rect)
        {

            Point biasedLoc = AddOffset(location, graphicsInstance.Offset);

            Point TLCorner = new Point((int)(biasedLoc.X * graphicsInstance.ScaleFactor) - size.Width / 2, 
                (int)(biasedLoc.X * graphicsInstance.ScaleFactor) - size.Height / 2);

            var thisRegion = new Rectangle(TLCorner, size);
            thisRegion.Inflate(new Size(brushSize, brushSize));

            return Rectangle.Intersect(thisRegion, rect) != Rectangle.Empty;
        }

        public virtual void Dispose() { }

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
