namespace AdventOfCode2023.Day1Part2
{

  internal class FirstAndLastDigitPart2
  {
    public int GetStartsWithNumberFromString(string s)
    {
      int retInt = -1;

      if (s.StartsWith("1"))
        return 1;

      if (s.StartsWith("one"))
        return 1;

      if (s.StartsWith("2"))
        return 2;

      if (s.StartsWith("two"))
        return 2;

      if (s.StartsWith("3"))
        return 3;

      if (s.StartsWith("three"))
        return 3;

      if (s.StartsWith("4"))
        return 4;

      if (s.StartsWith("four"))
        return 4;

      if (s.StartsWith("5"))
        return 5;

      if (s.StartsWith("five"))
        return 5;

      if (s.StartsWith("6"))
        return 6;

      if (s.StartsWith("six"))
        return 6;

      if (s.StartsWith("7"))
        return 7;

      if (s.StartsWith("seven"))
        return 7;

      if (s.StartsWith("8"))
        return 8;

      if (s.StartsWith("eight"))
        return 8;

      if (s.StartsWith("9"))
        return 9;

      if (s.StartsWith("nine"))
        return 9;

      if (s.StartsWith("0"))
        return 0;

      return retInt;
    }

    public int GetFirstDigit(string stringIn)
    {
      string tempString = stringIn;

      int numFromString = -1;

      for (int i = 0; i < stringIn.Length; i++)
      {

        numFromString = GetStartsWithNumberFromString(tempString);

        if (numFromString != -1)
        {
          return numFromString;
        }

        tempString = tempString.Remove(0, 1);

      }

      return numFromString;

    }

    public int GetEndsWithNumberFromString(string s)
    {
      int retInt = -1;

      if (s.EndsWith("1"))
        return 1;

      if (s.EndsWith("one"))
        return 1;

      if (s.EndsWith("2"))
        return 2;

      if (s.EndsWith("two"))
        return 2;

      if (s.EndsWith("3"))
        return 3;

      if (s.EndsWith("three"))
        return 3;

      if (s.EndsWith("4"))
        return 4;

      if (s.EndsWith("four"))
        return 4;

      if (s.EndsWith("5"))
        return 5;

      if (s.EndsWith("five"))
        return 5;

      if (s.EndsWith("6"))
        return 6;

      if (s.EndsWith("six"))
        return 6;

      if (s.EndsWith("7"))
        return 7;

      if (s.EndsWith("seven"))
        return 7;

      if (s.EndsWith("8"))
        return 8;

      if (s.EndsWith("eight"))
        return 8;

      if (s.EndsWith("9"))
        return 9;

      if (s.EndsWith("nine"))
        return 9;

      if (s.EndsWith("0"))
        return 0;

      return retInt;
    }

    public int GetLastDigit(string s)
    {
      string tempString = s;

      int numFromString = -1;

      for (int i = s.Length-1; i >= 0; i--)
      {

        numFromString = GetEndsWithNumberFromString(tempString);

        if (numFromString != -1)
        {
          return numFromString;
        }

        tempString = tempString.Remove(tempString.Length - 1, 1);

      }

      return numFromString;
    }

    public int[] GetFirstAndLastDigit(string s)
    {
      return new int[] { GetFirstDigit(s), GetLastDigit(s) };
    }

    public int GetLineDigit(string s)
    {
      return (GetFirstDigit(s) * 10) + GetLastDigit(s);
    }

  }
}
