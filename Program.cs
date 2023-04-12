namespace BinarySearchTreeAndHashTableDay15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree and Hash Table Program");
            BinarySearchTree<int> obj = new BinarySearchTree<int>(56);
            obj.Add(30);
            obj.Add(70);
            obj.Display();
        }
    }


}
