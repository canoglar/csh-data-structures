using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //tests
            BinTree binTree = new BinaryTree();

            binTree.Add(1);
            binTree.Add(-7);
            binTree.Add(3);
            binTree.Add(0);
            binTree.Add(5);

            Node node = binaryTree.Find(5);
            int depth = binaryTree.GetTreeDepth();
        }
    }
}
