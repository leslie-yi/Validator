// See https://aka.ms/new-console-template for more information
using phoneNumberValidator;

Console.WriteLine("Staring the test...");


var validateNumber = new ValidateNumber();

Console.WriteLine(validateNumber.IsValidNumber("11")); //Returns Invalid
Console.WriteLine(validateNumber.IsValidNumber("001231231234")); //Returns Invalid
Console.WriteLine(validateNumber.IsValidNumber("00 000 000 0000")); //Returns Invaalid
Console.WriteLine(validateNumber.IsValidNumber("123 123 1234")); //Returns Invalid
Console.WriteLine(validateNumber.IsValidNumber("911")); //Returns Invalid
Console.WriteLine(validateNumber.IsValidNumber("000 000 000")); //Returns Invalid

Console.WriteLine("-----------------------------------------------");
Console.WriteLine($"USA: {validateNumber.IsValidNumber("+14702192241")}"); //Returns Valid
Console.WriteLine($"USA: {validateNumber.IsValidNumber("+1 470-219-2241")}"); //Returns Valid
Console.WriteLine($"USA with Dashes: {validateNumber.IsValidNumber("00 1 770-219-2222")}"); //Returns Valid
Console.WriteLine($"UK: {validateNumber.IsValidNumber("00 44 141 441 7054")}"); //Returns Valid
Console.WriteLine($"FR: {validateNumber.IsValidNumber("+33140269300")}");
Console.WriteLine($"COL: {validateNumber.IsValidNumber("+57 31 5441 7054")}");//Returns Valid
Console.WriteLine($"ES: {validateNumber.IsValidNumber("+34 915 77 52 39")}");//Returns Valid 
Console.WriteLine($"KOR: {validateNumber.IsValidNumber("+82-62-950-6114")}");//Returns Valid 
Console.WriteLine(validateNumber.IsValidNumber("+57 (31) (8393) (1081)")); //Returns Valid

Console.WriteLine("End of test...");