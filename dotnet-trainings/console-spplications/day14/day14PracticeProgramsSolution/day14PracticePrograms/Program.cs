namespace day14PracticePrograms
{
    internal class Program
    {


        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            var res = 0;
            do
            {
                Console.WriteLine("Enter node value:");
                res = Convert.ToInt32(Console.ReadLine());
                linkedList.Add(res);
            }while (res !=1000);

            Program program = new Program();
            program.HasCycle(linkedList.head);

        }
        public async Task<bool> HasCycle(ListNode head)
        {
            HashSet<ListNode> node = new HashSet<ListNode>();
            while (head != null)
            {
                if (node.Contains(head))
                {
                    return true;
                }
                node.Add(head);
                head = head.next;
            }
            return false;
        }
    }
}
