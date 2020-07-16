namespace leetcode
{
    class Solution0066
    {
        //66.加一
        //https://leetcode-cn.com/problems/plus-one/
        public int[] PlusOne(int[] digits)
        {
            int flag = 1;
            int digitSum = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digitSum = digits[i] + flag;
                digits[i] = digitSum % 10;
                flag = (digitSum + 1 + flag) / 10;
            }
            if (flag == 0)
            {
                return digits;
            }
            else
            {
                int[] result = new int[digits.Length + 1];
                result[0] = 1;
                digits.CopyTo(result, 1);
                return result;
            }
        }
    }
}