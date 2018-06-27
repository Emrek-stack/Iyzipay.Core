using System;

namespace IyzipayCore.Request
{
    public class RetrieveBinNumberRequest : BaseRequest
    {
        public String BinNumber { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("binNumber", BinNumber)
                .GetRequestString();
        }
    }
}
