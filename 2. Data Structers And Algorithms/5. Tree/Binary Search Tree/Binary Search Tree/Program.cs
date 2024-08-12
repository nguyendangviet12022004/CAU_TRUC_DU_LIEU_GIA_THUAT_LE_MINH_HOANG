using Binary_Search_Tree;
using System.Xml.Linq;

Node root = null;
int[] array = [4,3,5,1,3,5,3,10,9,8];
foreach (int value in array)
{
    root = BST.RInsert(root, value);
}

BST.PostOrderTraverse(root);