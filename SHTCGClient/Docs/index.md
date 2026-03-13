#### [SHTCGClient](index.md 'index')

## SHTCGClient Assembly
### Namespaces

<a name='SHTCGClient'></a>

## SHTCGClient Namespace
- **[ClientService](SHTCGClient.ClientService.md 'SHTCGClient\.ClientService')** `Class` The main service for interacting with the Something Happened TCG API\.
  - **[ClientService\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.ClientService() 'SHTCGClient\.ClientService\.ClientService\(\)')** `Constructor`
  - **[ClientService\(ThrottledProcessor\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.ClientService(SHTCGClient.ThrottledProcessor) 'SHTCGClient\.ClientService\.ClientService\(SHTCGClient\.ThrottledProcessor\)')** `Constructor`
  - **[Client](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Client 'SHTCGClient\.ClientService\.Client')** `Field`
  - **[CookieContainer](SHTCGClient.ClientService.md#SHTCGClient.ClientService.CookieContainer 'SHTCGClient\.ClientService\.CookieContainer')** `Field`
  - **[Handler](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Handler 'SHTCGClient\.ClientService\.Handler')** `Field`
  - **[LoggedIn](SHTCGClient.ClientService.md#SHTCGClient.ClientService.LoggedIn 'SHTCGClient\.ClientService\.LoggedIn')** `Field` If the client is logged in or not
  - **[Processor](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Processor 'SHTCGClient\.ClientService\.Processor')** `Field`
  - **[AddDeckCard\(int, int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.AddDeckCard(int,int) 'SHTCGClient\.ClientService\.AddDeckCard\(int, int\)')** `Method` Add a card to a deck
  - **[DeleteDeckCard\(int, int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.DeleteDeckCard(int,int) 'SHTCGClient\.ClientService\.DeleteDeckCard\(int, int\)')** `Method` Delete a card in a deck
  - **[DisposeAsync\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.DisposeAsync() 'SHTCGClient\.ClientService\.DisposeAsync\(\)')** `Method` Async disposal\. Put the ClientService in an "await using" block for this to automatically clean up\.
  - **[EquipCompanion\(int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.EquipCompanion(int) 'SHTCGClient\.ClientService\.EquipCompanion\(int\)')** `Method` Equip a companion by ID
  - **[GetActiveCompanion\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetActiveCompanion() 'SHTCGClient\.ClientService\.GetActiveCompanion\(\)')** `Method` Get the user's currently active companion
  - **[GetCandles\(int, int, int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetCandles(int,int,int) 'SHTCGClient\.ClientService\.GetCandles\(int, int, int\)')** `Method` Get the candle graph for an exchange
  - **[GetCards\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetCards() 'SHTCGClient\.ClientService\.GetCards\(\)')** `Method` Get the User's owned cards\. \(This automatically de\-paginates the request and gets all cards\.\)
  - **[GetCompanions\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetCompanions() 'SHTCGClient\.ClientService\.GetCompanions\(\)')** `Method` Get the user's owned companions
  - **[GetCurrentSeason\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetCurrentSeason() 'SHTCGClient\.ClientService\.GetCurrentSeason\(\)')** `Method` Get the currently active season
  - **[GetDeckCards\(int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetDeckCards(int) 'SHTCGClient\.ClientService\.GetDeckCards\(int\)')** `Method` Get the cards for a deck by id
  - **[GetDecks\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetDecks() 'SHTCGClient\.ClientService\.GetDecks\(\)')** `Method` Get the user's decks
  - **[GetExchanges\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetExchanges() 'SHTCGClient\.ClientService\.GetExchanges\(\)')** `Method` Get the currently running exchanges
  - **[GetFeatures\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetFeatures() 'SHTCGClient\.ClientService\.GetFeatures\(\)')** `Method` Get the current features available for voting\. Check if the user is able to vote with [GetVoteStatus\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetVoteStatus() 'SHTCGClient\.ClientService\.GetVoteStatus\(\)') before attempting to vote\.
  - **[GetFriends\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetFriends() 'SHTCGClient\.ClientService\.GetFriends\(\)')** `Method` Get your friends
  - **[GetLeaderboard\(string, int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetLeaderboard(string,int) 'SHTCGClient\.ClientService\.GetLeaderboard\(string, int\)')** `Method` Fetch the leaderboard
  - **[GetLeaderboardDeckCards\(int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetLeaderboardDeckCards(int) 'SHTCGClient\.ClientService\.GetLeaderboardDeckCards\(int\)')** `Method` Get the cards for a deck on the season leaderboard\.
  - **[GetPositions\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetPositions() 'SHTCGClient\.ClientService\.GetPositions\(\)')** `Method` Get the user's positions in the exchanges
  - **[GetSeason\(int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetSeason(int) 'SHTCGClient\.ClientService\.GetSeason\(int\)')** `Method` Get season by id
  - **[GetSeasonLeaderboard\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetSeasonLeaderboard() 'SHTCGClient\.ClientService\.GetSeasonLeaderboard\(\)')** `Method` Get the deck leaderboard for the current season
  - **[GetUserByName\(string\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetUserByName(string) 'SHTCGClient\.ClientService\.GetUserByName\(string\)')** `Method` Search for a user by name
  - **[GetVendors\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetVendors() 'SHTCGClient\.ClientService\.GetVendors\(\)')** `Method` Get the current vendors
  - **[GetVoteStatus\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.GetVoteStatus() 'SHTCGClient\.ClientService\.GetVoteStatus\(\)')** `Method` Gets the users voting eligibility and the next time they may vote\.
  - **[Login\(Credentials\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Login(SHTCGClient.Credentials) 'SHTCGClient\.ClientService\.Login\(SHTCGClient\.Credentials\)')** `Method` Log in to the game
  - **[Login\(string, string\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Login(string,string) 'SHTCGClient\.ClientService\.Login\(string, string\)')** `Method` Log in to the game
  - **[Request\(HttpMethod, string\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string) 'SHTCGClient\.ClientService\.Request\(System\.Net\.Http\.HttpMethod, string\)')** `Method` A helper method for sending a request to the API
  - **[Request\(HttpMethod, string, object\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request(System.Net.Http.HttpMethod,string,object) 'SHTCGClient\.ClientService\.Request\(System\.Net\.Http\.HttpMethod, string, object\)')** `Method` A helper method for sending a request to the API
  - **[Request&lt;T&gt;\(HttpMethod, string\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string) 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string\)')** `Method` A helper method for sending a request to the API
  - **[Request&lt;T&gt;\(HttpMethod, string, object\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Request_T_(System.Net.Http.HttpMethod,string,object) 'SHTCGClient\.ClientService\.Request\<T\>\(System\.Net\.Http\.HttpMethod, string, object\)')** `Method` A helper method for sending a request to the API
  - **[Roll\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Roll() 'SHTCGClient\.ClientService\.Roll\(\)')** `Method` Roll for a card
  - **[RollHistory\(int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.RollHistory(int) 'SHTCGClient\.ClientService\.RollHistory\(int\)')** `Method` Get the last x rolls
  - **[SellCard\(int, int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.SellCard(int,int) 'SHTCGClient\.ClientService\.SellCard\(int, int\)')** `Method` Sell a card
  - **[SellCards\(int\[\], int\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.SellCards(int[],int) 'SHTCGClient\.ClientService\.SellCards\(int\[\], int\)')** `Method` Sell cards
  - **[Status\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.Status() 'SHTCGClient\.ClientService\.Status\(\)')** `Method` Get the current roll status
  - **[UnequipCompanion\(\)](SHTCGClient.ClientService.md#SHTCGClient.ClientService.UnequipCompanion() 'SHTCGClient\.ClientService\.UnequipCompanion\(\)')** `Method` Unequip the currently active companion
- **[ThrottledProcessor](SHTCGClient.ThrottledProcessor.md 'SHTCGClient\.ThrottledProcessor')** `Class` Throttled task processor utilizing threading\.channels\.
  - **[ThrottledProcessor\(TimeSpan\)](SHTCGClient.ThrottledProcessor.md#SHTCGClient.ThrottledProcessor.ThrottledProcessor(System.TimeSpan) 'SHTCGClient\.ThrottledProcessor\.ThrottledProcessor\(System\.TimeSpan\)')** `Constructor`
  - **[Dispose\(\)](SHTCGClient.ThrottledProcessor.md#SHTCGClient.ThrottledProcessor.Dispose() 'SHTCGClient\.ThrottledProcessor\.Dispose\(\)')** `Method`
  - **[EnqueueAsync\(Func&lt;CancellationToken,Task&gt;\)](SHTCGClient.ThrottledProcessor.md#SHTCGClient.ThrottledProcessor.EnqueueAsync(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\>\)')** `Method` Enqueue a job
  - **[EnqueueAsync&lt;T&gt;\(Func&lt;CancellationToken,Task&lt;T&gt;&gt;\)](SHTCGClient.ThrottledProcessor.md#SHTCGClient.ThrottledProcessor.EnqueueAsync_T_(System.Func_System.Threading.CancellationToken,System.Threading.Tasks.Task_T__) 'SHTCGClient\.ThrottledProcessor\.EnqueueAsync\<T\>\(System\.Func\<System\.Threading\.CancellationToken,System\.Threading\.Tasks\.Task\<T\>\>\)')** `Method` Enqueue a job with a return type\.
- **[Credentials](SHTCGClient.Credentials.md 'SHTCGClient\.Credentials')** `Struct` An object for storing user login credentials\.
  - **[Password](SHTCGClient.Credentials.md#SHTCGClient.Credentials.Password 'SHTCGClient\.Credentials\.Password')** `Property` Your password
  - **[Username](SHTCGClient.Credentials.md#SHTCGClient.Credentials.Username 'SHTCGClient\.Credentials\.Username')** `Property` Your username

<a name='SHTCGClient.Models'></a>

## SHTCGClient\.Models Namespace
- **[PaginatedItem&lt;T&gt;](SHTCGClient.Models.PaginatedItem_T_.md 'SHTCGClient\.Models\.PaginatedItem\<T\>')** `Class` Generic object representing a paginated response
  - **[Data](SHTCGClient.Models.PaginatedItem_T_.md#SHTCGClient.Models.PaginatedItem_T_.Data 'SHTCGClient\.Models\.PaginatedItem\<T\>\.Data')** `Property`
  - **[ExtensionData](SHTCGClient.Models.PaginatedItem_T_.md#SHTCGClient.Models.PaginatedItem_T_.ExtensionData 'SHTCGClient\.Models\.PaginatedItem\<T\>\.ExtensionData')** `Property`
  - **[Page](SHTCGClient.Models.PaginatedItem_T_.md#SHTCGClient.Models.PaginatedItem_T_.Page 'SHTCGClient\.Models\.PaginatedItem\<T\>\.Page')** `Property`
  - **[PageSize](SHTCGClient.Models.PaginatedItem_T_.md#SHTCGClient.Models.PaginatedItem_T_.PageSize 'SHTCGClient\.Models\.PaginatedItem\<T\>\.PageSize')** `Property`
  - **[Total](SHTCGClient.Models.PaginatedItem_T_.md#SHTCGClient.Models.PaginatedItem_T_.Total 'SHTCGClient\.Models\.PaginatedItem\<T\>\.Total')** `Property`
  - **[TotalPages](SHTCGClient.Models.PaginatedItem_T_.md#SHTCGClient.Models.PaginatedItem_T_.TotalPages 'SHTCGClient\.Models\.PaginatedItem\<T\>\.TotalPages')** `Property`

<a name='SHTCGClient.Models.Cards'></a>

## SHTCGClient\.Models\.Cards Namespace
- **[Card](SHTCGClient.Models.Cards.Card.md 'SHTCGClient\.Models\.Cards\.Card')** `Class` A Trading Card
  - **[BaseCardId](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.BaseCardId 'SHTCGClient\.Models\.Cards\.Card\.BaseCardId')** `Property`
  - **[CardSetId](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.CardSetId 'SHTCGClient\.Models\.Cards\.Card\.CardSetId')** `Property`
  - **[CollectionId](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.CollectionId 'SHTCGClient\.Models\.Cards\.Card\.CollectionId')** `Property`
  - **[CreatedAt](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.CreatedAt 'SHTCGClient\.Models\.Cards\.Card\.CreatedAt')** `Property`
  - **[Description](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Description 'SHTCGClient\.Models\.Cards\.Card\.Description')** `Property`
  - **[DropChance](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.DropChance 'SHTCGClient\.Models\.Cards\.Card\.DropChance')** `Property`
  - **[EstimatedValue](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.EstimatedValue 'SHTCGClient\.Models\.Cards\.Card\.EstimatedValue')** `Property`
  - **[ExtensionData](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.ExtensionData 'SHTCGClient\.Models\.Cards\.Card\.ExtensionData')** `Property`
  - **[Foil](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Foil 'SHTCGClient\.Models\.Cards\.Card\.Foil')** `Property`
  - **[Grade](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Grade 'SHTCGClient\.Models\.Cards\.Card\.Grade')** `Property`
  - **[Id](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Id 'SHTCGClient\.Models\.Cards\.Card\.Id')** `Property`
  - **[ImageUrl](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.ImageUrl 'SHTCGClient\.Models\.Cards\.Card\.ImageUrl')** `Property`
  - **[IsLocked](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.IsLocked 'SHTCGClient\.Models\.Cards\.Card\.IsLocked')** `Property`
  - **[IsRequestUser](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.IsRequestUser 'SHTCGClient\.Models\.Cards\.Card\.IsRequestUser')** `Property`
  - **[Name](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Name 'SHTCGClient\.Models\.Cards\.Card\.Name')** `Property`
  - **[Owner](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Owner 'SHTCGClient\.Models\.Cards\.Card\.Owner')** `Property`
  - **[Rarity](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Rarity 'SHTCGClient\.Models\.Cards\.Card\.Rarity')** `Property`
  - **[ReleaseDate](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.ReleaseDate 'SHTCGClient\.Models\.Cards\.Card\.ReleaseDate')** `Property`
  - **[Stack](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Stack 'SHTCGClient\.Models\.Cards\.Card\.Stack')** `Property`
  - **[Trim](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Trim 'SHTCGClient\.Models\.Cards\.Card\.Trim')** `Property`
  - **[UpdatedAt](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.UpdatedAt 'SHTCGClient\.Models\.Cards\.Card\.UpdatedAt')** `Property`
  - **[Equals\(object\)](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Equals(object) 'SHTCGClient\.Models\.Cards\.Card\.Equals\(object\)')** `Method`
  - **[Equals\(Card\)](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Equals(SHTCGClient.Models.Cards.Card) 'SHTCGClient\.Models\.Cards\.Card\.Equals\(SHTCGClient\.Models\.Cards\.Card\)')** `Method`
  - **[GetHashCode\(\)](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.GetHashCode() 'SHTCGClient\.Models\.Cards\.Card\.GetHashCode\(\)')** `Method`
  - **[OnDeserialized\(\)](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.OnDeserialized() 'SHTCGClient\.Models\.Cards\.Card\.OnDeserialized\(\)')** `Method`
  - **[Sell\(ClientService\)](SHTCGClient.Models.Cards.Card.md#SHTCGClient.Models.Cards.Card.Sell(SHTCGClient.ClientService) 'SHTCGClient\.Models\.Cards\.Card\.Sell\(SHTCGClient\.ClientService\)')** `Method` Sell this card
- **[CardRollResponse](SHTCGClient.Models.Cards.CardRollResponse.md 'SHTCGClient\.Models\.Cards\.CardRollResponse')** `Class` Information about the card you rolled, it's rarity, and new roll info
  - **[Card](SHTCGClient.Models.Cards.CardRollResponse.md#SHTCGClient.Models.Cards.CardRollResponse.Card 'SHTCGClient\.Models\.Cards\.CardRollResponse\.Card')** `Property`
  - **[Rarity](SHTCGClient.Models.Cards.CardRollResponse.md#SHTCGClient.Models.Cards.CardRollResponse.Rarity 'SHTCGClient\.Models\.Cards\.CardRollResponse\.Rarity')** `Property`
  - **[RollInfo](SHTCGClient.Models.Cards.CardRollResponse.md#SHTCGClient.Models.Cards.CardRollResponse.RollInfo 'SHTCGClient\.Models\.Cards\.CardRollResponse\.RollInfo')** `Property`
- **[RollInfo](SHTCGClient.Models.Cards.RollInfo.md 'SHTCGClient\.Models\.Cards\.RollInfo')** `Class` Status information for user's accumulated rolls, max rolls, etc\.
  - **[HoursUntilNextRoll](SHTCGClient.Models.Cards.RollInfo.md#SHTCGClient.Models.Cards.RollInfo.HoursUntilNextRoll 'SHTCGClient\.Models\.Cards\.RollInfo\.HoursUntilNextRoll')** `Property`
  - **[MaxRolls](SHTCGClient.Models.Cards.RollInfo.md#SHTCGClient.Models.Cards.RollInfo.MaxRolls 'SHTCGClient\.Models\.Cards\.RollInfo\.MaxRolls')** `Property`
  - **[RollRefillCost](SHTCGClient.Models.Cards.RollInfo.md#SHTCGClient.Models.Cards.RollInfo.RollRefillCost 'SHTCGClient\.Models\.Cards\.RollInfo\.RollRefillCost')** `Property`
  - **[RollsAccumulated](SHTCGClient.Models.Cards.RollInfo.md#SHTCGClient.Models.Cards.RollInfo.RollsAccumulated 'SHTCGClient\.Models\.Cards\.RollInfo\.RollsAccumulated')** `Property`
  - **[RollsAvailable](SHTCGClient.Models.Cards.RollInfo.md#SHTCGClient.Models.Cards.RollInfo.RollsAvailable 'SHTCGClient\.Models\.Cards\.RollInfo\.RollsAvailable')** `Property`
  - **[SeasonCardPackImageUrl](SHTCGClient.Models.Cards.RollInfo.md#SHTCGClient.Models.Cards.RollInfo.SeasonCardPackImageUrl 'SHTCGClient\.Models\.Cards\.RollInfo\.SeasonCardPackImageUrl')** `Property`

<a name='SHTCGClient.Models.Companions'></a>

## SHTCGClient\.Models\.Companions Namespace
- **[Companion](SHTCGClient.Models.Companions.Companion.md 'SHTCGClient\.Models\.Companions\.Companion')** `Class` A pet that will provide bonuses and detriments to a user's rolls\.
  - **[CreatedAt](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.CreatedAt 'SHTCGClient\.Models\.Companions\.Companion\.CreatedAt')** `Property`
  - **[Id](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.Id 'SHTCGClient\.Models\.Companions\.Companion\.Id')** `Property`
  - **[LuckModifier](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.LuckModifier 'SHTCGClient\.Models\.Companions\.Companion\.LuckModifier')** `Property`
  - **[MaxRollsModifier](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.MaxRollsModifier 'SHTCGClient\.Models\.Companions\.Companion\.MaxRollsModifier')** `Property`
  - **[Name](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.Name 'SHTCGClient\.Models\.Companions\.Companion\.Name')** `Property`
  - **[RollRefreshModifier](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.RollRefreshModifier 'SHTCGClient\.Models\.Companions\.Companion\.RollRefreshModifier')** `Property`
  - **[SpriteSheet](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.SpriteSheet 'SHTCGClient\.Models\.Companions\.Companion\.SpriteSheet')** `Property`
  - **[Title](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.Title 'SHTCGClient\.Models\.Companions\.Companion\.Title')** `Property`
  - **[UpdatedAt](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.UpdatedAt 'SHTCGClient\.Models\.Companions\.Companion\.UpdatedAt')** `Property`
  - **[Equals\(object\)](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.Equals(object) 'SHTCGClient\.Models\.Companions\.Companion\.Equals\(object\)')** `Method`
  - **[Equals\(Companion\)](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.Equals(SHTCGClient.Models.Companions.Companion) 'SHTCGClient\.Models\.Companions\.Companion\.Equals\(SHTCGClient\.Models\.Companions\.Companion\)')** `Method`
  - **[Equip\(ClientService\)](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.Equip(SHTCGClient.ClientService) 'SHTCGClient\.Models\.Companions\.Companion\.Equip\(SHTCGClient\.ClientService\)')** `Method` Equips this companion
  - **[GetHashCode\(\)](SHTCGClient.Models.Companions.Companion.md#SHTCGClient.Models.Companions.Companion.GetHashCode() 'SHTCGClient\.Models\.Companions\.Companion\.GetHashCode\(\)')** `Method`
- **[SpriteSheet](SHTCGClient.Models.Companions.SpriteSheet.md 'SHTCGClient\.Models\.Companions\.SpriteSheet')** `Class`
  - **[Angry1](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Angry1 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Angry1')** `Property`
  - **[Angry2](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Angry2 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Angry2')** `Property`
  - **[Happy1](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Happy1 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Happy1')** `Property`
  - **[Happy2](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Happy2 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Happy2')** `Property`
  - **[Love1](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Love1 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Love1')** `Property`
  - **[Love2](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Love2 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Love2')** `Property`
  - **[Neutral1](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Neutral1 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Neutral1')** `Property`
  - **[Neutral2](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Neutral2 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Neutral2')** `Property`
  - **[Sad1](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Sad1 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Sad1')** `Property`
  - **[Sad2](SHTCGClient.Models.Companions.SpriteSheet.md#SHTCGClient.Models.Companions.SpriteSheet.Sad2 'SHTCGClient\.Models\.Companions\.SpriteSheet\.Sad2')** `Property`

<a name='SHTCGClient.Models.Exchange'></a>

## SHTCGClient\.Models\.Exchange Namespace
- **[Candle](SHTCGClient.Models.Exchange.Candle.md 'SHTCGClient\.Models\.Exchange\.Candle')** `Class`
  - **[Close](SHTCGClient.Models.Exchange.Candle.md#SHTCGClient.Models.Exchange.Candle.Close 'SHTCGClient\.Models\.Exchange\.Candle\.Close')** `Property`
  - **[High](SHTCGClient.Models.Exchange.Candle.md#SHTCGClient.Models.Exchange.Candle.High 'SHTCGClient\.Models\.Exchange\.Candle\.High')** `Property`
  - **[Low](SHTCGClient.Models.Exchange.Candle.md#SHTCGClient.Models.Exchange.Candle.Low 'SHTCGClient\.Models\.Exchange\.Candle\.Low')** `Property`
  - **[Open](SHTCGClient.Models.Exchange.Candle.md#SHTCGClient.Models.Exchange.Candle.Open 'SHTCGClient\.Models\.Exchange\.Candle\.Open')** `Property`
  - **[Timestamp](SHTCGClient.Models.Exchange.Candle.md#SHTCGClient.Models.Exchange.Candle.Timestamp 'SHTCGClient\.Models\.Exchange\.Candle\.Timestamp')** `Property`
  - **[Volume](SHTCGClient.Models.Exchange.Candle.md#SHTCGClient.Models.Exchange.Candle.Volume 'SHTCGClient\.Models\.Exchange\.Candle\.Volume')** `Property`
- **[Exchange](SHTCGClient.Models.Exchange.Exchange.md 'SHTCGClient\.Models\.Exchange\.Exchange')** `Class` Stock information
  - **[CreatedAt](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.CreatedAt 'SHTCGClient\.Models\.Exchange\.Exchange\.CreatedAt')** `Property`
  - **[Description](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.Description 'SHTCGClient\.Models\.Exchange\.Exchange\.Description')** `Property`
  - **[High24Hours](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.High24Hours 'SHTCGClient\.Models\.Exchange\.Exchange\.High24Hours')** `Property`
  - **[Id](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.Id 'SHTCGClient\.Models\.Exchange\.Exchange\.Id')** `Property`
  - **[IsActive](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.IsActive 'SHTCGClient\.Models\.Exchange\.Exchange\.IsActive')** `Property`
  - **[LatestPrice](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.LatestPrice 'SHTCGClient\.Models\.Exchange\.Exchange\.LatestPrice')** `Property`
  - **[Low24Hours](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.Low24Hours 'SHTCGClient\.Models\.Exchange\.Exchange\.Low24Hours')** `Property`
  - **[Name](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.Name 'SHTCGClient\.Models\.Exchange\.Exchange\.Name')** `Property`
  - **[Symbol](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.Symbol 'SHTCGClient\.Models\.Exchange\.Exchange\.Symbol')** `Property`
  - **[Volume24Hours](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.Volume24Hours 'SHTCGClient\.Models\.Exchange\.Exchange\.Volume24Hours')** `Property`
  - **[GetCandles\(ClientService, int, int\)](SHTCGClient.Models.Exchange.Exchange.md#SHTCGClient.Models.Exchange.Exchange.GetCandles(SHTCGClient.ClientService,int,int) 'SHTCGClient\.Models\.Exchange\.Exchange\.GetCandles\(SHTCGClient\.ClientService, int, int\)')** `Method` Get the candle graph for this exchange
- **[Position](SHTCGClient.Models.Exchange.Position.md 'SHTCGClient\.Models\.Exchange\.Position')** `Class` The user's currently purchases positions in a stock\.
  - **[AvgCost](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.AvgCost 'SHTCGClient\.Models\.Exchange\.Position\.AvgCost')** `Property`
  - **[CostBasis](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.CostBasis 'SHTCGClient\.Models\.Exchange\.Position\.CostBasis')** `Property`
  - **[MarketId](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.MarketId 'SHTCGClient\.Models\.Exchange\.Position\.MarketId')** `Property`
  - **[MarketPrice](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.MarketPrice 'SHTCGClient\.Models\.Exchange\.Position\.MarketPrice')** `Property`
  - **[MarketValue](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.MarketValue 'SHTCGClient\.Models\.Exchange\.Position\.MarketValue')** `Property`
  - **[Quantity](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.Quantity 'SHTCGClient\.Models\.Exchange\.Position\.Quantity')** `Property`
  - **[Symbol](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.Symbol 'SHTCGClient\.Models\.Exchange\.Position\.Symbol')** `Property`
  - **[UnrealizedPnl](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.UnrealizedPnl 'SHTCGClient\.Models\.Exchange\.Position\.UnrealizedPnl')** `Property`
  - **[UnrealizedPnlPercentage](SHTCGClient.Models.Exchange.Position.md#SHTCGClient.Models.Exchange.Position.UnrealizedPnlPercentage 'SHTCGClient\.Models\.Exchange\.Position\.UnrealizedPnlPercentage')** `Property`
- **[Symbol](SHTCGClient.Models.Exchange.Symbol.md 'SHTCGClient\.Models\.Exchange\.Symbol')** `Class` Additional exchange info
  - **[BaseCardId](SHTCGClient.Models.Exchange.Symbol.md#SHTCGClient.Models.Exchange.Symbol.BaseCardId 'SHTCGClient\.Models\.Exchange\.Symbol\.BaseCardId')** `Property`
  - **[BaseCardImageUrl](SHTCGClient.Models.Exchange.Symbol.md#SHTCGClient.Models.Exchange.Symbol.BaseCardImageUrl 'SHTCGClient\.Models\.Exchange\.Symbol\.BaseCardImageUrl')** `Property`
  - **[BaseCardName](SHTCGClient.Models.Exchange.Symbol.md#SHTCGClient.Models.Exchange.Symbol.BaseCardName 'SHTCGClient\.Models\.Exchange\.Symbol\.BaseCardName')** `Property`
  - **[Id](SHTCGClient.Models.Exchange.Symbol.md#SHTCGClient.Models.Exchange.Symbol.Id 'SHTCGClient\.Models\.Exchange\.Symbol\.Id')** `Property`
  - **[Name](SHTCGClient.Models.Exchange.Symbol.md#SHTCGClient.Models.Exchange.Symbol.Name 'SHTCGClient\.Models\.Exchange\.Symbol\.Name')** `Property`

<a name='SHTCGClient.Models.Features'></a>

## SHTCGClient\.Models\.Features Namespace
- **[Feature](SHTCGClient.Models.Features.Feature.md 'SHTCGClient\.Models\.Features\.Feature')** `Class` Represents a voting object for a potential new feature to the game\.
  - **[CreatedAt](SHTCGClient.Models.Features.Feature.md#SHTCGClient.Models.Features.Feature.CreatedAt 'SHTCGClient\.Models\.Features\.Feature\.CreatedAt')** `Property` The date this feature was added to the voting system\.
  - **[Description](SHTCGClient.Models.Features.Feature.md#SHTCGClient.Models.Features.Feature.Description 'SHTCGClient\.Models\.Features\.Feature\.Description')** `Property` The description of what this feature will accomplish\.
  - **[Id](SHTCGClient.Models.Features.Feature.md#SHTCGClient.Models.Features.Feature.Id 'SHTCGClient\.Models\.Features\.Feature\.Id')** `Property` Identifier of this feature\.
  - **[Name](SHTCGClient.Models.Features.Feature.md#SHTCGClient.Models.Features.Feature.Name 'SHTCGClient\.Models\.Features\.Feature\.Name')** `Property` This feature's name\.
  - **[UserHasVoted](SHTCGClient.Models.Features.Feature.md#SHTCGClient.Models.Features.Feature.UserHasVoted 'SHTCGClient\.Models\.Features\.Feature\.UserHasVoted')** `Property` Whether the user has voted for this feature\.
  - **[VoteCount](SHTCGClient.Models.Features.Feature.md#SHTCGClient.Models.Features.Feature.VoteCount 'SHTCGClient\.Models\.Features\.Feature\.VoteCount')** `Property` How many votes ths feature has received\.
- **[VoteStatus](SHTCGClient.Models.Features.VoteStatus.md 'SHTCGClient\.Models\.Features\.VoteStatus')** `Class` Information on when the user may vote for a feature again\.
  - **[CanVote](SHTCGClient.Models.Features.VoteStatus.md#SHTCGClient.Models.Features.VoteStatus.CanVote 'SHTCGClient\.Models\.Features\.VoteStatus\.CanVote')** `Property` Whether the user may vote currently
  - **[DaysUntilNextVote](SHTCGClient.Models.Features.VoteStatus.md#SHTCGClient.Models.Features.VoteStatus.DaysUntilNextVote 'SHTCGClient\.Models\.Features\.VoteStatus\.DaysUntilNextVote')** `Property` The days until the user is able to vote again
  - **[HoursUntilNextVote](SHTCGClient.Models.Features.VoteStatus.md#SHTCGClient.Models.Features.VoteStatus.HoursUntilNextVote 'SHTCGClient\.Models\.Features\.VoteStatus\.HoursUntilNextVote')** `Property` The hours until the user is able to vote again
  - **[LastVoteAt](SHTCGClient.Models.Features.VoteStatus.md#SHTCGClient.Models.Features.VoteStatus.LastVoteAt 'SHTCGClient\.Models\.Features\.VoteStatus\.LastVoteAt')** `Property` The last time the user voted
  - **[NextVoteAt](SHTCGClient.Models.Features.VoteStatus.md#SHTCGClient.Models.Features.VoteStatus.NextVoteAt 'SHTCGClient\.Models\.Features\.VoteStatus\.NextVoteAt')** `Property` The next time the user may vote

<a name='SHTCGClient.Models.Seasons'></a>

## SHTCGClient\.Models\.Seasons Namespace
- **[Deck](SHTCGClient.Models.Seasons.Deck.md 'SHTCGClient\.Models\.Seasons\.Deck')** `Class` Object containing cards for a season\.
  - **[CardCount](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.CardCount 'SHTCGClient\.Models\.Seasons\.Deck\.CardCount')** `Property`
  - **[CreatedAt](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.CreatedAt 'SHTCGClient\.Models\.Seasons\.Deck\.CreatedAt')** `Property`
  - **[Description](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Description 'SHTCGClient\.Models\.Seasons\.Deck\.Description')** `Property`
  - **[Id](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Id 'SHTCGClient\.Models\.Seasons\.Deck\.Id')** `Property`
  - **[Name](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Name 'SHTCGClient\.Models\.Seasons\.Deck\.Name')** `Property`
  - **[Owner](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Owner 'SHTCGClient\.Models\.Seasons\.Deck\.Owner')** `Property`
  - **[OwnerId](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.OwnerId 'SHTCGClient\.Models\.Seasons\.Deck\.OwnerId')** `Property`
  - **[Score](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Score 'SHTCGClient\.Models\.Seasons\.Deck\.Score')** `Property`
  - **[ScoreRating](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.ScoreRating 'SHTCGClient\.Models\.Seasons\.Deck\.ScoreRating')** `Property`
  - **[SeasonId](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.SeasonId 'SHTCGClient\.Models\.Seasons\.Deck\.SeasonId')** `Property`
  - **[UpdatedAt](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.UpdatedAt 'SHTCGClient\.Models\.Seasons\.Deck\.UpdatedAt')** `Property`
  - **[Add\(ClientService, int\)](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,int) 'SHTCGClient\.Models\.Seasons\.Deck\.Add\(SHTCGClient\.ClientService, int\)')** `Method` Adds a card to the deck
  - **[Add\(ClientService, Card\)](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Add(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card) 'SHTCGClient\.Models\.Seasons\.Deck\.Add\(SHTCGClient\.ClientService, SHTCGClient\.Models\.Cards\.Card\)')** `Method` Adds a card to the deck
  - **[Equals\(object\)](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Equals(object) 'SHTCGClient\.Models\.Seasons\.Deck\.Equals\(object\)')** `Method`
  - **[Equals\(Deck\)](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Equals(SHTCGClient.Models.Seasons.Deck) 'SHTCGClient\.Models\.Seasons\.Deck\.Equals\(SHTCGClient\.Models\.Seasons\.Deck\)')** `Method`
  - **[GetHashCode\(\)](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.GetHashCode() 'SHTCGClient\.Models\.Seasons\.Deck\.GetHashCode\(\)')** `Method`
  - **[Remove\(ClientService, int\)](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,int) 'SHTCGClient\.Models\.Seasons\.Deck\.Remove\(SHTCGClient\.ClientService, int\)')** `Method` Removes a card from the deck
  - **[Remove\(ClientService, Card\)](SHTCGClient.Models.Seasons.Deck.md#SHTCGClient.Models.Seasons.Deck.Remove(SHTCGClient.ClientService,SHTCGClient.Models.Cards.Card) 'SHTCGClient\.Models\.Seasons\.Deck\.Remove\(SHTCGClient\.ClientService, SHTCGClient\.Models\.Cards\.Card\)')** `Method` Removes a card from the deck
- **[Season](SHTCGClient.Models.Seasons.Season.md 'SHTCGClient\.Models\.Seasons\.Season')** `Class`
  - **[Cards](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.Cards 'SHTCGClient\.Models\.Seasons\.Season\.Cards')** `Property`
  - **[Description](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.Description 'SHTCGClient\.Models\.Seasons\.Season\.Description')** `Property`
  - **[EndDate](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.EndDate 'SHTCGClient\.Models\.Seasons\.Season\.EndDate')** `Property`
  - **[HoursTillEnd](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.HoursTillEnd 'SHTCGClient\.Models\.Seasons\.Season\.HoursTillEnd')** `Property`
  - **[Id](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.Id 'SHTCGClient\.Models\.Seasons\.Season\.Id')** `Property`
  - **[IsActive](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.IsActive 'SHTCGClient\.Models\.Seasons\.Season\.IsActive')** `Property`
  - **[Name](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.Name 'SHTCGClient\.Models\.Seasons\.Season\.Name')** `Property`
  - **[StartDate](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.StartDate 'SHTCGClient\.Models\.Seasons\.Season\.StartDate')** `Property`
  - **[Equals\(object\)](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.Equals(object) 'SHTCGClient\.Models\.Seasons\.Season\.Equals\(object\)')** `Method`
  - **[Equals\(Season\)](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.Equals(SHTCGClient.Models.Seasons.Season) 'SHTCGClient\.Models\.Seasons\.Season\.Equals\(SHTCGClient\.Models\.Seasons\.Season\)')** `Method`
  - **[GetHashCode\(\)](SHTCGClient.Models.Seasons.Season.md#SHTCGClient.Models.Seasons.Season.GetHashCode() 'SHTCGClient\.Models\.Seasons\.Season\.GetHashCode\(\)')** `Method`

<a name='SHTCGClient.Models.Users'></a>

## SHTCGClient\.Models\.Users Namespace
- **[BannerImage](SHTCGClient.Models.Users.BannerImage.md 'SHTCGClient\.Models\.Users\.BannerImage')** `Class` Banner information for a profile\. This is what appears above player's names in their profile page\.
  - **[Code](SHTCGClient.Models.Users.BannerImage.md#SHTCGClient.Models.Users.BannerImage.Code 'SHTCGClient\.Models\.Users\.BannerImage\.Code')** `Property`
  - **[Focus](SHTCGClient.Models.Users.BannerImage.md#SHTCGClient.Models.Users.BannerImage.Focus 'SHTCGClient\.Models\.Users\.BannerImage\.Focus')** `Property`
  - **[Id](SHTCGClient.Models.Users.BannerImage.md#SHTCGClient.Models.Users.BannerImage.Id 'SHTCGClient\.Models\.Users\.BannerImage\.Id')** `Property`
  - **[ImageUrl](SHTCGClient.Models.Users.BannerImage.md#SHTCGClient.Models.Users.BannerImage.ImageUrl 'SHTCGClient\.Models\.Users\.BannerImage\.ImageUrl')** `Property`
  - **[Name](SHTCGClient.Models.Users.BannerImage.md#SHTCGClient.Models.Users.BannerImage.Name 'SHTCGClient\.Models\.Users\.BannerImage\.Name')** `Property`
- **[Profile](SHTCGClient.Models.Users.Profile.md 'SHTCGClient\.Models\.Users\.Profile')** `Class` Additional user information, used on the profile page, leaderboard, and roll history
  - **[Avatar](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.Avatar 'SHTCGClient\.Models\.Users\.Profile\.Avatar')** `Property`
  - **[BannerColor](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.BannerColor 'SHTCGClient\.Models\.Users\.Profile\.BannerColor')** `Property`
  - **[Bio](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.Bio 'SHTCGClient\.Models\.Users\.Profile\.Bio')** `Property`
  - **[DisplayName](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.DisplayName 'SHTCGClient\.Models\.Users\.Profile\.DisplayName')** `Property` This User's display name\.
  - **[EquippedBannerImage](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.EquippedBannerImage 'SHTCGClient\.Models\.Users\.Profile\.EquippedBannerImage')** `Property`
  - **[EquippedTitle](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.EquippedTitle 'SHTCGClient\.Models\.Users\.Profile\.EquippedTitle')** `Property`
  - **[Id](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.Id 'SHTCGClient\.Models\.Users\.Profile\.Id')** `Property` This User's ID
  - **[IsAnonymous](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.IsAnonymous 'SHTCGClient\.Models\.Users\.Profile\.IsAnonymous')** `Property`
  - **[ProfileColor](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.ProfileColor 'SHTCGClient\.Models\.Users\.Profile\.ProfileColor')** `Property`
  - **[Username](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.Username 'SHTCGClient\.Models\.Users\.Profile\.Username')** `Property` This User's name\.
  - **[Equals\(object\)](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.Equals(object) 'SHTCGClient\.Models\.Users\.Profile\.Equals\(object\)')** `Method` Determines whether the specified object is equal to the current object\.
  - **[Equals\(Profile\)](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.Equals(SHTCGClient.Models.Users.Profile) 'SHTCGClient\.Models\.Users\.Profile\.Equals\(SHTCGClient\.Models\.Users\.Profile\)')** `Method`
  - **[GetHashCode\(\)](SHTCGClient.Models.Users.Profile.md#SHTCGClient.Models.Users.Profile.GetHashCode() 'SHTCGClient\.Models\.Users\.Profile\.GetHashCode\(\)')** `Method` Serves as the default hash function\.
- **[User](SHTCGClient.Models.Users.User.md 'SHTCGClient\.Models\.Users\.User')** `Class` User information\.
  - **[DateJoined](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.DateJoined 'SHTCGClient\.Models\.Users\.User\.DateJoined')** `Property` The date this user joined the game\.
  - **[Email](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.Email 'SHTCGClient\.Models\.Users\.User\.Email')** `Property` This user's email, if available\.
  - **[Id](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.Id 'SHTCGClient\.Models\.Users\.User\.Id')** `Property` This User's ID
  - **[IsActive](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.IsActive 'SHTCGClient\.Models\.Users\.User\.IsActive')** `Property` If this player is currently active
  - **[NetWorth](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.NetWorth 'SHTCGClient\.Models\.Users\.User\.NetWorth')** `Property` This user's current balance\.
  - **[Username](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.Username 'SHTCGClient\.Models\.Users\.User\.Username')** `Property` This User's name\.
  - **[Equals\(object\)](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.Equals(object) 'SHTCGClient\.Models\.Users\.User\.Equals\(object\)')** `Method` Determines whether the specified object is equal to the current object\.
  - **[Equals\(User\)](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.Equals(SHTCGClient.Models.Users.User) 'SHTCGClient\.Models\.Users\.User\.Equals\(SHTCGClient\.Models\.Users\.User\)')** `Method`
  - **[GetHashCode\(\)](SHTCGClient.Models.Users.User.md#SHTCGClient.Models.Users.User.GetHashCode() 'SHTCGClient\.Models\.Users\.User\.GetHashCode\(\)')** `Method` Serves as the default hash function\.

<a name='SHTCGClient.Models.Users.Leaderboards'></a>

## SHTCGClient\.Models\.Users\.Leaderboards Namespace
- **[Leaderboard](SHTCGClient.Models.Users.Leaderboards.Leaderboard.md 'SHTCGClient\.Models\.Users\.Leaderboards\.Leaderboard')** `Class` Player leaderboard for net worth / total cards
  - **[Entries](SHTCGClient.Models.Users.Leaderboards.Leaderboard.md#SHTCGClient.Models.Users.Leaderboards.Leaderboard.Entries 'SHTCGClient\.Models\.Users\.Leaderboards\.Leaderboard\.Entries')** `Property` Array of player rankings, sorted by the LeaderboardType
  - **[LeaderboardType](SHTCGClient.Models.Users.Leaderboards.Leaderboard.md#SHTCGClient.Models.Users.Leaderboards.Leaderboard.LeaderboardType 'SHTCGClient\.Models\.Users\.Leaderboards\.Leaderboard\.LeaderboardType')** `Property` The type of leaderboard
- **[LeaderboardEntry](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry')** `Class` Player rank entry on the leaderboard
  - **[LeaderboardName](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md#SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.LeaderboardName 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry\.LeaderboardName')** `Property` This player's display name
  - **[NetWorth](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md#SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.NetWorth 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry\.NetWorth')** `Property` This user's current balance\.
  - **[Rank](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md#SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.Rank 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry\.Rank')** `Property` This player's position on the leaderboard
  - **[TotalCards](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md#SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.TotalCards 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry\.TotalCards')** `Property` This player's total owned cards\.
  - **[UserId](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md#SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.UserId 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry\.UserId')** `Property` This User's ID
  - **[Username](SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.md#SHTCGClient.Models.Users.Leaderboards.LeaderboardEntry.Username 'SHTCGClient\.Models\.Users\.Leaderboards\.LeaderboardEntry\.Username')** `Property` This User's name\.

<a name='SHTCGClient.Models.Vendors'></a>

## SHTCGClient\.Models\.Vendors Namespace
- **[CardSellResponse](SHTCGClient.Models.Vendors.CardSellResponse.md 'SHTCGClient\.Models\.Vendors\.CardSellResponse')** `Class` Information for a sold card\.
  - **[CardCount](SHTCGClient.Models.Vendors.CardSellResponse.md#SHTCGClient.Models.Vendors.CardSellResponse.CardCount 'SHTCGClient\.Models\.Vendors\.CardSellResponse\.CardCount')** `Property`
  - **[Message](SHTCGClient.Models.Vendors.CardSellResponse.md#SHTCGClient.Models.Vendors.CardSellResponse.Message 'SHTCGClient\.Models\.Vendors\.CardSellResponse\.Message')** `Property`
  - **[NetWorth](SHTCGClient.Models.Vendors.CardSellResponse.md#SHTCGClient.Models.Vendors.CardSellResponse.NetWorth 'SHTCGClient\.Models\.Vendors\.CardSellResponse\.NetWorth')** `Property`
  - **[TotalValue](SHTCGClient.Models.Vendors.CardSellResponse.md#SHTCGClient.Models.Vendors.CardSellResponse.TotalValue 'SHTCGClient\.Models\.Vendors\.CardSellResponse\.TotalValue')** `Property`
- **[Vendor](SHTCGClient.Models.Vendors.Vendor.md 'SHTCGClient\.Models\.Vendors\.Vendor')** `Class` Shop NPC information\.
  - **[Avatar](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Avatar 'SHTCGClient\.Models\.Vendors\.Vendor\.Avatar')** `Property`
  - **[AvatarSmall](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.AvatarSmall 'SHTCGClient\.Models\.Vendors\.Vendor\.AvatarSmall')** `Property`
  - **[Background](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Background 'SHTCGClient\.Models\.Vendors\.Vendor\.Background')** `Property`
  - **[Description](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Description 'SHTCGClient\.Models\.Vendors\.Vendor\.Description')** `Property`
  - **[Id](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Id 'SHTCGClient\.Models\.Vendors\.Vendor\.Id')** `Property`
  - **[IsLocked](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.IsLocked 'SHTCGClient\.Models\.Vendors\.Vendor\.IsLocked')** `Property`
  - **[Name](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Name 'SHTCGClient\.Models\.Vendors\.Vendor\.Name')** `Property`
  - **[Slug](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Slug 'SHTCGClient\.Models\.Vendors\.Vendor\.Slug')** `Property`
  - **[Title](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Title 'SHTCGClient\.Models\.Vendors\.Vendor\.Title')** `Property`
  - **[Url](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Url 'SHTCGClient\.Models\.Vendors\.Vendor\.Url')** `Property`
  - **[Equals\(object\)](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Equals(object) 'SHTCGClient\.Models\.Vendors\.Vendor\.Equals\(object\)')** `Method`
  - **[Equals\(Vendor\)](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.Equals(SHTCGClient.Models.Vendors.Vendor) 'SHTCGClient\.Models\.Vendors\.Vendor\.Equals\(SHTCGClient\.Models\.Vendors\.Vendor\)')** `Method`
  - **[GetHashCode\(\)](SHTCGClient.Models.Vendors.Vendor.md#SHTCGClient.Models.Vendors.Vendor.GetHashCode() 'SHTCGClient\.Models\.Vendors\.Vendor\.GetHashCode\(\)')** `Method`