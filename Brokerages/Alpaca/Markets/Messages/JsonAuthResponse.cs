/*
 * The official C# API client for alpaca brokerage
 * Sourced from: https://github.com/alpacahq/alpaca-trade-api-csharp/commit/161b114b4b40d852a14a903bd6e69d26fe637922
*/

using System;
using Newtonsoft.Json;

namespace QuantConnect.Brokerages.Alpaca.Markets
{
    internal sealed class JsonAuthResponse
    {
        [JsonProperty(PropertyName = "action", Required = Required.Always)]
        public String Action { get; set; }

        [JsonProperty(PropertyName = "status", Required = Required.Always)]
        public AuthStatus Status { get; set; }
    }
}