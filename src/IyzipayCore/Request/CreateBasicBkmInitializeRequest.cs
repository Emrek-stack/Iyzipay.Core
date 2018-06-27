using System;
using System.Collections.Generic;
using IyzipayCore.Model;

namespace IyzipayCore.Request
{
    public class CreateBasicBkmInitializeRequest : BaseRequest
    {
        public String ConnectorName { get; set; }
        public String Price { get; set; }
        public String CallbackUrl { get; set; }
        public String BuyerEmail { get; set; }
        public String BuyerId { get; set; }
        public String BuyerIp { get; set; }
        public String PosOrderId { get; set; }
        public List<BkmInstallment> InstallmentDetails { get; set; }
        
        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("connectorName", ConnectorName)
                .AppendPrice("price", Price)
                .Append("callbackUrl", CallbackUrl)
                .Append("buyerEmail", BuyerEmail)
                .Append("buyerId", BuyerId)
                .Append("buyerIp", BuyerIp)
                .Append("posOrderId", PosOrderId)
                .AppendList("installmentDetails", InstallmentDetails)
                .GetRequestString();
        }
    }
}
