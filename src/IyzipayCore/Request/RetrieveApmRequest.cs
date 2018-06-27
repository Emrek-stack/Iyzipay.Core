using System;

namespace IyzipayCore.Request
{
   public class RetrieveApmRequest : BaseRequest
    {
        public String PaymentId { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentId", PaymentId)           
                .GetRequestString();
        }
    }
}
