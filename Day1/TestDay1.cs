namespace AdventOfCode2023.Day1
{
  internal class TestDay1
  {

    public string testLineConst = "1abc2";
    public string testLineConst2 = "pqr3stu8vwx";
    public string test2LinesConst = "1abc2\r\n" + "pqr3stu8vwx";
    public string test2LinesConstFull = "1abc2\r\n" + "pqr3stu8vwx\r\n" + "a1b2c3d4e5f\r\n" + "treb7uchet";

    public void TestDigits(string testLine)
    {
      FirstAndLastDigitCalcPart2 firstAndLastDigitCalc = new FirstAndLastDigitCalcPart2();
      int[] resultInts = firstAndLastDigitCalc.GetDigitsFromLine(testLine);
      foreach(int digit in resultInts)
      {
        Console.WriteLine(digit.ToString());
      }
    }

    public void TestLineInt(string testLine)
    {
      FirstAndLastDigitCalcPart2 firstAndLast = new FirstAndLastDigitCalcPart2();
      int resultInt = firstAndLast.GetNumberPerLine(testLine);
      Console.WriteLine(resultInt.ToString());
    }

    public void TestLinesInt(string test2Lines)
    {
      string[] linesSeperated = test2Lines.Split("\r\n");
      foreach(string s  in linesSeperated)
      {
        TestLineInt(s);
      }
    }

    public void GetCalibrationResult(string testLinesIn)
    {
      FirstAndLastDigitCalcPart2 firstAndLast = new FirstAndLastDigitCalcPart2();

      string[] linesSeperated = testLinesIn.Split("\r\n");
      int calValue = 0;

      foreach (string s in linesSeperated)
      {
        int resultInt = firstAndLast.GetNumberPerLine(s);
        calValue += resultInt;
      }

      Console.WriteLine(calValue.ToString());
    }
  }
}
