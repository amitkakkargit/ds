using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class insert_a_node_at_a_specific_position_in_a_linked_list
    {
        // Complete the insertNodeAtPosition function below.


        //* For your reference:

        public class SinglyLinkedListNode
        {
            private readonly int data;
            public SinglyLinkedListNode next;
            public SinglyLinkedListNode(int data)
            {
                this.data = data;
            }
        }

        static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            if (head == null)
            {
                return head;
            }
            SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);
            if (head.next == null)
            {
                head.next = newNode;
                return head;
            }
            int i = 0;
            SinglyLinkedListNode oldHead = head;
            while (oldHead.next != null)
            {
                if (i == position - 1)
                {
                    newNode.next = oldHead.next;
                    oldHead.next = newNode;
                    break;
                }
                i = i + 1;
                oldHead = oldHead.next;
            }
            return head;
        }
    }
}
