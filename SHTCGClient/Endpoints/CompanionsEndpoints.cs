using SHTCGClient.Models.Companions;

namespace SHTCGClient.Endpoints;

/// <summary>
/// Class for interacting with the companions endpoint
/// </summary>
public class CompanionsEndpoints (ClientService client)
{
    /// <summary>
    /// Get the user's owned companions
    /// </summary>
    /// <returns>Array of companions</returns>
    public async Task<Companion[]?> GetCompanions() => await client.Request<Companion[]>(HttpMethod.Get, "companions");
    
    /// <summary>
    /// Get the user's currently active companion
    /// </summary>
    /// <returns>The active companion</returns>
    public async Task<Companion?> GetActiveCompanion() => await client.Request<Companion>(HttpMethod.Get, "companions/active");
    
    /// <summary>
    /// Unequip the currently active companion
    /// </summary>
    /// <returns>Success</returns>
    public async Task<bool> UnequipCompanion() => await client.Request(HttpMethod.Post, "companions/unequip");
    
    /// <summary>
    /// Equip a companion by ID
    /// </summary>
    /// <param name="id">The ID of the companion to equip</param>
    /// <returns>The equipped companion</returns>
    public async Task<Companion?> EquipCompanion(int id) => await client.Request<Companion>(HttpMethod.Post, $"companions/{id}/equip");
}