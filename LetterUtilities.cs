namespace test_app
{
  public static class LetterUtilities
  {
    internal static string BasicDigitToText(int digit)
    {
      switch (digit)
      {
        case 1:
          return "one";
        case 2:
          return "two";
        case 3:
          return "three";
        case 4:
          return "four";
        case 5:
          return "five";
        case 6:
          return "six";
        case 7:
          return "seven";
        case 8:
          return "eight";
        case 9:
          return "nine";
        case 0:
        default:
          return String.Empty;
      }
    }

    internal static string SpecialsToText(int number)
    {
      switch (number)
      {
        case 11:
          return "eleven";
        case 12:
          return "twelve";
        case 13:
          return "thirteen";
        case 14:
          return "fourteen";
        case 15:
          return "fifteen";
        case 16:
          return "sixteen";
        case 17:
          return "seventeen";
        case 18:
          return "eighteen";
        case 19:
          return "nineteen";
        default:
          return String.Empty;
      }
    }

    internal static string TensDigitToText(int digit)
    {
      switch (digit)
      {
        case 1:
          return "ten";
        case 2:
          return "twenty";
        case 3:
          return "thirty";
        case 4:
          return "forty";
        case 5:
          return "fifty";
        case 6:
          return "sixty";
        case 7:
          return "seventy";
        case 8:
          return "eighty";
        case 9:
          return "ninety";
        case 0:
        default:
          return String.Empty;
      }
    }
  }
}