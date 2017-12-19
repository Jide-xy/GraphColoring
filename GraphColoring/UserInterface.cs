using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphColoring
{
    public static class UserInterface
    {
        public static void addVertices(Graph graph)
        {
            string vertex = "";
            while (vertex != "$")
            {
                Console.WriteLine("Enter name of vertex or $ to continue");
                vertex = Console.ReadLine();
                if (vertex != "$")
                {
                    graph.addVertex(vertex);
                }
            }
        }
        public static void addEdge(Graph graph)
        {
            string edges = "";
            while (edges != "$")
            {
                Console.WriteLine("Enter bunch of adjacent nodes seperated by commas or $ to continue");
                edges = Console.ReadLine();
                if (edges != "$")
                {
                    string[] adj_nodes = edges.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    if (adj_nodes.Length > 1) ;
                    graph.addEdge(adj_nodes);
                }
            }
        }
    }
}
