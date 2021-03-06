using System;
using System.Collections.Generic;

namespace Trees.Classes
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        /// <summary>
        /// Constructor method that creates a BinaryTree object with a root node
        /// </summary>
        /// <param name="value"></param>
        public BinaryTree(T value)
        {
            Root = new Node<T>(value);
        }

        /// <summary>
        /// Contructor method that creates an empty BinarySearchTree object
        /// </summary>
        public BinaryTree()
        {

        }

        /// <summary>
        /// A non-resursive method that creates and return a generic list to store nodes from resursive helper method PreOrder
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> PreOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            PreOrder(node, traversal);

            return traversal;
        }

        /// <summary>
        /// A recursive helper method that:
        /// 1. Adds Root node to the call stack then adds to a generic list
        /// 2. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node
        /// 3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="traversal"></param>
        private void PreOrder(Node<T> node, List<T> traversal)
        {
            traversal.Add(node.Value);

            if(node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if(node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }
        }

        /// <summary>
        /// A non-resursive method that creates and return a generic list to store nodes from resursive helper method InOrder
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> InOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            InOrder(node, traversal);

            return traversal;
        }

        /// <summary>
        /// A recursive helper method that:
        /// 1. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node 
        /// 2. Adds Root node to the call stack then adds to a generic list
        /// 3. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
        /// </summary>
        /// <param name="node"></param>
        /// <param name="traversal"></param>
        private void InOrder(Node<T> node, List<T> traversal)
        {
            if(node.LeftChild != null)
            {
                InOrder(node.LeftChild, traversal);
            }

            traversal.Add(node.Value);

            if (node.RightChild != null)
            {
                InOrder(node.RightChild, traversal);
            }
        }

        /// <summary>
        /// A non-resursive method that creates and return a generic list to store nodes from resursive helper method PostOrder
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> PostOrder(Node<T> node)
        {
            List<T> traversal = new List<T>();

            PostOrder(node, traversal);

            return traversal;
        }

        /// <summary>
        /// A recursive helper method that:
        /// 1. Adds LeftChild to the call stack then adds to the generic list until there is no more LeftChild node 
        /// 2. Adds RightChild to the call stack then adds to the generic list until there is no more RightChild node
        /// 3. Adds Root node to the call stack then adds to a generic list
        /// </summary>
        /// <param name="node"></param>
        /// <param name="traversal"></param>
        private void PostOrder(Node<T> node, List<T> traversal)
        {
            if (node.LeftChild != null)
            {
                PreOrder(node.LeftChild, traversal);
            }
            if (node.RightChild != null)
            {
                PreOrder(node.RightChild, traversal);
            }

            traversal.Add(node.Value);
        }

        /// <summary>
        /// Method that traveres a tree using a queue and while loop
        /// While there is no more child nodes, as the enqued node deques, it enques LeftChild and RightChild nodes
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public List<T> BreadthFirst(Node<T> node)
        {
            Queue<Node<T>> breadth = new Queue<Node<T>>();
            List<T> values = new List<T>();

            breadth.Enqueue(node);

            while(breadth.TryPeek(out node))
            {
                Node<T> front = breadth.Dequeue();
                values.Add(front.Value);

                if (front.LeftChild != null)
                {
                    breadth.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    breadth.Enqueue(front.RightChild);
                }
            }
            return values;
        }
    }
}


//////////////////////////////////////////////////////////////

using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Hello World");
   BinarySearchTree nums = new BinarySearchTree();
    nums.Insert(23);
    nums.Insert(45);
    nums.Insert(16);
    nums.Insert(37);
    nums.Insert(3);
    nums.Insert(99);
    nums.Insert(22);
    Console.WriteLine("Inorder traversal: ");
    nums.InOrder(nums.root);
    Console.WriteLine("\n ");
    Console.WriteLine("Preorder traversal: ");
    nums.PreOrder(nums.root);
    Console.WriteLine("\n");
    Console.WriteLine("Postorder traversal: ");
    nums.PostOrder(nums.root);
        
  }

  public class Node 
  {
public int Data;
public Node Left;
public Node Right;

public void DisplayNode() 
{
  Console.Write(Data + " ");
 }
}


public class BinarySearchTree 
{
  public Node root;
  public BinarySearchTree()
   {
  root = null;
}

   public void Insert(int i)
  {
      Node newNode = new Node();
      newNode.Data = i;
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
              if (i < current.Data) 
              {
                  current = current.Left;
                  if (current == null) 
                  {
                      parent.Left = newNode;
                      break;
                  }
                  }
                  else {
                  current = current.Right;
                if (current == null) 
                {
                  parent.Right = newNode;
                break;
              }
            }
          }
        }
      }
  public void InOrder(Node theRoot) {
  if (!(theRoot == null)) {
      InOrder(theRoot.Left);
      theRoot.DisplayNode();
      InOrder(theRoot.Right);
     }
    }

  public void PreOrder(Node theRoot) {
  if (!(theRoot == null)) {
    theRoot.DisplayNode();
    PreOrder(theRoot.Left);
    PreOrder(theRoot.Right);
     }
    }

  public void PostOrder(Node theRoot) {
  if (!(theRoot == null)) {
    PostOrder(theRoot.Left);
    PostOrder(theRoot.Right);
    theRoot.DisplayNode();
     }
   }

  }

}