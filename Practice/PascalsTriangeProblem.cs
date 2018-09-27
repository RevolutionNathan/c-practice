using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class PascalsTriangeProblem
    {
        public PascalsTriangeProblem() {}

        public List<int> PascalsTriangle(int n)
        {
            List<Node> nodeList = new List<Node>();
            Node rootNode = new Node();
            rootNode.value = 1;
            nodeList.Add(rootNode);

            for (int i = 0; i <= n; i++)
            {
                var leftNode = nodeList.Where(x => x.y == (i - 1)).Where(x => x.y == 1);
                Node node = new Node();

                nodeList.Add(node);
            }
            return new List<int>();
        }

        public class Node
        {
            public Node(Node rightParent = null, Node leftParent = null)
            {
                value = rightParent.value + leftParent.value;
            }

            private Node rightChild { get; set; }
            private Node leftChild { get; set; }
            public int x;
            public int y;
            public int value;
            private bool isRoot;
        }        
    }
}


// 1,1 2,1 2,2 3,1 3,2 3,3 4,1 4,2 4,3 4,4