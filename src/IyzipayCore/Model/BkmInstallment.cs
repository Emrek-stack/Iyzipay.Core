using System;
using System.Collections.Generic;

namespace IyzipayCore.Model
{
    public class BkmInstallment : IRequestStringConvertible
    {
        public long? BankId { get; set; }
        public List<BkmInstallmentPrice> InstallmentPrices { get; set; }

        public String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("bankId", BankId)
                .AppendList("installmentPrices", InstallmentPrices)
                .GetRequestString();
        }
    }
}
