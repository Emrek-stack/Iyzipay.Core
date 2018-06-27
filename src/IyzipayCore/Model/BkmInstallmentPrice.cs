using System;

namespace IyzipayCore.Model
{
  public  class BkmInstallmentPrice : IRequestStringConvertible
    {
        public int? InstallmentNumber { get; set; }
        public String TotalPrice { get; set; }

        public String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("installmentNumber", InstallmentNumber)
                .AppendPrice("totalPrice", TotalPrice)
                .GetRequestString();
        }
    }
}
