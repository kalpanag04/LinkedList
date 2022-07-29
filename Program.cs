using DataStructuresDemo;

Console.WriteLine("Hello World!");
LinkedList list = new LinkedList();

list.AddAtEnd(56);
list.AddAtEnd(30);
list.AddAtEnd(70);

list.RemoveLastNode();

Console.WriteLine("Elements in LinkedList are : ");
list.Display();
