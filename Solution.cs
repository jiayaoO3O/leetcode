using System;
using System.Collections.Generic;

namespace leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class Solution
    {
        //1.两数之和
        //https://leetcode-cn.com/problems/two-sum/
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }

        //7.整数反转
        //https://leetcode-cn.com/problems/reverse-integer/
        public int Reverse(int x)
        {
            int n = 0;
            int result = 0;
            while (x != 0)
            {
                result = n * 10 + x % 10;
                if (result / 10 != n)//不等于n说明溢出了.
                {
                    return 0;
                }
                x /= 10;
                n = result;
            }
            return result;
        }

        //9.回文数
        //https://leetcode-cn.com/problems/palindrome-number/
        public bool IsPalindrome(int x)
        {
            //直接转换字符串.
            // string str = x.ToString();
            // for (int i = 0; i < str.Length / 2; i++)
            // {
            //     if (str[i] != str[str.Length - i - 1])
            //     {
            //         return false;
            //     }
            // }
            // return true;
            if (x < 0)
            {
                return false;
            }
            else
            {
                int num = x;
                int result = 0;
                while (num != 0)
                {
                    result = result * 10 + num % 10;
                    num /= 10;
                }
                return result == x ? true : false;
            }
        }

        //13.罗马数字转整数
        //https://leetcode-cn.com/problems/roman-to-integer/comments/
        public int RomanToInt(string s)
        {

            Dictionary<char, int> romanNumber = new Dictionary<char, int> {
                { 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },
                { 'C', 100 },{ 'D', 500 },{ 'M', 1000 }
            };
            int result = romanNumber[s[s.Length - 1]];
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (romanNumber[s[i]] < romanNumber[s[i + 1]])
                {
                    result -= romanNumber[s[i]];
                }
                else
                {
                    result += romanNumber[s[i]];
                }
            }
            return result;
        }

        //14.最长公共前缀
        //https://leetcode-cn.com/problems/longest-common-prefix/comments/
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            for (int i = 0; i < strs[0].Length; ++i)
            {
                for (int j = 1; j < strs.Length; ++j)
                {
                    if (strs[j].Length <= i || strs[0][i] != strs[j][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }

        //20.有效的括号
        //https://leetcode-cn.com/problems/valid-parentheses/
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char symbol = stack.Pop();
                        if (s[i] == ')' && symbol != '(' || s[i] == ']' && symbol != '[' || s[i] == '}' && symbol != '{')
                        {
                            return false;
                        }
                    }
                }

            }
            return stack.Count == 0;
        }

        //21.合并两个有序链表
        //https://leetcode-cn.com/problems/merge-two-sorted-lists/comments/
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode(0);
            ListNode head = node;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    node.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    node.next = l2;
                    l2 = l2.next;
                }
                node = node.next;
            }
            node.next = l1 == null ? l1 : l2;
            return head.next;
        }

        //26.删除排序数组中的重复项
        //https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/submissions/
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])//用快慢指针解决,后面的数覆盖前面的重复值.
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }

        //27.移除元素
        //https://leetcode-cn.com/problems/remove-element/
        public int RemoveElement(int[] nums, int val)
        {
            int n = nums.Length;
            for (int i = 0; i < n;)
            {
                if (nums[i] == val)
                {
                    n--;
                    nums[i] = nums[n];
                }
                else
                {
                    i++;
                }
            }
            return n;
        }

        //28.实现strStr()
        //https://leetcode-cn.com/problems/implement-strstr/
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }

        //35.搜索插入位置
        //https://leetcode-cn.com/problems/search-insert-position/
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;//如果前面的循环都找不到插入位置说明在最后面一个
        }

        //53.最大子序和
        //https://leetcode-cn.com/problems/maximum-subarray/
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sum = sum < 0 ? 0 : sum;

                max = sum > max ? sum : max;
            }
            return max;
        }

        //58.最后一个单词的长度
        //https://leetcode-cn.com/problems/length-of-last-word/
        public int LengthOfLastWord(string s)
        {
            return s.Trim().Split()[s.Trim().Split().Length - 1].Length;
        }

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

        //69.x的平方分根
        //https://leetcode-cn.com/problems/sqrtx/
        //用牛顿迭代法求平方根非常好用,建议背下来.
        //https://www.guokr.com/question/461510/
        public int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            double r = x;
            for (int i = 0; i < 20; i++)
            {
                r = (r + x / r) / 2;
            }
            return (int)r;
        }

        //70.爬楼梯
        //https://leetcode-cn.com/problems/climbing-stairs/
        //这一题是很典型的动态规划问题,可以去看看这个推文:
        //https://mp.weixin.qq.com/s/3h9iqU4rdH3EIy5m6AzXsg
        public int ClimbStairs(int n)
        {
            //if (n==1||n==0)//递归操作;
            //{
            //    return 1;
            //}
            //else
            //{
            //    return ClimbStairs(n - 1) + ClimbStairs(n - 2);
            //}
            if (n == 1 || n == 0 || n == 2)
            {
                return n;
            }
            int[] r = new int[n + 1];//定义一个数组,接收每一层楼梯的走法
            r[1] = 1;
            r[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                r[i] = r[i - 1] + r[i - 2];
            }
            return r[n];
        }

        //83.删除排序链表中的重复元素
        //https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode node = head;
            while (node.next != null)
            {
                if (node.next.val == node.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }
            return head;
        }

        //100.相同的树
        //https://leetcode-cn.com/problems/same-tree/
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null && q != null || p != null && q == null)
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }
            else
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
        }

        //101.对称二叉树
        //https://leetcode-cn.com/problems/symmetric-tree/
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymmetricTree(root, root);
        }
        public bool IsSymmetricTree(TreeNode p, TreeNode q)
        {
            if (p != null && q == null || p == null && q != null)
            {
                return false;
            }
            else
            {
                return (p == null && q == null) || (p.val == q.val) && IsSymmetricTree(p.left, q.right) && IsSymmetricTree(p.right, q.left);
            }
        }

        //104.二叉树的最大深度
        //https://leetcode-cn.com/problems/maximum-depth-of-binary-tree/
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
            }
        }

        //121.买卖股票的最佳时机
        //https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 0)
            {
                return 0;
            }
            int minPrice = prices[0], maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
                minPrice = Math.Min(minPrice, prices[i]);
            }
            return maxProfit;
        }
    }
}