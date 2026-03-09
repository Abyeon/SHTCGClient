# SHTCGClient
An API wrapper for the (currently beta) Something Happened Trading Card Game.

Check out the [Docs](/SHTCGClient/Docs/index.md)!

## Usage

### Logging in
```csharp
// Not required: create a new ThrottledProcessor with a given delay.
// This is used to avoid spamming the api, so no need to Task.Delay() between api requests.
// Processor will be disposed by the ClientService, so do not dispose it yourself.
var processor = new ThrottledProcessor(TimeSpan.FromMilliseconds(200));

// Instantiate your client. If you do not provide a processor it will default to one with 200ms.
// ClientService is an AsyncDisposable, so we want to use "await using" here.
await using var client = new ClientService(processor);

// Log in! The username and password fields are filled in here,
// but you should save them in an environment variable or something else!
bool loggedIn = await client.Login("your-username", "your-password");
if (!loggedIn) return;

Task.Delay(-1);
```

### Rolling
```csharp
// Check if we can roll
var rollInfo = await client.Status();
if (rollInfo == null)
{
    Console.WriteLine("Get status failed!");
    return;
}

if (rollInfo.RollsAvailable > 0)
{
    // Send a roll request, which returns an object with our new card, rarity, and new roll info!
    var roll = await client.Roll();
    if (roll != null)
    {
        Console.WriteLine($"You rolled a {roll.Card.Name}!\nValue: ${roll.Card.EstimatedValue:F}")
    }
}
```
