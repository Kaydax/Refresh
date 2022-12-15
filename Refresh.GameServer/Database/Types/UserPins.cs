using Newtonsoft.Json;
using Realms;

namespace Refresh.GameServer.Database.Types; 

public class UserPins : EmbeddedObject {
	[JsonProperty(PropertyName = "progress")]
	public IList<long> Progress { get; }
	[JsonProperty(PropertyName = "awards")]
	public IList<long> Awards { get; }
	[JsonProperty(PropertyName = "profile_pins")]
	public IList<long> ProfilePins { get; }
}