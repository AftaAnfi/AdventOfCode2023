namespace AdventOfCode2023.Day1
{
  internal class FirstAndLastDigitCalc
  {
    public int[] GetDigitsFromLine(string line)
    {
      int firstDigit = -1;
      int lastDigit = -1;
      int convertDigit = 0;

      foreach (char c in line)
      {
        if (int.TryParse(c.ToString(), out convertDigit))
        {
          lastDigit = convertDigit;

          if (firstDigit == -1)
          {
            firstDigit = lastDigit;
          }
        }
      }

      return new int[] { firstDigit, lastDigit };
    }

    public int GetNumberPerLine(string line)
    {
      int[] res = GetDigitsFromLine(line);
      return res[0] * 10 + res[1];
    }
    
  }
}
