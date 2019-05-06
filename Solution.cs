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
    }
}