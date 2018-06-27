using System;
using Newtonsoft.Json;

namespace IyzipayCore.Model
{
    public class Address : IRequestStringConvertible
    {
        [JsonProperty(PropertyName = "Address")]
        public String Description { get; set; }
        public String ZipCode { get; set; }
        public String ContactName { get; set; }
        public String City { get; set; }
        public String Country { get; set; }

        public String ToPkiRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("address", Description)
                .Append("zipCode", ZipCode)
                .Append("contactName", ContactName)
                .Append("city", City)
                .Append("country", Country)
                .GetRequestString();
        }
    }
}
