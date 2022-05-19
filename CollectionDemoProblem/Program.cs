using System;
class program
{
    static void Main(string[] args)
    {
        ListDemo();
        StackDemo();
        QueueDemo();
        SetDemo();
        DictionaryDemo();

        static void ListDemo()
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^List Demo^^^^^^^^^^^^^^^^^^^^^^^^^");
            List<string> list = new List<string>();
            list.Add("chetana");
            list.Add("Desale");
            list.Add("Student");
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
        }
        static void StackDemo()
        {
            Console.WriteLine("********************Stack Demo************************");
            Stack<string> stack = new Stack<string>();
            stack.Push("chetana");
            stack.Push("Desale");
            stack.Push("Student");
            stack.Pop();
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
        }
        static void QueueDemo()
        {
            Console.WriteLine("###################Queue Demo###########################");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("chetana");
            queue.Enqueue("Desale");
            queue.Enqueue("Student");
            queue.Dequeue();
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }
        }
        static void SetDemo()
        {
            Console.WriteLine("******************Set Demo*************************8");
            HashSet<string> set = new HashSet<string>();
            set.Add("Chetana");
            set.Add("Desale");
            set.Add("Student");
            set.Add("Chetana");
            foreach (var data in set)
            {
                Console.WriteLine(data);
            }
        }
        static void DictionaryDemo()
        {
            Console.WriteLine("**************************Dictionary Demo**************************8");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "chetana");
            dictionary.Add(200, "Desale");
            dictionary.Add(300, "Student");

            foreach (var data in dictionary)
            {
                Console.WriteLine("key:" + data.Key +" "+ "value:" + data.Value);
            }
        }


    }
}