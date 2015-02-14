using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());
        int firstPosition = int.Parse(Console.ReadLine());
        int secondPosition = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        if (firstPosition + length > 32 || secondPosition + length > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if ((firstPosition > secondPosition && secondPosition + length >= firstPosition) ||
            (secondPosition > firstPosition && firstPosition + length >= secondPosition) ||
            (firstPosition == secondPosition))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            for (int cnt = 0; cnt < length; cnt++)
            {
                uint firstValue = (uint)(num >> (firstPosition + cnt)) & 1;
                uint secondValue = (uint)(num >> (secondPosition + cnt)) & 1;
                if (firstValue == 1 && secondValue == 0)
                {
                    num -= (uint)(1 << (firstPosition + cnt));
                    num += (uint)(1 << (secondPosition + cnt));
                }

                if (secondValue == 1 && firstValue == 0)
                {
                    num += (uint)(1 << (firstPosition + cnt));
                    num -= (uint)(1 << (secondPosition + cnt));
                }
            }
            Console.WriteLine(num);
        }
    }
}