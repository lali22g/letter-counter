namespace test_app
{
  /// <summary>
  /// Class <c>LetterCounter</c> models a counter that counts the total number of letters used 
  /// to write out numbers from <c>start</c> to <c>end</c> in words.
  /// </summary>
  public class LetterCounter
  {
    public int Start { get; set; }
    public int End { get; set; }

    public LetterCounter(int start, int end)
    {
      Start = start;
      End = end;
    }

    public int GetCount()
    {
      int currentNumber = Start;
      int total = 0;
      while (currentNumber <= End)
      {
        total += GetSingleNumberLetterCount(currentNumber);
        currentNumber++;
      }
      //   Console.WriteLine(total);

      return total;
    }

    private int GetSingleNumberLetterCount(int number)
    {
      string textRepresentation = GetTextRepresentation(number);
      int textLength = textRepresentation.Length;

      return textLength;
    }

    private string GetTextRepresentation(int number)
    {
      string fullRepresentation = String.Empty;

      int digitAtThousandsPlace = (number / 1000) % 10;
      int digitAtHunderedsPlace = (number / 100) % 10;
      int digitsAtTensAndOnesPlace = number % 100;

      string textForThousandsPlaceDigit = GetThousandsDigitTextRepresentation(digitAtThousandsPlace);
      string textForHunderedsPlaceDigit = GetHunderedsDigitTextRepresentation(digitAtHunderedsPlace);
      string textForTensAndOnesPlaceDigits = GetTensAndOnesDigitsTextRepresentation(digitsAtTensAndOnesPlace);
      string[] textRepresentations = { textForThousandsPlaceDigit, textForHunderedsPlaceDigit, textForTensAndOnesPlaceDigits };

      fullRepresentation = String.Join("and", textRepresentations.Where(textRepresentation => !String.IsNullOrEmpty(textRepresentation)));
      //   Console.WriteLine($"{number}:{fullRepresentation}");

      return fullRepresentation;
    }

    private string GetThousandsDigitTextRepresentation(int digitAtThousandsPlace)
    {
      string fullRepresentation = string.Empty;
      string digitText = LetterUtilities.BasicDigitToText(digitAtThousandsPlace);
      if (!String.IsNullOrEmpty(digitText))
      {
        fullRepresentation = $"{digitText}thousand";
      }

      return fullRepresentation;
    }

    private string GetHunderedsDigitTextRepresentation(int digitAtHunderedthPlace)
    {
      string fullRepresentation = string.Empty;
      string digitText = LetterUtilities.BasicDigitToText(digitAtHunderedthPlace);
      if (!String.IsNullOrEmpty(digitText))
      {
        fullRepresentation = $"{digitText}hundred";
      }

      return fullRepresentation;
    }

    private string GetTensAndOnesDigitsTextRepresentation(int tensAndOnes)
    {
      string fullRepresentation = String.Empty;
      if (tensAndOnes >= 11 && tensAndOnes <= 19)
      {
        fullRepresentation = LetterUtilities.SpecialsToText(tensAndOnes);
      }
      else
      {
        int digitAtTensPlace = tensAndOnes / 10;
        int digitAtOnesPlace = tensAndOnes % 10;
        string tensText = LetterUtilities.TensDigitToText(digitAtTensPlace);
        string onesText = LetterUtilities.BasicDigitToText(digitAtOnesPlace);
        fullRepresentation = $"{tensText}{onesText}";
      }

      return fullRepresentation;
    }
  }
}