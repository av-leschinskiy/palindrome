namespace Utility
{
    public class PalindromeUtility
    {
        bool checkIsPalindrome(string input) {
           
            var length = input.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
