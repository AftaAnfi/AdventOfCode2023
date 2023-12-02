namespace AdventOfCode2023.Day1
{
  internal static class RunningDay1
  {
    public static void Day1Testing()
    {

      TestDay1 testDay1 = new TestDay1();
      //testDay1.TestDigits(testDay1.testLineConst);
      //testDay1.TestLineInt(testDay1.testLineConst);
      //testDay1.TestLineInt(testDay1.testLineConst2);
      //testDay1.TestLinesInt(testDay1.test2LinesConst);
      //testDay1.GetCalibrationResult(testDay1.test2LinesConstFull);
      //testDay1.GetCalibrationResult(testDay1.test2LinesConstFull);

      string calDocStr = File.ReadAllText(@"Day1\CalibrationDocument.txt");
      testDay1.GetCalibrationResult(calDocStr);
    }
  }
}
