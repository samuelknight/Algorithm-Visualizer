using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using AlgorithmVisualizer.Graph;

namespace AlgorithmVisualizer.GUI
{
    public class AnimatedPictureBox : PictureBox
    {

        List<IGUIEntity> entityList = new List<IGUIEntity>();
        GraphicsInstance graphicsInstance;
        Graph.Graph graph;

        bool ScreenSelected = false;
        IGUIEntity SelectedEntity;

        public AnimatedPictureBox()
        {
            graphicsInstance = new GraphicsInstance();
        }

        public void startRendering()
        {
            Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //    entityList.Add(new GUIEntityImpl(graphicsInstance, Color.Black, new Size(20, 20), new Point(rnd.Next(0, this.Width), rnd.Next(0, this.Height))));
            graph = new Graph.Graph(graphicsInstance);
            var tmp = graph.Nodes;
            entityList = tmp.ConvertAll(x => (IGUIEntity)x);

            this.Invalidate();
        }

        // local variables utilized on paning the frame
        Point mouseStart;
        Size offsetStart;

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (SelectedEntity != null)
            {
                //// need to create a region large enough to encapsulate the old rendering and the new one
                //// Making it larger than necessary is acceptable since the alternative is to redraw the entire region anyway
                //Point newLoc = new Point(e.X, e.Y);
                //Point oldLoc = SelectedEntity.location;


                //var newRect = Rectangle.FromLTRB(e.X, e.Y, SelectedEntity.location.X, SelectedEntity.location.Y);
                //newRect.Inflate(SelectedEntity.size.Width, SelectedEntity.size.Height);

                SelectedEntity.Move(new Point((int)(e.X / gscale), (int)(e.Y / gscale)));
                //this.Invalidate(newRect);

                // just redraw globally for now
                this.Invalidate();
            }
            else if (ScreenSelected)
            {
                graphicsInstance.Offset = new Size((int)(offsetStart.Width + (e.X - mouseStart.X) / gscale), (int)(offsetStart.Height + (e.Y - mouseStart.Y) / gscale));
                Cursor.Current = Cursors.SizeAll;
                this.Invalidate();
            }
            else
            {
                // O(n) just for moving the mouse. Might want to change later.
                Cursor.Current = Cursors.Default;
                foreach (var entity in entityList)
                {
                    if (entity.Collision(new Point(e.X, e.Y)))
                    {
                        Cursor.Current = Cursors.Hand;
                        break;
                    }
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // each entity has a reference to this object
            graphicsInstance.GraphicsObj = e.Graphics;
            e.Graphics.ScaleTransform(gscale, gscale);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            if(graph != null)
            graph.Draw();
        }

        float gscale = 1;
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            // smoothly modify gscale to be a value between .01x to 10x default size
            gscale = (float)Math.Min(10, Math.Max(.2, gscale + (e.Delta / (2000.0 / gscale))));

            graphicsInstance.ScaleFactor = gscale;
            this.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.Focus();
            Point eventPoint = new Point(e.X, e.Y);

            // Search entity list for a selected entity
            foreach (var entity in entityList)
            {
                if (entity.Collision(eventPoint))
                {
                    SelectedEntity = entity;
                    break;
                }
            }

            if (SelectedEntity == null)
            {
                mouseStart = new Point(e.X, e.Y);
                offsetStart = graphicsInstance.Offset;
                ScreenSelected = true;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            ScreenSelected = false ;

            if (e.Button == System.Windows.Forms.MouseButtons.Middle)
            {
                graphicsInstance.Offset = new Size(graphicsInstance.Offset.Width + 1, graphicsInstance.Offset.Height);
                this.Invalidate();
            }
            // deselect if an entity was selected
            SelectedEntity = null;
        }
    }
}