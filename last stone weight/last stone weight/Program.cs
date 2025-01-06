using System;
using System.Collections.Generic;

public class Solution {
    public int LastStoneWeight(int[] stones)
    {
        // Create a max-heap priority queue
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach (var element in stones)
        {
            maxHeap.Enqueue(element, element);
        }

        int num1;
        int num2;
        while (maxHeap.Count > 1)
        {
            num1 = maxHeap.Dequeue();
            num2 = maxHeap.Dequeue();
            maxHeap.Enqueue(num1-num2,num1-num2);
        }
        
        num1 = maxHeap.Dequeue();

        return num1;
    }
}