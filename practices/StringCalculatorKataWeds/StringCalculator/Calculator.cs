
public class Calculator
{
    public int Add(string numbers)
    {
        int ret = 0;

        if (numbers == "")
            return 0;

        if (numbers.Length == 1 || numbers.Length == 2)
            return int.Parse(numbers);

        else if (numbers.Length >= 3)
        {
            int indexOne;
            bool flag = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (flag)
                {
                    flag = false;
                    continue;
                }

                if (numbers[i] == '-')
                {
                    indexOne = -1 * int.Parse(numbers[i + 1].ToString());
                    flag = true;
                }
                else
                    int.TryParse(numbers[i].ToString(), out indexOne);

                ret += indexOne;
            }
        }
        return ret;
    }
}
