using LeetCode.Easy;
using LeetCode.Medium;

namespace LeetCode
{
    public class LeetCode()
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 8));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 4));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 5));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 6));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 7));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 1));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 2));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 3));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 8, 1, 2, 3], 9));
            Console.WriteLine(SearchRotatedSortedArray.Search([3, 5, 1], 0));
            Console.WriteLine(SearchRotatedSortedArray.Search([3, 1], 0));
            Console.WriteLine(SearchRotatedSortedArray.Search([1, 3], 3));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7], 2));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7], 4));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7], 5));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7], 6));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7], 7));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7], 8));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 2));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 1));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 0));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 7));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 6));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 5));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 4));
            Console.WriteLine(SearchRotatedSortedArray.Search([4, 5, 6, 7, 0, 1, 2], 4));
            Console.WriteLine(SearchRotatedSortedArray.Search([1], 0));
            Console.WriteLine(SearchRotatedSortedArray.Search([1], 1));
            Console.WriteLine(SearchRotatedSortedArray.Search([1], 2));
        }
    }
}

    
