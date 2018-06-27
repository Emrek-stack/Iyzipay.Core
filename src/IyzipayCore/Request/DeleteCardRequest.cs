using System;

namespace IyzipayCore.Request
{
    public class DeleteCardRequest : BaseRequest
    {
        public String CardUserKey { get; set; }
        public String CardToken { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("cardUserKey", CardUserKey)
                .Append("cardToken", CardToken)
                .GetRequestString();
        }
    }
}
