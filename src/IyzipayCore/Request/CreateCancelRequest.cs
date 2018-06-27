using System;

namespace IyzipayCore.Request
{
    public class CreateCancelRequest : BaseRequest
    {
        public String PaymentId { get; set; }
        public String Ip { get; set; }
        public String Reason { get; set; }
        public String Description { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentId", PaymentId)
                .Append("ip", Ip)
                .Append("reason", Reason)
                .Append("description", Description)
                .GetRequestString();
        }
    }
}
