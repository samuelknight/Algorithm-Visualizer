using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AlgorithmVisualizer.GUI;

namespace AlgorithmVisualizer.Graph
{
    public class Edge : GUILine
    {
        public Edge(Node source, Node destination, GraphicsInstance graphicInstance)
            : base(graphicInstance, Color.Black, source.location, destination.location)
        {
            Source = source;
            Destination = destination;
        }

        public override void Draw()
        {
            // Update the graph 
            LocationA = Source.location;
            LocationB = Destination.location;
            base.Draw();
        }

        /// <summary>
        /// Returns the first node that does not match the node passed in
        /// </summary>
        public Node FetchOther(Node thisNode)
        {
            return Source == thisNode ? Destination : Source;
        }

        public Node Source { get; set; }
        public Node Destination { get; set; }
        public Node Weight { get; set; }
    }
}
