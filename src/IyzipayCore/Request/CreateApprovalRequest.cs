using System;

namespace IyzipayCore.Request
{
    public class CreateApprovalRequest : BaseRequest
    {
        public String PaymentTransactionId { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("paymentTransactionId", PaymentTransactionId)
                .GetRequestString();
        }
    }
}
