
using Microsoft.VisualBasic;

Solution solution = new Solution();
solution.TakeCharacters("aabaaaaaaabc", 2);


public class Solution {
    public int TakeCharacters(string s, int k) {
        int[,] right = new int[3,k+1];
        int[,] left = new int[3,k+1];
        int letterCount;
        int[] lettersCount = new int[3];
        char[] letters = new[] { 'a', 'b', 'c' };
        int leftLetterIndex=0;
        int rightLetterIndex=0;
        int length = s.Length;
        char rightLetter;
        char leftLetter;
        bool foundKletters = false;
        bool foundLettersOnLeftFirst = false;
        bool foundLettersOnRightFirst = false;
        int count = -1;
        int i = 0;
        if(k==0){
            return 0;
        }
        /*int aCount = 0;
        int bCount = 0;
        int cCount = 0;*/
        while (!foundKletters)
        {
            leftLetter = s[i];
            rightLetter = s[length-i-1];
            rightLetterIndex = Array.IndexOf(letters, rightLetter);
            letterCount = right[rightLetterIndex, k];
            if (letterCount < k)
            {
                right[rightLetterIndex, letterCount] = i;
                right[rightLetterIndex, k]++;
            }
            lettersCount[rightLetterIndex]++;
            
            if (lettersCount[0] >= k && lettersCount[1] >= k && lettersCount[2] >= k)
            {
                foundKletters = true;
                foundLettersOnRightFirst = true;
                count = i+1;
            }
            
            leftLetterIndex = Array.IndexOf(letters, leftLetter);
            letterCount = left[leftLetterIndex, k];
            if (letterCount < k)
            {
                left[leftLetterIndex, letterCount] = i;
                left[leftLetterIndex, k]++;
            }

            lettersCount[leftLetterIndex]++;
            

            if (lettersCount[0] >= k && lettersCount[1] >= k && lettersCount[2] >= k && !foundLettersOnRightFirst)
            {
                foundKletters = true;
                foundLettersOnLeftFirst = true;
                count = i+1;
            }
            if (i == (length - 1) / 2)
            {
                foundKletters = true;
            }
            Console.WriteLine("right array");
            for (int x = 0; x < right.GetLength(0); x++)
            {
                for (int z = 0; z < right.GetLength(1); z++)
                {
                    Console.Write(right[x, z] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("left array");
            for (int x = 0; x < left.GetLength(0); x++)
            {
                for (int z = 0; z < left.GetLength(1); z++)
                {
                    Console.Write(left[x, z] + " ");
                }
                Console.WriteLine();
            }
            i++;
        }

        if (count==-1)
        {
            
        }
        else if (leftLetterIndex==rightLetterIndex )
        {
            int countLeft = findCount(right, left, k);
            int countRight = findCount(left, right, k);
            if (countLeft <= countRight)
            {
                count += countLeft;
            }
            else
            {
                count += countRight;
            }
        }
        else if (foundLettersOnRightFirst)
        {
            /*if (right[0, k] < k)
            {
                aCount = left[0, right[0, k] - 1] + 1;
            }

            if (right[1, k] < k)
            {
                bCount = left[1, right[1, k] - 1] + 1;
            }

            if (right[2, k] < k)
            {
                cCount = left[2, right[2, k] - 1] + 1;
            }*/
            count += findCount(right, left, k);
        }else if (foundLettersOnLeftFirst)
        {
            /*if (left[0, k] < k)
            {
                aCount = right[0, left[0, k] - 1] + 1;
            }

            if (left[1, k] < k)
            {
                bCount = right[1, left[1, k] - 1] + 1;
            }

            if (left[2, k] < k)
            {
                cCount = right[2, left[2, k] - 1] + 1;
            }*/
            count += findCount(left, right, k);
        }

        /*int[] arr = new[] { aCount, bCount, cCount };*/
        /*count += arr.Max();*/
        Console.WriteLine(count);
        return count;
    }

    public int findCount(int[,] foundFirstSide, int[,] searchSide,int k)
    {
        int aCount = 0;
        int bCount = 0;
        int cCount = 0;
        int biggestCount = 0;
        if (foundFirstSide[0, k] < k)
        {
            aCount = searchSide[0,k- foundFirstSide[0, k] - 1] + 1;
        }

        if (foundFirstSide[1, k] < k)
        {
            bCount = searchSide[1,k- foundFirstSide[1, k] - 1] + 1;
        }

        if (foundFirstSide[2, k] < k)
        {
            cCount = searchSide[2,k- foundFirstSide[2, k] - 1] + 1;
        }
        int[] arr = new[] { aCount, bCount, cCount };
        biggestCount = arr.Max();
        return biggestCount;
    }
}