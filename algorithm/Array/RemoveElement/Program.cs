namespace RemoveElement
{
    public class Program
    {
        /*  27. Remove Element
             Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.The order of the
             elements may be changed.Then return the number of elements in nums which are not equal to val.
             Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
            
            - Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining
                elements of nums are not important as well as the size of nums.
            -> Return k.
        */
        public int RemoveElement(int[] nums, int val)
        {
            /* Solution: 
                 Chỉ đơn giản là đặt k ở vị trí đầu mảng. Duyệt mảng đến khi nào phần tử đang duyệt khác val thì gán phần tử đó cho phần tử vị trí k arr[k] 
                 rồi tiếp tục tăng k lên 1
            */
            int k = 0;
            int length = nums.Length;
            for (int i = 0; i < length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
            Console.WriteLine(program.RemoveElement(nums, 2));

        }
    }
}
