using System;

namespace IyzipayCore.Request
{
    public class CreateThreedsPaymentRequest : BaseRequest
    {
        public String PaymentId { get; set; }
        public String ConversationData { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentId", PaymentId)
                .Append("conversationData", ConversationData)
                .GetRequestString();
        }
    }
}
