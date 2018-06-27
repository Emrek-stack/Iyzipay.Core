using System;
using IyzipayCore.Request;

namespace IyzipayCore.Model
{
    public class PeccoInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String RedirectUrl { get; set; }
        public String Token { get; set; }
        public long? TokenExpireTime { get; set; }

        public static PeccoInitialize Create(CreatePeccoInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PeccoInitialize>(options.BaseUrl + "/payment/pecco/initialize", GetHttpHeaders(request, options), request);
        }
    }
}
