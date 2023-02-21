namespace InterviewTest.Tests;

using FluentAssertions;
using InterviewTest;

public class ListStringExtensionsTests
{
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithEmptyList_ShouldReturnEmptyList()
    {
        // arrange
        List<string> listOfStrings = new();
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .BeEmpty();
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithListOfEmptyStrings_ShouldReturnEmptyList()
    {
        // arrange
        List<string> listOfStrings = new() { "", "" };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .BeEmpty();
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithOneValidItem_ShouldReturnExpectedResult()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            "banana"
        };
        List<string> expectedOutcome = new()
        {
            "6-B"
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithValidListOfDifferentStartingCharacters_ShouldReturnExpectedResultInCorrectOrder()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            "banana", "pear", "raspberries", "apple"
        };
        List<string> expectedOutcome = new()
        {
            "11-R", "6-B", "5-A", "4-P"
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithValidListOfSameLengthItems_ShouldReturnExpectedResultInCorrectOrder()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            "pear", "bear", "rare", "care"
        };
        List<string> expectedOutcome = new()
        {
            "4-B", "4-C", "4-P", "4-R"
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithValidListStartingWithSomeSameStartingChars_ShouldReturnExpectedResult()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            "banana", "blackberries", "avocado", "apple"
        };
        List<string> expectedOutcome = new()
        {
            "18-B", "12-A"
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithValidListStartingWithSomeSameStartingCharsInDifferenctCases_ShouldReturnExpectedResult()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            "banana", "Blueberries", "blackberries", "Pear", "Raspberries", "Apple", "avocado"
        };
        List<string> expectedOutcome = new()
        {
            "29-B", "12-A", "11-R", "4-P"
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithValidListOfNumbersStarting_SShouldReturnExpectedResult()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            "1banana", "2Blueberries", "3blackberries", "1Pear", "2Raspberries", "3Apple", "5avocado"
        };
        List<string> expectedOutcome = new()
        {
            "24-2", "19-3", "12-1", "8-5"
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithValidListOfSpecialCharsStarting_ShouldReturnExpectedResult()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            ".banana", "%Blueberries", "/blackberries", ".Pear", "'Raspberries", "'Apple", "/avocado"
        };
        List<string> expectedOutcome = new()
        {
            "21-/", "18-'", "12-%", "12-."
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
    [Fact]
    public void CountAndTotalStringInitialCharacters_WithValidListOfSpacesStarting_SShouldReturnExpectedResult()
    {
        // arrange
        List<string> listOfStrings = new()
        {
            " banana", " Blueberries", " blackberries"
        };
        List<string> expectedOutcome = new()
        {
            "32- "
        };
        // act 
        var outcomeList = listOfStrings.CountAndTotalStringInitialCharacters();
        // assert
        outcomeList.Should()
            .Equal(expectedOutcome);
    }
}