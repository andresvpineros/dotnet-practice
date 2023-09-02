namespace dotnet_practice.Models;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RoleClass
{
    Client = 0,
    Support = 1,
    Administrator = 2
}
