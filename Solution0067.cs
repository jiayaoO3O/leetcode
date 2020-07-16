namespace leetcode
{
    class Solution0067
    {
        //67.二进制求和
        //https://leetcode-cn.com/problems/add-binary/
        public string AddBinary(string a, string b)
        {
            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length, '0');
            }
            else
            {
                a = a.PadLeft(b.Length, '0');
            }
            int flag = 0;
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                result = (((int)a[i] - 48 + (int)b[i] - 48 + flag) % 2).ToString() + result;
                flag = ((int)a[i] - 48 + (int)b[i] - 48 + flag) / 2;
            }
            return flag == 1 ? flag + result : result;
        }
    }
}