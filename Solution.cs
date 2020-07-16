using System;
using System.Collections.Generic;

namespace leetcode
{
    // public class ListNode
    // {
    //     public int val;
    //     public ListNode next;
    //     public ListNode(int x) { val = x; }
    // }
    // public class TreeNode
    // {
    //     public int val;
    //     public TreeNode left;
    //     public TreeNode right;
    //     public TreeNode(int x) { val = x; }
    // }
    class Solution
    {

        //169.求众数
        //https://leetcode-cn.com/problems/majority-element/
        public int MajorityElement(int[] nums)
        {
            // Array.Sort(nums);
            // return nums[nums.Length / 2];
            Dictionary<int, int> numsInfo = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (numsInfo.ContainsKey(num))
                {
                    numsInfo[num]++;
                }
                else
                {
                    numsInfo.Add(num, 1);
                }
                if (numsInfo[num] > nums.Length / 2)
                {
                    return num;
                }
            }
            return 0;
        }

        //172.阶乘后的零
        //https://leetcode-cn.com/problems/factorial-trailing-zeroes/
        public int TrailingZeroes(int n)
        {
            int count = 0;
            while (n > 1)
            {
                count = count + n / 5;
                n = n / 5;
            }
            return count;
        }

        //190.颠倒二进制位
        //https://leetcode-cn.com/problems/reverse-bits/
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                result += n & 1;
                n >>= 1;
            }
            return result;
        }

        //191.位1的个数
        //https://leetcode-cn.com/problems/number-of-1-bits/
        public int HammingWeight(uint n)
        {
            // string s = Convert.ToString(n, 2);
            // int count = 0;
            // for (int i = 0; i < s.Length; i++)
            // {
            //     if (s[i] == '1')
            //     {
            //         count++;
            //     }
            // }
            // return count;
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                {
                    result++;
                }
                n = n >> 1;
            }
            return result;
        }

        //198.打家劫舍
        //https://leetcode-cn.com/problems/house-robber/
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int[] sum = new int[nums.Length];
            sum[0] = nums[0];
            sum[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < sum.Length; i++)
            {
                sum[i] = Math.Max(sum[i - 1], sum[i - 2] + nums[i]);
            }
            return sum[sum.Length - 1];
        }

        //202.快乐数
        //https://leetcode-cn.com/problems/happy-number/
        public bool IsHappy(int n)
        {
            int result = 0;
            HashSet<int> used = new HashSet<int>();
            while (!used.Contains(result))
            {
                used.Add(result);
                result = 0;
                while (n != 0)
                {
                    result = result + (n % 10) * (n % 10);
                    n = n / 10;
                }
                if (result == 1)
                {
                    return true;
                }
                n = result;
            }
            return false;
        }

        //203.删除链表中的节点
        //https://leetcode-cn.com/problems/remove-linked-list-elements/
        public ListNode RemoveElements(ListNode head, int val)
        {
            // ListNode p = new ListNode(-1)
            // {
            //     next = head
            // };
            // ListNode h = p;
            // while (p.next != null)
            // {
            //     if (p.next.val == val)
            //     {
            //         p.next = p.next.next;
            //         continue;
            //     }
            //     p = p.next;
            // }
            // return h.next;
            if (head == null)
            {
                return null;
            }
            if (head.val == val)
            {
                return RemoveElements(head.next, val);
            }
            else
            {
                head.next = RemoveElements(head.next, val);
            }
            return head;
        }

        //205.同构字符串
        //https://leetcode-cn.com/problems/isomorphic-strings/
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> strInfo = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!strInfo.ContainsKey(s[i]))
                {
                    if (strInfo.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    strInfo.Add(s[i], t[i]);
                }
                else
                {
                    if (strInfo[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        //206.反转链表
        //https://leetcode-cn.com/problems/reverse-linked-list/
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            // ListNode newLinkedList = null;//创建一个新的链表.
            // while (head != null)
            // {
            //     ListNode tempNode = head.next;//创建临时链表存放头节点的尾巴.
            //     head.next = newLinkedList;//将新链表接到头节点后面.
            //     newLinkedList = head;//再次成为新链表.
            //     head = tempNode;//将临时链表覆盖原链表.
            // }
            // return newLinkedList;
            ListNode newLinkedList = ReverseList(head.next);//接收已经反转了的链表.
            head.next.next = head;//将2(head.next)的下一个节点(next)变为1(head).
            head.next = null;//将1(head)的下一个节点变为null.
            return newLinkedList;
        }

        //217.存在重复元素
        //https://leetcode-cn.com/problems/contains-duplicate/
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return false;
            }
            Array.Sort(nums);
            // for (int i = 1; i < nums.Length; i++)
            // {
            //     if (nums[i] == nums[i - 1])
            //     {
            //         return true;
            //     }
            // }
            HashSet<int> numSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (numSet.Contains(num))
                {
                    return true;
                }
                else
                {
                    numSet.Add(num);
                }
            }
            return false;
        }

        //225.用队列实现栈
        //https://leetcode-cn.com/problems/implement-stack-using-queues/
        public class MyStack
        {
            Queue<int> queue = new Queue<int>();
            public MyStack() { }
            public void Push(int x)
            {
                queue.Enqueue(x);
                for (int i = 0; i < queue.Count - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
            public int Pop()
            {
                return queue.Dequeue();
            }
            public int Top()
            {
                return queue.Peek();
            }
            public bool Empty()
            {
                return queue.Count > 0 ? false : true;
            }
        }

        //231.2的幂
        //https://leetcode-cn.com/problems/power-of-two/
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        //232.用栈实现队列
        //https://leetcode-cn.com/problems/implement-queue-using-stacks/
        public class MyQueue
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            public MyQueue()
            {
            }
            public void Push(int x)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
                stack1.Push(x);
                while (stack2.Count != 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }
            public int Pop()
            {
                return stack1.Pop();
            }
            public int Peek()
            {
                return stack1.Peek();
            }
            public bool Empty()
            {
                return stack1.Count > 0 ? false : true;
            }
        }

        //234.回文链表
        //https://leetcode-cn.com/problems/palindrome-linked-list/
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            ListNode newLinkedList = null;//创建一个新的链表.
            while (slow != null)
            {
                ListNode tempNode = slow.next;//创建临时链表存放头节点的尾巴.
                slow.next = newLinkedList;//将新链表接到头节点后面.
                newLinkedList = slow;//再次成为新链表.
                slow = tempNode;//将临时链表覆盖原链表.
            }
            slow = newLinkedList;
            while (slow != null)
            {
                if (slow.val != head.val)
                {
                    return false;
                }
                slow = slow.next;
                head = head.next;
            }
            return true;
        }

        //237.删除链表中的节点
        //https://leetcode-cn.com/problems/delete-node-in-a-linked-list/
        //神题.
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;//用下一个节点的数据覆盖当前节点.
            node.next = node.next.next;//删除下一个节点.
        }

        //242.有效的字母异位词
        //https://leetcode-cn.com/problems/valid-anagram/
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            // char[] str1 = s.ToCharArray();
            // char[] str2 = t.ToCharArray();
            // Array.Sort(str1);
            // Array.Sort(str2);
            // for (int i = 0; i < str1.Length; i++)
            // {
            //     if (str1[i] != str2[i])
            //     {
            //         return false;
            //     }
            // }
            // return true;
            var charDict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (charDict.ContainsKey(c))
                {
                    charDict[c]++;
                }
                else
                {
                    charDict.Add(c, 1);
                }
            }
            foreach (var c in t)
            {
                if (charDict.ContainsKey(c))
                {
                    if (--charDict[c] == 0)
                    {
                        charDict.Remove(c);
                    }
                }
                else
                {
                    return false;
                }
            }
            return charDict.Count == 0;
        }

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

        //263.丑数
        //https://leetcode-cn.com/problems/ugly-number/
        public bool IsUgly(int num)
        {
            if (num <= 1)
            {
                return (num == 1) ? true : false;
            }
            while (num % 2 == 0)
            {
                num /= 2;
            }
            while (num % 3 == 0)
            {
                num /= 3;
            }
            while (num % 5 == 0)
            {
                num /= 5;
            }
            return num == 1;
        }

        //268.缺失数字
        //https://leetcode-cn.com/problems/missing-number/
        public int MissingNumber(int[] nums)
        {
            // Array.Sort(nums);
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (i != nums[i])
            //     {
            //         return i;
            //     }
            // }
            // return nums[nums.Length - 1] + 1;
            int sum = (nums.Length * (nums.Length + 1)) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            return sum;
        }

        //278.第一个错误的版本
        //https://leetcode-cn.com/problems/first-bad-version/
        public int FirstBadVersion(int n)
        {
            int left = 1, right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        private bool IsBadVersion(int mid) => throw new NotImplementedException();
        //这个函数放在这个位置是没有意义的.
        //唯一的目的是为了让代码不报错.
        //提交时不需要写这个函数.

        //283.移动零
        //https://leetcode-cn.com/problems/move-zeroes/
        public void MoveZeroes(int[] nums)
        {
            int flag = 0;
            foreach (int num in nums)
            {
                if (num != 0)
                {
                    nums[flag] = num;
                    flag += 1;
                }
            }
            for (int i = flag; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        //292.Nim游戏
        //https://leetcode-cn.com/problems/nim-game/
        public bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }

        //326.3的幂
        //https://leetcode-cn.com/problems/power-of-three/
        public bool IsPowerOfThree(int n)
        {
            if (n == 0)
            {
                return false;
            }
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}