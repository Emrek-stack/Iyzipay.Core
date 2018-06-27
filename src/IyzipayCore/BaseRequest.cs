using System;

namespace IyzipayCore
{
    public class BaseRequest : IRequestStringConvertible
    {
        public string Locale { get; set; }
        public string ConversationId { get; set; }

        public virtual String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("locale", Locale)
                .Append("conversationId", ConversationId)
                .GetRequestString();
        }
    }
}
