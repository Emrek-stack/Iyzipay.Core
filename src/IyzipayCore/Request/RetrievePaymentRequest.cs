using System;

namespace IyzipayCore.Request
{
   public class RetrievePaymentRequest : BaseRequest
    {
        public String PaymentId { get; set; }
        public String PaymentConversationId { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentId", PaymentId)
                .Append("paymentConversationId", PaymentConversationId)             
                .GetRequestString();
        }
    }
}
