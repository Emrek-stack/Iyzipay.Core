using System;

namespace IyzipayCore.Model
{
    public class CardInformation : IRequestStringConvertible
    {
        public String CardAlias { get; set; }
        public String CardNumber { get; set; }
        public String ExpireYear { get; set; }
        public String ExpireMonth { get; set; }
        public String CardHolderName { get; set; }

        public string ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("cardAlias", CardAlias)
                .Append("cardNumber", CardNumber)
                .Append("expireYear", ExpireYear)
                .Append("expireMonth", ExpireMonth)
                .Append("cardHolderName", CardHolderName)
                .GetRequestString();
        }
    }
}
