using System.Text.Json.Serialization;

namespace rolePlayingGame.Models
{


    [JsonConverter((typeof(JsonStringEnumConverter)))]
    public enum RpgClass
    {
        Ranger, 
        Assassin
    }
}