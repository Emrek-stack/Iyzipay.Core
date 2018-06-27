using System;

namespace IyzipayCore.Request
{
    public class CreatePaymentPostAuthRequest : BaseRequest
    {
        public String PaymentId { get; set; }
        public String PaidPrice { get; set; }
        public String Ip { get; set; }
        public String Currency { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentId", PaymentId)                
                .Append("ip", Ip)
                .AppendPrice("paidPrice", PaidPrice)
                .Append("currency", Currency)
                .GetRequestString();
        }
    }
}
