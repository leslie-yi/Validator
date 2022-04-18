using PhoneNumbers;

namespace phoneNumberValidator
{
    public class ValidateNumber
    {
        public bool IsValidNumber(string aNumber)
        {
            var pUtil = PhoneNumberUtil.GetInstance();
            aNumber = aNumber.Trim();

            //Unsure of what the smsRequest.ToExternalNumber will look like.
            //TODO: Will the number include International Access Code like 00 44 141 441 7054
            //TODO: Will the number format always be with the "+" and International Calling Codes?
            //TODO: Is it only US numbers or all international numbers?

            if (aNumber.StartsWith("00"))
            {
                // Replace 00 at beginning with +
                aNumber = "+" + aNumber.Remove(0, 2);
            }

            try
            {
                var proto = pUtil.Parse(aNumber, "");

                var formatted = pUtil.Format(proto, PhoneNumberFormat.E164);
                bool result = pUtil.IsValidNumber(proto);
                Console.WriteLine($"Formatted: {formatted} \nOriginal: {aNumber}");
                return pUtil.IsValidNumber(proto);

            }
            catch (NumberParseException)
            {
                return false;
            }
        }

    }
}

