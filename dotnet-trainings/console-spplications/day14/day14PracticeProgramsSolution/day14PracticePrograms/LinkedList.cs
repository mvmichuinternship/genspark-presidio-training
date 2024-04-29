using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14PracticePrograms
{
    public class LinkedList
    {
        public ListNode head;
        public void Add(int data)
        {
            ListNode newNode = new ListNode();
            newNode.val = data;
            ListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
        }
    }
}
