using DS_Algorithm_Narasimha.Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Test.DS_Algo_Narasimha.Graphs
{
    [TestClass]
    public class DijkstraTest
    {
        [TestMethod]
        public void DijkstraAdjListTest()
        {
            var graph = new Graph().CreateGraph(9);
            graph.AddEdge(graph, 0, 1, 4);
            graph.AddEdge(graph, 0, 7, 8);
            graph.AddEdge(graph, 1, 2, 8);
            graph.AddEdge(graph, 1, 7, 11);
            graph.AddEdge(graph, 2, 7, 7);
            graph.AddEdge(graph, 2, 3, 2);
            graph.AddEdge(graph, 2, 8, 4);
            graph.AddEdge(graph, 2, 5, 9);
            graph.AddEdge(graph, 3, 5, 14);
            graph.AddEdge(graph, 4, 5, 14);
            graph.AddEdge(graph, 5, 6, 2);
            graph.AddEdge(graph, 6, 7, 1);
            graph.AddEdge(graph, 6, 8, 6);
            graph.AddEdge(graph, 7, 8, 7);

            var dijkstra = new DijkstraAdjList();
            dijkstra.Dijkstra(graph, 0);

        }
    }
}
