using SpotifyWeb;

namespace Odyssey.MusicMatcher.Types
{
    public class Mutation
    {
        [GraphQLDescription("Add one or more items to a user's playlist.")]
        public async Task<AddItemsToPlaylistPayload> AddItemsToPlaylist(SpotifyService spotifyService)
        {
            return new AddItemsToPlaylistPayload(200, true, "Successfully added items to playlist.", null);
        }
    }
}
