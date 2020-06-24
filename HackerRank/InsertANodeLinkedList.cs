﻿using System;
using System.IO;

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the insertNodeAtPosition function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
    {
        int pos = 0;
        var prev = head;
        while (pos < position - 1)
        {
            prev = prev.next;
            pos++;
        }

        var oldnext = prev.next;
        prev.next = new SinglyLinkedListNode(data);
        prev.next.next = oldnext;
        return head;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        SinglyLinkedList llist = new SinglyLinkedList();

        int llistCount = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < llistCount; i++)
        {
            int llistItem = Convert.ToInt32(Console.ReadLine());
            llist.InsertNode(llistItem);
        }

        int data = Convert.ToInt32(Console.ReadLine());

        int position = Convert.ToInt32(Console.ReadLine());

        SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

        PrintSinglyLinkedList(llist_head, " ", textWriter);
        textWriter.WriteLine();

        textWriter.Flush();
        textWriter.Close();
    }
}


//You’re given the pointer to the head node of a linked list, an integer to add to the list and the position at which the integer must be inserted.Create a new node with the given integer, insert this node at the desired position and return the head node.

//A position of 0 indicates head, a position of 1 indicates one node away from the head and so on. The head pointer given may be null meaning that the initial list is empty.

//As an example, if your list starts as  and you want to insert a node at position with, your new list should be

//Function Description Complete the function insertNodeAtPosition in the editor below.It must return a reference to the head node of your finished list.

//insertNodeAtPosition has the following parameters:


//head: a SinglyLinkedListNode pointer to the head of the list
//data: an integer value to insert as data in your new node
//position: an integer position to insert the new node, zero based indexing
//Input Format

//The first line contains an integer , the number of elements in the linked list.
//Each of the next  lines contains an integer SinglyLinkedListNode[i].data.
//The next line contains an integer  denoting the data of the node that is to be inserted.
//The last line contains an integer.

//Constraints


//, where  is the element of the linked list.
//.
//Output Format


//Return a reference to the list head.Locked code prints the list for you.

//Sample Input

//3
//16
//13
//7
//1
//2
//Sample Output

//16 13 1 7
//Explanation

//The initial linked list is 16 13 7. We have to insert  at the position which currently has  in it.The updated linked list will be 16 13 1 7