public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int Length = RealizeLength(digits);
        int[] result = new int[Length];
        digits = digits.Reverse().ToArray();
        int index = 1;

        for (int i = 0; i < digits.Length; i++)
        {
            result[i] = digits[i] + index;
            index = 0;
            if (result[i] == 10 && i + 1 != digits.Length)
            {
                result[i] = 0;
                index = 1;
            }
            if (result[i] == 10 && i + 1 == digits.Length)
            {
                index = 1;
                result[i] = 0;
                result[i + 1] = index;
            }



        }

        return result.Reverse().ToArray();
    }
    public int RealizeLength(int[] digits)
    {
        for (int s = 0; s < digits.Length; s++)
        {
            if (digits[s] != 9)
            {
                return digits.Length;
            }
        }
        return digits.Length + 1;
    }
}