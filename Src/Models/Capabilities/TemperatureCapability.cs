using EWeLink.Cube.Api.Models.Converters;
using EWeLink.Cube.Api.Models.States;
using Newtonsoft.Json;

namespace EWeLink.Cube.Api.Models.Capabilities;

public class TemperatureCapability
{
    [JsonProperty("temperature")]
    [JsonConverter(typeof(IntToDecimalConverter))]
    public decimal Value { get; set; }
}
