
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
            //string temp = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                //while (numbers[i] != ',')
                //{
                //    temp += numbers[i];
                //}

                if (numbers[i] == '-')
                {
                    indexOne = -1 * int.Parse(numbers[i + 1].ToString());
                    i += 2;
                }
                else
                    int.TryParse(numbers[i].ToString(), out indexOne);

                ret += indexOne;
            }
        }
        return ret;
    }
}
