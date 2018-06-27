using System;

namespace IyzipayCore.Request
{
    public class CreateRefundRequest : BaseRequest
    {
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }
        public String Ip { get; set; }
        public String Currency { get; set; }
        public String Reason { get; set; }
        public String Description { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentTransactionId", PaymentTransactionId)
                .AppendPrice("price", Price)
                .Append("ip", Ip)
                .Append("currency", Currency)
                .Append("reason", Reason)
                .Append("description", Description)
                .GetRequestString();
        }
    }
}
