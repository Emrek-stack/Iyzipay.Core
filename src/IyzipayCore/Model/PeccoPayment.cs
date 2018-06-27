using System;
using IyzipayCore.Request;

namespace IyzipayCore.Model
{
    public class PeccoPayment : PaymentResource
    {
        public String Token { get; set; }

        public static PeccoPayment Create(CreatePeccoPaymentRequest request, Options options)
        {
            return RestHttpClient.Create().Post<PeccoPayment>(options.BaseUrl + "/payment/pecco/auth", GetHttpHeaders(request, options), request);
        }
    }
}
