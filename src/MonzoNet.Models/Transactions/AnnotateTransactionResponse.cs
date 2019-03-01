using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MonzoNet.Models.Transactions
{
    public class AnnotateTransactionResponse
    {
        [JsonProperty(PropertyName = "transaction")]
        public Transaction Transaction { get; set; }
    }
}
