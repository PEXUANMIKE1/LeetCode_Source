using System.ComponentModel;
using System.Xml;
using System;

namespace RemoveDuplicateSortedArray
{
    public class Program
    {

        /*      26. Remove Duplicates from Sorted Array
                - Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element 
                    appears only once.The relative order of the elements should be kept the same.Then return the number of unique elements in nums.
                - Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:
                - Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums 
                    initially.The remaining elements of nums are not important as well as the size of nums.
                -> Return k.

                example:
                Input: nums = [0,0,1,1,1,2,2,3,3,4]
                Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
                Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
                It does not matter what you leave beyond the returned k (hence they are underscores).

         */


        public int RemoveDuplicate(int[] nums)
        {
            /* Solution:
                Phương án giải quyết: 
                - Nếu mảng rỗng trả về 0, mảng có 1 phần tử trả về 1 luôn - k phải xét làm gì cho mệt;
                - Đầu tiên khởi tạo k = 1 (xét 1 mảng k rỗng thì ít nhất mảng phải có 1 phần tử là duy nhất) 
                - chạy vòng lặp bắt đầu từ phần tử thứ 2 (ở vị trí k luôn - k đóng vai trò là index nằm ngay sau phần tử duy nhất cuối cùng của mảng,
                                                        do mảng bắt đầu bằng 0 nên k sẽ là số lượng phần tử duy nhất luôn)
                    nếu phần tử đang xét arr[i] mà khác với phần tử trước đó arr[i-1] thì gán giá trị khác đó cho phần tử ở vị trí k arr[k] và k++
                    (mục đích là dồn hết các phần tử là duy nhất (không trùng lặp) đứng cạnh nhau, gặp phần tử trùng lặp thì nhảy qua trong khi đó k 
                        đứng ngay sau danh sách phần tử duy nhất để chờ xem có thằng nào khác thì lại gán giá trị vào vị trí k tiếp)

                *Điều kiện: Mảng đã được xắp xếp tăng dần (cái này array input của bài test kết quả đã xắp xếp sẵn cho rồi nên k cần xắp xếp nữa)
            */

            if(nums.Length == 0) return 0;
            if(nums.Length == 1) return 1;
            int k = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])  
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        static void Main(string[] args)
        {
            Program example1 = new Program();
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] nums2 = { 1, 1, 2 };
            Console.WriteLine(example1.RemoveDuplicate(nums1));
            Console.WriteLine(example1.RemoveDuplicate(nums2));
        }
    }
}
