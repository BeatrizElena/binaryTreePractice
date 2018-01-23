using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int Data;
        public Node LeftChild;
        public Node RightChild;
    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }
        public void add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            Console.WriteLine("This is the input: " + newNode.Data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.LeftChild;
                        if (current == null)
                        {
                            parent.LeftChild = newNode;
                            Console.WriteLine("Parent Left Child is: " + parent.LeftChild.Data);
                            break;
                        }
                    }
                    else
                    {
                        current = current.RightChild;
                        if (current == null)
                        {
                            parent.RightChild = newNode;
                            Console.WriteLine("Parent Right Child is : " + parent.RightChild.Data);
                            break;
                        }
                    }
                }
            }
        }
    }
    class Program
    {
            static void Main(string[] args)
            {
            BinarySearchTree tree1 = new BinarySearchTree();
            tree1.add(50);
            tree1.add(40);
            tree1.add(60);
            tree1.add(20);
            tree1.add(45);
            tree1.add(55);
            tree1.add(65);
            var names = "Ara and Beatriz";

            Console.WriteLine("Please pick a number: ");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number in the tree is");
            tree1.add(myNumber);
            Console.WriteLine("Programmers: " + names);
            }
    }
}
