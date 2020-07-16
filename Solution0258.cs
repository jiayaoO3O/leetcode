namespace leetcode
{
    class Solution0258
    {
        //258.各位相加
        //https://leetcode-cn.com/problems/add-digits/
        public int AddDigits(int num)
        {
            if (num > 9)
            {
                num = num % 9;
                if (num == 0)
                {
                    return 9;
                }
            }
            return num;
            // if (num < 10)
            // {
            //     return num;
            // }
            // int result = 0;
            // while (num >= 10)
            // {
            //     result = 0;
            //     while (num != 0)
            //     {
            //         result += num % 10;
            //         num /= 10;
            //     }
            //     num = result;
            // }
            // return num;
        }
    }
}