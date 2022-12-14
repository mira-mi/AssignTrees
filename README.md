# AssignTrees
- A tree organizes values in a hierarchy. Each value in the tree is called a node. Each node may have child nodes.
- The first value is called the root (it has no parents). If a child node has children, it is a parent to its child nodes.

# Binary Tree
A binary tree is a tree data structure in which each node has at most two children, 
which are referred to as the left child and the right child.

# Binary Search Tree
A binary search tree, also called an ordered or sorted binary tree, is a rooted binary tree whose internal nodes each store a key greater than all the keys in the node's 
left subtree and less than those in its right subtree. 

# Different types

## Pre-Order Traversal
Traversal order:

Root node
Left Child
Right Child
 

public void PreOrder_Rec (TNode root)

{
    if (root != null)
    {
        Console.Write(root.Data +" ");
        PreOrder_Rec(root.Left);
        PreOrder_Rec(root.Right);
    }
}


## In-Order Traversal
Traversal order:

Left Child
Root node
Right Child
 

public void InOrder_Rec(TNode root)

{
    if (root != null)
     {
          InOrder_Rec(root.Left);
          Console.Write(root.Data +" ");
          InOrder_Rec(root.Right);
    }
}
 
## Post-Order Traversal
Traversal order:

Left Child
Right Child
Root node
public void PostOrder_Rec(TNode root)

{
    if (root != null)
   {
         PostOrder_Rec(root.Left);
         PostOrder_Rec(root.Right);
         Console.Write(root.Data +" ");
   }
}


In the C# language a tree can be implemented with classes (nodes) that point to further nodes. In this simple implementation, we use a Dictionary. 
A directed acyclic graph contains nodes that do not form cycles.
It can be used to store strings from a word list—each letter is one node.

The DFS algorithm is a recursive algorithm that uses the idea of backtracking. It involves exhaustive searches of all the nodes by going ahead, 
if possible, else by backtracking.

 
