using System.Text.Json;
using System.Text.Json.Serialization;

namespace SHTCGClient.Models;

public class PaginatedItem<T>
{
    [JsonPropertyName("total")]
    public int Total { get; init; }
    
    [JsonPropertyName("page")]
    public int Page { get; init; }
    
    [JsonPropertyName("page_size")]
    public int PageSize { get; init; }
    
    [JsonPropertyName("total_pages")]
    public int TotalPages { get; init; }
    
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? ExtensionData { get; init; }
    
    [JsonIgnore]
    public T[] Data 
    {
        get 
        {
            if (ExtensionData == null || ExtensionData.Count == 0) return [];
            var dataElement = ExtensionData.Values.FirstOrDefault(e => e.ValueKind == JsonValueKind.Array);
            
            if (dataElement.ValueKind != JsonValueKind.Undefined)
            {
                return dataElement.Deserialize<T[]>() ?? [];
            }

            return [];
        }
    }
}