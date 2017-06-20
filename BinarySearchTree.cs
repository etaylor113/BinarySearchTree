using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchCars.BinaryTree
{
    class BinaryTree
    {
        private Node root;
        List<int> nums = new List<int>();
        public void addToList()
        {
            nums.Add(526);
            nums.Add(455);
            nums.Add(707);
            nums.Add(435);
            nums.Add(485);
            nums.Add(650);
            nums.Add(840);
        }

        public BinaryTree()
        {
            root = null;
        }

        public void Menu()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Press # to navigate. \n'1' - View all Numbers \n'2' - Search Number \n'3' - Add Number \n'4' - Exit");
                int menuSelect = Int32.Parse(Console.ReadLine());
                switch (menuSelect)
                {
                    case 1:
                        Console.Clear();
                        ViewNumber();
                        break;
                    case 2:
                        Console.Clear();
                        SearchNumber();
                        break;
                    case 3:
                        Console.Clear();
                        AddNumber();
                        break;
                    case 4:
                        Exit();
                        break;
                }
            }
            catch
            {
                Menu();
            }
            Menu();
        }
    




public void Display()
{
    Display(root, 0);
    Console.WriteLine();
}

public void Display(Node node, int level)
{
    if (node == null)
    {
        return;
    }
    Display(node.rightChild, level + 1);
    Console.WriteLine();
    for (int i = 0; i < level; i++)
    {
    }
    Console.Write(node.data1);
    Display(node.leftChild, level + 1);
}

public void ViewNumber()
{
    Display();
    Console.WriteLine();
    Console.ReadLine();
    Console.Clear();
    Menu();
}

public void SearchNumber()
{
    Node main = root;
    Console.WriteLine("Type number to search");
    int number = Int32.Parse(Console.ReadLine());

    foreach (int num in nums)
    {
        if (number == num)
        {
            Console.WriteLine(num + " found in tree!");
            Console.Read();
        }
        else
        {
        }
    }
    Menu();
}

public void AddNumber()
{
    Console.WriteLine("Type number you want to add.");
    int addedNum = Int32.Parse(Console.ReadLine());
    nums.Add(addedNum);
    Node main = root;
    Node parent = null;
    Node toAdd = new Node(addedNum);
    while (main != null)
    {
        if (main.data1 == addedNum)
        {
            return;
        }
        else if (main.data1 > addedNum)
        {
            parent = main;
            main = main.leftChild;
        }
        else if (main.data1 < addedNum)
        {
            parent = main;
            main = main.rightChild;
        }
    }

    if (parent == null)
    {
        root = toAdd;
    }
    else
    {

        if (parent.data1 > addedNum)
        {
            parent.leftChild = toAdd;
        }
        else
        {
            parent.rightChild = toAdd;
        }
    }
    Menu();
}

public void Exit()
{
    Environment.Exit(0);
}

public void createTree()
{
    createTree(root);
    Console.WriteLine();
}

public void createTree(Node node)
{
    root = new Node(526);
    root.leftChild = new Node(455);
    root.rightChild = new Node(707);
    root.leftChild.leftChild = new Node(435);
    root.leftChild.rightChild = new Node(485);
    root.rightChild.leftChild = new Node(650);
    root.rightChild.rightChild = new Node(840);
}


    }
}
