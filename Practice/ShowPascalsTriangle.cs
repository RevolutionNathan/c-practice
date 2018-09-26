using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete
{
    class ShowPascalsTriangle
    {
        public static List<int> PascalsTriangle(int n)
        {
            List<Node> nodes = new List<Node>();

            Node node = new Node();
            node.x = 1;
            node.y = 1;

            for (int i = 0; i <= n; i++)
            {
            }
            return new List<int>();
        }

        public class Node
        {
            //don't use parents, use children
            public Node(Node rightParent = null, Node leftParent = null)
            {
                _rightParent = rightParent;
                _leftParent = leftParent;
            }
            public int x { get; set; }
            public int y { get; set; }
            public Node _rightParent { get; set; }
            public Node _leftParent { get; set; }
            public int? value => GetValue();
       
            public int? GetValue()
            {
                var isRoot = (x == 1) && (y == 1);
                return isRoot ? (_rightParent?.value + _leftParent?.value) : 1;
            }
        }
    }
}
