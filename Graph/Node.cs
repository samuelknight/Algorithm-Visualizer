using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AlgorithmVisualizer.GUI;

namespace AlgorithmVisualizer.Graph
{
    public delegate void NodeDisposingArgs(Node sender);

    public class Node : GUICircle, IDisposable
    {
        public event NodeDisposingArgs NodeDisposing;

        public Node(GraphicsInstance g, Point location) : base(g, Color.Black, new Size(30, 30), location) { }

        private List<Edge> _EdgeList = new List<Edge>();
        public IReadOnlyList<Edge> EdgeList { get { return _EdgeList; } }

        public Edge Connect(Node other) 
        {
            var edge = new Edge(this, other, this.graphicsInstance);
            this._EdgeList.Add(edge);
            other._EdgeList.Add(edge);
            return edge;
        }

        public Edge Disconnect (Node other)
        {
            var edge = new Edge(this, other, this.graphicsInstance);
            this._EdgeList.Remove(edge);
            other._EdgeList.Remove(edge);
            return edge;
        }

        public override void Dispose()
        {
            if (NodeDisposing != null)
                NodeDisposing(this);

            base.Dispose();
        }
    }
}