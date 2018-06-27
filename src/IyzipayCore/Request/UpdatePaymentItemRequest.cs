using System;

namespace IyzipayCore.Request
{
    public class UpdatePaymentItemRequest : BaseRequest
    {
        public String SubMerchantKey { get; set; }
        public String PaymentTransactionId { get; set; }
        public String SubMerchantPrice { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("subMerchantKey", SubMerchantKey)
                .Append("paymentTransactionId", PaymentTransactionId)
                .Append("subMerchantPrice", SubMerchantPrice)
                .GetRequestString();
        }
    }
}
