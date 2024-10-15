namespace MergeSortedArray
{
    public class Program
    {
        /* 88. Merge Sorted Array
      
        You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        Merge nums1 and nums2 into a single array sorted in non-decreasing order.

        The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
        
        Example 1:

        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.

        */
        public void merge(int[] nums1, int m, int[] nums2, int n)
        {
            /*
            Ý tưởng của tôi cho bài này là vừa xắp xếp vừa gộp vào luôn 
            - Đầu tiên là tạo các biến index của mảng 1, mảng 2 và vị trí đang xắp xếp (xếp từ cuối lên)
            - lặp luôn trên mảng 1 vì nó dài nhất.
                so sánh giá trị của 2 phần từ cuối của 2 mảng (không tính phần giá trị 0 ở mảng 1)
                thằng nào lớn hơn thì đưa nó vào cuối mảng 1, rồi giảm dần index của nó và giảm luôn index đang xắp xếp.
            - Sau khi lặp hết mảng 1 mà mảng 2 vẫn còn giá trị chưa được đưa vào thì lặp tiếp các
                phần tử còn lại trong mảng 2 rồi đưa lần lượt chúng vào vị trí index đang xắp xếp
            */

            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
                k--;
            }
            while (j >= 0)
            {
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }
        public void outputArray(int[] arr, int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.Write(i == n-1 ? arr[i] : arr[i] + ",");
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6};
            int n = 3;
            program.merge(nums1, m, nums2, n);
            program.outputArray(nums1, n + m);
        }
    }
}
