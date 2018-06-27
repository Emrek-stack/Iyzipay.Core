using System;

namespace IyzipayCore.Request
{
    public class CreateCrossBookingRequest : BaseRequest
    {
        public String SubMerchantKey { get; set; }
        public String Price { get; set; }
        public String Reason { get; set; }
        public String Currency { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("subMerchantKey", SubMerchantKey)
                .AppendPrice("price", Price)
                .Append("reason", Reason)
                .Append("currency", Currency)
                .GetRequestString();
        }
    }
}
