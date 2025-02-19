using System.Reflection;
using System.Text.Json.Serialization;

namespace BlazorServerSyncfusion.Models
{
    public class FakeUser
    {
        [JsonPropertyName("id")] public int? Id { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("username")] public string Username { get; set; }
        [JsonPropertyName("email")] public string Email { get; set; }
        [JsonPropertyName("phone")] public string Phone { get; set; }
    }

    public static class MyModelHelper
    {
        public static string GetJsonPropertyName<T>(string propertyName)
        {
            var prop = typeof(T).GetProperty(propertyName);
            var attr = prop.GetCustomAttribute<JsonPropertyNameAttribute>();
            return attr?.Name ?? propertyName;
        }
    }
}
