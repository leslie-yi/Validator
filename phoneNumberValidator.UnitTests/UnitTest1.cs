using Xunit;

namespace phoneNumberValidator.UnitTests;

public class UnitTest1
{
    [Theory]
    [InlineData("+17707707070")] //USA with E164 Format
    [InlineData("001 770 700 2200")] //USA with 00 and whitespace
    [InlineData("0017702192222")] //USA with 00
    [InlineData("00 1 770-219-2222")] //USA with 00 and dashes
    [InlineData("+1770-770-7070")] //USA with E164 Format and dashes
    [InlineData("+57 31 5441 7054")] //Colombia E164 Format
    [InlineData("+57 (31) (8393) (1081)")] //Colombia with "()" and E164 Format
    [InlineData("+33140269300")] //France with E164 Format
    [InlineData("00 44 141 441 7054")] //UK with 00 and whitespace
    [InlineData("+34 915 77 52 39")] //Spain E164 Format
    [InlineData("+82-62-950-6114")] //Korea E164 Format with Dashes
    public void ValidatesTrueForValidPhoneNumberTest(string phoneNumber)
    {
        //Arrange
        var validateNumber = new ValidateNumber();

        //Act
        var result = validateNumber.IsValidNumber(phoneNumber);

        //Assert
        Assert.True(result);

    }

    [Theory]
    [InlineData("")] //Invalid Number
    [InlineData("1")] //Invalid Number
    [InlineData("Howdy")] //Invalid Input
    [InlineData("911")] //Invalid Number
    [InlineData("+999 999 9999")] //Invalid US Number
    [InlineData("+123 123 1234")] //Invalid US Number
    [InlineData("0000000000")] //Invalid US Number
    [InlineData("7707707070")] //Valid Number, BUT without + sign.
    public void ValidatesFalseForValidPhoneNumberTest(string phoneNumber)
    {
        //Arrange
        var validateNumber = new ValidateNumber();

        //Act
        var result = validateNumber.IsValidNumber(phoneNumber);

        //Assert
        Assert.False(result);

    }
}
