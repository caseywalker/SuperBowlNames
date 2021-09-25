using System;
using Xunit;

namespace SuperBowlNames.Tests
{
  //Test classes must be public
  public class NumberToRomanNumeralTests
  {
    //Requires an attribute for it to be tested
    //And methods must also be public access modifiers
    [Fact]
    public void the_number_1_is_translated_into_the_letter_I()
    {
      //3 parts. Arrange -> context that the test is run inside of
      var numberToTranslate = 1;
      var expectedResult = "I";
      var translator = new NumberTranslator();

      //Act -> The actual thing we're testing 
      string actualResult = translator.Translate(numberToTranslate);

      //Assert -> Lay out expectations in such a way that, if not met, exceptions are thrown. 
      //if (actualResult != expectedResult)
      //{
      //  throw new Exception($"This is wrong. {actualResult} is not equal to {expectedResult}");
      //}

      Assert.True(actualResult == expectedResult);

      // tests pass if no exceptions are thrown while the test is running
      // tests fail if any exceptions are thrown while the test is running
    }

    [Fact]
    public void the_number_4_should_be_translated_to_IV()
    {

      //Arrange
      var numberToTranslate = 4;
      var expectedResult = "IV";
      var translator = new NumberTranslator();

      //Act
      var actualResult = translator.Translate(numberToTranslate);

      //Assert
      Assert.Equal(expectedResult, actualResult);
    }

    [Fact]
    public void the_number_3_should_be_translated_to_III()
    {

      //Arrange
      var numberToTranslate = 3;
      var expectedResult = "III";
      var translator = new NumberTranslator();

      //Act
      var actualResult = translator.Translate(numberToTranslate);

      //Assert
      Assert.Equal(expectedResult, actualResult);
    }
  }
}
