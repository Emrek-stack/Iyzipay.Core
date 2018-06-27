using System;

namespace IyzipayCore.Request
{
    public class RetrieveSubMerchantRequest : BaseRequest
    {
        public String SubMerchantExternalId { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("subMerchantExternalId", SubMerchantExternalId)
                .GetRequestString();
        }
    }
}
