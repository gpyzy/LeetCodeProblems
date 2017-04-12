using System;
namespace LeetCode.Solutions
{
    public static class ExcelColumnSolution
    {
        private static readonly char[] AToZ = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G',
                'H', 'I', 'J', 'K', 'L', 'M', 'N' ,'O','P','Q','R','S','T','U','V','W','X','Y','Z'};

        public static string Solution(int x)
        {
            if (x < 1) return "N/A";

            const int scale = 26;
            var result = string.Empty;
            while (x != 0)
            {
                var modulo = (x - 1) % scale;
                result = AToZ[modulo] + result;
                x = (x - modulo) / 26;
            }

            return result.ToString();
        }
    }
}
