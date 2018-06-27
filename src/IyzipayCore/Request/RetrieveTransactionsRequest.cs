using System;

namespace IyzipayCore.Request
{
    public class RetrieveTransactionsRequest: BaseRequest
    {
        public String Date { get; set; }

        public override String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPkiRequestString())
                .Append("date", Date)
                .GetRequestString();
        }
    }
}
