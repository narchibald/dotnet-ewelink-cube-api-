using Newtonsoft.Json;

namespace EWeLink.Cube.Api.Models.Capabilities;

public class ThermostatModeDetectCapability
{
    [JsonProperty("humidity")]
    public HumidityMode? Humidity { get; set; }
    
    [JsonProperty("temperature")]
    public TemperatureMode? Temperature { get; set; }

    public class HumidityMode
    {
        [JsonProperty("Mode")]
        public HumidityModeState Mode { get; set; }
    }
    public class TemperatureMode
    {
        [JsonProperty("Mode")]
        public TemperatureModeState Mode { get; set; }
    }
    
}