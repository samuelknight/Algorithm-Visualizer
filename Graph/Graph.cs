using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmVisualizer.GUI;

namespace AlgorithmVisualizer.Graph
{
    public class Graph : IDrawable
    {
        public List<Edge> Edges { get; set; }
        public List<Node> Nodes { get; set; }
        public GraphicsInstance graphicsInstance { get; set; }

        public Graph(GraphicsInstance _graphicsInstance)
        {
            Edges = new List<Edge>();
            Nodes = new List<Node>();
            graphicsInstance = _graphicsInstance;

            Random rand = new Random();
            const int NODE_COUNT = 8;
            // generate a binary tree
            for (int i = 0; i < NODE_COUNT; i++)
                Nodes.Add(new Node(graphicsInstance, new System.Drawing.Point(rand.Next(0, 100) + (i * 10), rand.Next(0, 100) + (i * 10))));

            // making connection
            for (int i = Nodes.Count - 1; i > 0; i--)
                Edges.Add(Nodes[i].Connect(Nodes[i / 2]));
        }

        public void Draw()
        {
            // Edges are drawn before Nodes so that nodes cover endpoints
            foreach (var edge in Edges)
                edge.Draw();

            foreach (var node in Nodes)
                node.Draw();
        }
    }
}
