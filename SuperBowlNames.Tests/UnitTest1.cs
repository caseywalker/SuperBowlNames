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

    [Theory]
    [InlineData(1, "I")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    [InlineData(5, "V")]
    [InlineData(8, "VIII")]
    [InlineData(15, "XV")]
    [InlineData(17, "XVII")]
    [InlineData(11, "XI")]
    [InlineData(14, "XIV")]
    [InlineData(19, "XIX")]
    [InlineData(39, "XXXIX")]
    [InlineData(29, "XXIX")]
    [InlineData(24, "XXIV")]
    [InlineData(45, "XLV")]
    public void given_a_number_the_it_is_translated_to_roman_numeral(int numberToTranslate, string expectedResult)
    {
      //Arrange
      var translator = new NumberTranslator();

      //Act
      var actualResult = translator.Translate(numberToTranslate);

      //Assert
      Assert.Equal(expectedResult, actualResult);
    }


  }
}
