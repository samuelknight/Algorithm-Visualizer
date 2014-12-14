using System;
using System.Collections.Generic;
using System.Drawing;

namespace AlgorithmVisualizer.GUI
{
    public delegate void EntityMovedHandler(Point OldLoc, Point NewLoc);

    public class GraphicsInstance
    {
        public GraphicsInstance(double scaleFactor = 1.0, Graphics graphicsObj = null) 
            : this(new Size(0,0), scaleFactor, graphicsObj) { }

        public GraphicsInstance(Size offset, double scaleFactor = 1.0, Graphics graphicsObj = null)
        {
            Offset = offset;
            GraphicsObj = graphicsObj;
            ScaleFactor = scaleFactor;
        }

        public Graphics GraphicsObj { get; set; }
        public double ScaleFactor { get; set; }
        public Size Offset { get; set; }
    }

    /// <summary>
    /// An indpendent renderable with support for mouse interaction
    /// </summary>
    public interface IGUIEntity : IDrawable, IDisposable
    {
        GraphicsInstance graphicsInstance { get; set; }

        /// <summary>
        /// Updates the location data. The next call to draw will draw to the new location
        /// </summary>
        /// <param name="p">The new location</param>
        void Move(Point p);

        /// <summary>
        /// Checks if a point is within an entity's draw area. Used for mouse click and drag
        /// </summary>
        /// <param name="p">The point to test</param>
        /// <returns>Whether A point is within the bounds the entity's draw area</returns>
        bool Collision(Point p);

        /// <summary>
        /// Checks if a rectangle clips this entity's draw area. Used for computing redraw areas.
        /// </summary>
        /// <param name="rect">The region to detect</param>
        /// <returns>Whether the entity is withing the rectangle</returns>
        bool Collision(Rectangle rect);

        /// <summary>
        /// Triggered when an entity has changed position
        /// </summary>
        event EntityMovedHandler EntityMoved;

        /// <summary>
        /// Triggered after a call to Dispose() and before any resources are cleaned up
        /// </summary>
        event EntityDisposingArgs Disposing;
    }
}