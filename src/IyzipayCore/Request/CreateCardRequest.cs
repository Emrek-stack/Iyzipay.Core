using System;
using IyzipayCore.Model;

namespace IyzipayCore.Request
{
    public class CreateCardRequest : BaseRequest
    {
        public String ExternalId { get; set; }
        public String Email { get; set; }
        public String CardUserKey { get; set; }
        public CardInformation Card { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("externalId", ExternalId)
                .Append("email", Email)
                .Append("cardUserKey", CardUserKey)
                .Append("card", Card)
                .GetRequestString();
        }
    }
}
