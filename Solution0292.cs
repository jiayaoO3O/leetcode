namespace leetcode
{
    class Solution0292
    {
        //292.Nim游戏
        //https://leetcode-cn.com/problems/nim-game/
        public bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }
    }
}