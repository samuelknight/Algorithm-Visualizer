using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// inspiration came from http://www.brad-smith.info/blog/archives/129

namespace AlgorithmVisualizer.Graph
{
    /// <summary>
    /// Takes a graph and spacialy balances the nodes iteratively using:
    /// Spring-like attractive forces along edges [O(n^2) on node count]
    /// Charge-like forces to repel nodes [O(e) on edge count]
    /// </summary>
    public sealed class ForceDirectedGraph
    {
        public ForceDirectedGraph(List<Node> nodeList)
        {

        }
    }
}
