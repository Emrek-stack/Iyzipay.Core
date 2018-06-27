using System;

namespace IyzipayCore
{
    public class BaseRequest : IRequestStringConvertible
    {
        public String Locale { get; set; }
        public String ConversationId { get; set; }

        public virtual String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("locale", Locale)
                .Append("conversationId", ConversationId)
                .GetRequestString();
        }
    }
}
