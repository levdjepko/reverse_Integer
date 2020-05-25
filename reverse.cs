public class Solution {
    public int Reverse(int x) {
        if (x >= 0) {
        string numToString = x.ToString();
        string newString = "";
        for (int i = numToString.Length - 1; i >= 0; i--)
                    {
                        newString += numToString[i];
                    }
                int.TryParse(newString, out int result);
                return result;
        }
        if (x < 0 ) {
            x = x * (-1);
            string numToString = x.ToString();
            string newString = "";
            for (int i = numToString.Length - 1; i >= 0; i--)
                    {
                        newString += numToString[i];
                    }
                int.TryParse(newString, out int result);
                return (result * (-1));
        }
        else return 0;
    }
}
