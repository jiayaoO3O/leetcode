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

        //125.验证回文串
        //https://leetcode-cn.com/problems/valid-palindrome/
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            foreach (var c in s)
            {
                if (c >= 'a' && c <= 'z' || c >= '0' && c <= '9')
                {
                    result.Append(c);
                }
            }
            for (int i = 0; i < result.Length / 2; i++)
            {
                if (result[i] != result[result.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        //136.只出现一次的数字
        //https://leetcode-cn.com/problems/single-number/
        public int SingleNumber(int[] nums)
        {
            int n = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                n = n ^ nums[i];
            }
            return n;
        }

        //141.环形链表
        //https://leetcode-cn.com/problems/linked-list-cycle/
        public bool HasCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }

        //155.最小栈
        //https://leetcode-cn.com/problems/min-stack/
        public class MinStack
        {
            int[] stack = new int[10000];
            Stack<int> min = new Stack<int>();
            int i = -1;
            public MinStack() { }
            public void Push(int x)
            {
                if (min.Count == 0 || x <= min.Peek())
                {
                    min.Push(x);
                }
                stack[i++] = x;
            }

            public void Pop()
            {
                if (stack[i] == min.Peek())
                {
                    min.Pop();
                }
                i--;
            }
            public int Top()
            {
                return stack[i];
            }
            public int GetMin()
            {
                return min.Peek();
            }
        }

        //160.相交链表
        //https://leetcode-cn.com/problems/intersection-of-two-linked-lists/
        public int CountNode(ListNode list)
        {
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.next;
            }
            return count;
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headB == null || headA == null)
            {
                return null;
            }
            int CountA = CountNode(headA);
            int CountB = CountNode(headB);
            if (CountA > CountB)
            {
                for (int i = 0; i < CountA - CountB; i++)
                {
                    headA = headA.next;
                }
            }
            else
            {
                for (int i = 0; i < CountB - CountA; i++)
                {
                    headB = headB.next;
                }
            }
            while (headA != null)
            {
                if (headA == headB)
                {
                    return headA;
                }
                headA = headA.next;
                headB = headB.next;
            }
            return null;
        }

        //167.两数之和 II - 输入有序数组
        //https://leetcode-cn.com/problems/two-sum-ii-input-array-is-sorted/
        public int[] TwoSumII(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else
                {
                    if (numbers[left] + numbers[right] < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return new int[] { };
        }

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
    }
}