using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public class detect_whether_a_linked_list_contains_a_cycle
    {
        public class SinglyLinkedListNode
        {
            private readonly int data;
            public SinglyLinkedListNode next;
            public SinglyLinkedListNode(int data)
            {
                this.data = data;
            }
        }
        static bool hasCycle(SinglyLinkedListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            SinglyLinkedListNode trackLast = head;
            SinglyLinkedListNode trackNext = head;
            while (trackNext != null && trackNext.next != null)
            {
                trackLast = trackLast.next;
                trackNext = trackNext.next.next;
                if (trackLast == trackNext)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
