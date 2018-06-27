using System;
using Newtonsoft.Json;

namespace IyzipayCore.Model
{
    public class InstallmentPrice
    {
        [JsonProperty(PropertyName = "InstallmentPrice")]
        public String Price { get; set; }
        public String TotalPrice { get; set; }
        public int? InstallmentNumber { get; set; }
    }
}
