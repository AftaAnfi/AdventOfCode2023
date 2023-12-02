using AdventOfCode2023.Day1;
using System.Runtime.CompilerServices;

namespace AdventOfCode2023.Day1Part2
{
  internal class TestDay1Part2
  {
    public void Test()
    {
      //TestStartWithDigit();
      //TestGetFirstDigit();
      //TestEndsWithDigit();
      //TestGetLastDigit();
      //TestGetFirstAndLastDigitsAndLineDigit();
      //TestExampleCalibrationValue();


      string calDocStr = File.ReadAllText(@"Day1Part2\CalibrationDocument2.txt");
      Console.WriteLine(GetCalibrationValue(calDocStr));
    }

    private void TestExampleCalibrationValue()
    {
      string exampleStr = "two1nine\r\n" +"eightwothree\r\n" +"abcone2threexyz\r\n" +"xtwone3four\r\n" +"4nineeightseven2\r\n" +"zoneight234\r\n" +"7pqrstsixteen";
      int result = GetCalibrationValue(exampleStr);
      Console.Write(result);
    }

    private void TestStartWithDigit()
    {
      FirstAndLastDigitPart2 newCalc = new();

      Console.WriteLine("\r\n\r\nGetting starts with digit:\r\n");
      Console.WriteLine("one " + newCalc.GetStartsWithNumberFromString("one"));
      Console.WriteLine("2one " + newCalc.GetStartsWithNumberFromString("2one"));
      Console.WriteLine("xxxx " + newCalc.GetStartsWithNumberFromString("xxxx"));
    }

    private void TestGetFirstDigit()
    {
      FirstAndLastDigitPart2 newCalc = new();

      Console.WriteLine("\r\n\r\nGetting first number:\r\n");
      Console.WriteLine("xxtwoone2235 " + newCalc.GetFirstDigit("twoone2235"));
      Console.WriteLine("xx420one2six " + newCalc.GetFirstDigit("420one2six"));
      Console.WriteLine("xet234420one2six " + newCalc.GetFirstDigit("xet234420one2six"));
    }

    private void TestEndsWithDigit()
    {
      FirstAndLastDigitPart2 newCalc = new();

      Console.WriteLine("\r\n\r\nGetting ends with digit:\r\n");
      Console.WriteLine("one " + newCalc.GetEndsWithNumberFromString("one"));
      Console.WriteLine("2one3 " + newCalc.GetEndsWithNumberFromString("2one3"));
      Console.WriteLine("xxxx " + newCalc.GetEndsWithNumberFromString("xxxx"));
    }

    private void TestGetLastDigit()
    {
      FirstAndLastDigitPart2 newCalc = new();

      Console.WriteLine("\r\n\r\nGetting last number:\r\n");
      Console.WriteLine("one " + newCalc.GetLastDigit("one"));
      Console.WriteLine("2one3 " + newCalc.GetLastDigit("2one3"));
      Console.WriteLine("xxxx " + newCalc.GetLastDigit("xxxx"));
      Console.WriteLine("xxtwoone2235 " + newCalc.GetLastDigit("twoone2235"));
      Console.WriteLine("xx420one2six " + newCalc.GetLastDigit("420one2six"));
      Console.WriteLine("xet234420one2six " + newCalc.GetLastDigit("xet234420one2six"));
    }

    private void TestGetFirstAndLastDigitsAndLineDigit()
    {
      FirstAndLastDigitPart2 newCalc = new();


      string[] testStr =
      {
        "oned",
        "sdf2one",
        "xxxx",
        "twoone223525fs",
        "420one2six",
        "xet234420one2sixeffs",
      };


      Console.WriteLine("\r\n\r\nTesting first and last:\r\n");

      foreach (string str in testStr)
      {
        int[] retInts = newCalc.GetFirstAndLastDigit(str);

        Console.WriteLine(str + " " + retInts[0] + " " + retInts[1] + "\tResult: " + newCalc.GetLineDigit(str));
      }

    }

    private int GetCalibrationValue(string s)
    {
      int totalTimesRun = 0;
      int calValue = 0;
      string[] lines = s.Split("\r\n");

      FirstAndLastDigitPart2 newCalc = new();

      foreach(string line in lines)
      {
        totalTimesRun++;
        int lineVal = newCalc.GetLineDigit(line);
        Console.WriteLine(lineVal);
       
        if(lineVal != -1)
        {
          calValue += lineVal;
        }
      }

      Console.WriteLine($"Total Lines read: {totalTimesRun}");

      return calValue;
    }

  }


}
