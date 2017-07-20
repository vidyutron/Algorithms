using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Algorithm_Narasimha.Graphs
{
    public class AdjListNode
    {
        public int Dest { get; set; }
        public int Weight { get; set; }
        public AdjListNode Next { get; set; }

        public AdjListNode CreateNode(int dest,int weight)
        {
            var node= new AdjListNode();
            node.Dest = dest;
            node.Weight = weight;
            node.Next = null;
            return node;
        }
    }

    public class AdjList
    {
        public AdjListNode Head { get; set; }
        public AdjList()
        {
            Head = null;
        }
    }

    public class Graph
    {
        public int V { get; set; }
        public AdjList[] AdList { get; set; }

        public Graph CreateGraph(int v)
        {
            var graph = new Graph();
            graph.V = v;
            graph.AdList = new AdjList[v];
            for (int i = 0; i < v; i++)
            {
                graph.AdList[i] = new AdjList();
                graph.AdList[i].Head = null;
            }
            return graph;
        }

        public void AddEdge(Graph graph,int src,int dest,int weight)
        {
            var adjListNode = new AdjListNode();
            var newNode = adjListNode.CreateNode(dest, weight);
            newNode.Next = graph.AdList[src].Head;
            graph.AdList[src].Head = newNode;

            //since graph is unidirected, adding an edge from dest to src as well.
            newNode = adjListNode.CreateNode(src, weight);
            newNode.Next = graph.AdList[dest].Head;
            graph.AdList[dest].Head = newNode;
        }
    }

    public class MinHeapNode
    {
        public int V { get; set; }
        public int Dist { get; set; }

        public MinHeapNode CreateHeapNode(int v, int dist)
        {
            var minHeapNode = new MinHeapNode();
            minHeapNode.V = v;
            minHeapNode.Dist = dist;
            return minHeapNode;
        }
    }

    public class MinHeap
    {
        public int Size { get; set; }
        public int Capacity { get; set; }
        public int[] Position { get; set; }
        public MinHeapNode[] HeapList { get; set; }

        public MinHeap CreateMinHeap(int capacity)
        {
            var minHeap = new MinHeap();
            minHeap.Position = new int[capacity];
            minHeap.Size = 0;
            minHeap.Capacity = capacity;
            minHeap.HeapList = new MinHeapNode[capacity];

            return minHeap;
        }

        public void SwapMinHeapNode(ref MinHeapNode a,ref MinHeapNode b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public void MinHeapify(MinHeap minheap,int idx)
        {
            int smallest, left, right;
            smallest = idx;
            left = 2 * idx + 1;
            right = 2 * idx + 2;

            if (left < minheap.Size && minheap.HeapList[left].Dist <
                minheap.HeapList[smallest].Dist)
                smallest = left;
            if (right < minheap.Size && minheap.HeapList[right].Dist <
                minheap.HeapList[smallest].Dist)
                smallest = right;
            if (smallest != idx)
            {
                //the nodes to be swapped in min heap
                var smallestNode = minheap.HeapList[smallest];
                var idxNode = minheap.HeapList[idx];

                //swap positions
                minheap.Position[smallestNode.V] = idx;
                minheap.Position[idxNode.V] = smallest;
                //swap nodes
                SwapMinHeapNode(ref minheap.HeapList[smallest], ref minheap.HeapList[idx]);
                MinHeapify(minheap, smallest);
            }

        }

        public bool IsEmpty(MinHeap minheap)
        {
            return minheap.Size == 0;
        }

        public MinHeapNode ExtractMin(MinHeap minHeap)
        {
            if (IsEmpty(minHeap)) return null;

            //store the root node
            var root = minHeap.HeapList[0];

            //replace the root node with last node
            var lastNode = minHeap.HeapList[minHeap.Size - 1];
            minHeap.HeapList[0] = lastNode;

            //update the postion of last node
            minHeap.Position[root.V] = minHeap.Size - 1;
            minHeap.Position[lastNode.V] = 0;

            //Reduce the head Size and heapify root
            --minHeap.Size;
            MinHeapify(minHeap, 0);

            return root;
        }

        public void DecreaseKey(MinHeap minHeap,int v,int dist)
        {
            int i = minHeap.Position[v];

            //Get the node and update the dist value
            minHeap.HeapList[i].Dist = dist;

            //loop and complete the tree heapification
            while (i > 0 && minHeap.HeapList[i].Dist < minHeap.HeapList[(i - 1) / 2].Dist)
            {
                //swap this node with the its parent
                minHeap.Position[minHeap.HeapList[i].V] = (i - 1) / 2;
                minHeap.Position[minHeap.HeapList[(i - 1) / 2].V] = i;
                SwapMinHeapNode(ref minHeap.HeapList[i], ref minHeap.HeapList[(i - 1) / 2]);

                //move to parent index
                i = (i - 1) / 2;
            }
        }

        public bool IsInMinHeap(MinHeap minHeap,int v)
        {
            if (minHeap.Position[v] < minHeap.Size)
                return true;
            return false;
        }
    }

    public class DijkstraAdjList
    {
        public void Dijkstra(Graph graph,int src)
        {
            int v = graph.V;//number of vertices in graph
            int[] dist=new int[v];//dist vales used to pick the weight edge 

            //minHeap represent set E
            var heap = new MinHeap();
            var minHeap = heap.CreateMinHeap(v);

            //Initialize the min heap with the all the vertices
            var heapNode = new MinHeapNode();
            for (int i = 0; i < v; i++)
            {
                dist[i] = int.MaxValue;
                minHeap.HeapList[i] = heapNode.CreateHeapNode(src, dist[src]);
                minHeap.Position[i] = i;
            }

            //making the dist value of src so that it can be picked first
            minHeap.HeapList[src] = new MinHeapNode().CreateHeapNode(src, dist[src]);
            minHeap.Position[src] = src;
            dist[src] = 0;
            minHeap.DecreaseKey(minHeap, src, dist[src]);

            //Intially size of min heap is equal to V
            minHeap.Size = v;

            //in following loop, min heap contain all nodes
            //whose shortest distance is not yet finalised
            while (!minHeap.IsEmpty(minHeap))
            {
                var minheapNode = minHeap.ExtractMin(minHeap);
                int u = minheapNode.V;

                var nodeCrawl = graph.AdList[u].Head;
                while (nodeCrawl != null)
                {
                    int k = nodeCrawl.Dest;
                    //if the sortest distance to v is not finalized yet, and distance to v
                    //through u is less than its previously calculated distance
                     if(minHeap.IsInMinHeap(minHeap,k)&& dist[u]!=int.MaxValue
                        && nodeCrawl.Weight+dist[u]<dist[k])
                    {
                        dist[k] = dist[u] + nodeCrawl.Weight;
                        //update distance value in min heap also
                        minHeap.DecreaseKey(minHeap, k, dist[k]);
                    }
                    nodeCrawl = nodeCrawl.Next;

                }
            }

        }
    }
}
