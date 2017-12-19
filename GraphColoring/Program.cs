using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphColoring
{
    class Program
    {

        public static void Main(string[] args)
        {
         //   Graph graph = new Graph();
            //UserInterface.addVertices(graph);
            //UserInterface.addEdge(graph);
           // ColorGraph color = new ColorGraph(graph);
            //color.color();
            //Console.Clear();
            //Console.WriteLine(graph);
            //Console.WriteLine(color);
            Graph graph2 = new Graph();
            string[] student1 = { "maths", "english", "biology", "chemistry" };
            string[] student2 = { "maths", "english", "compsci", "geography" };
            string[] student3 = { "biology", "psychology", "geography", "spanish" };
            string[] student4 = { "biology", "compsci", "history", "french" };
            string[] student5 = { "english", "psychology", "compsci", "history" };
            string[] student6 = { "psychology", "chemistry", "compsci", "french" };
            string[] student7 = { "psychology", "geography", "history", "spanish" };
            graph2.addVertex("maths");
            graph2.addVertex("english");
            graph2.addVertex("biology");
            graph2.addVertex("chemistry");
            graph2.addVertex("compsci");
            graph2.addVertex("geography");
            graph2.addVertex("history");
            graph2.addVertex("french");
            graph2.addVertex("spanish");
            graph2.addVertex("psychology");
            graph2.addEdge(student1);
            graph2.addEdge(student2);
            graph2.addEdge(student3);
            graph2.addEdge(student4);
            graph2.addEdge(student5);
            graph2.addEdge(student6);
            graph2.addEdge(student7);
            //graph.addVertex("s");
            //graph.addVertex("p");
            //graph.addVertex("g");
            //graph.addVertex("u");
            //graph.addVertex("l");
            //graph.addVertex("c");
            //graph.addEdge("c", "l");
            //graph.addEdge("c", "s");
            //graph.addEdge("l", "c");
            //graph.addEdge("l", "u");
            //graph.addEdge("l", "p");
            //graph.addEdge("s", "u");
            //graph.addEdge("s", "c");
            //graph.addEdge("s", "p");
            //graph.addEdge("s", "g");
            //graph.addEdge("u", "s");
            //graph.addEdge("u", "l");
            //graph.addEdge("u", "g");
            //graph.addEdge("p", "s");
            //graph.addEdge("p", "l");
            //graph.addEdge("p", "g");
            //graph.addEdge("g", "p");
            //graph.addEdge("g", "s");
            //graph.addEdge("g", "u");
            ////  graph.removeVertex("C");
            Console.WriteLine(graph2.ToString());
           // color.color();
        //    Console.WriteLine(color.ToString());
            ColorGraph color2 = new ColorGraph(graph2);
            color2.color();
            Console.WriteLine(color2);
            Console.Read();
        }
    }
}
