using System;

namespace IyzipayCore.Request
{
    public class RetrieveCardListRequest : BaseRequest
    {
        public String CardUserKey { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("cardUserKey", CardUserKey)
                .GetRequestString();
        }
    }
}
