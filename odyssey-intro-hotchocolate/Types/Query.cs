using Odyssey.MusicMatcher.Types;
using SpotifyWeb;
using Playlist = Odyssey.MusicMatcher.Types.Playlist;

namespace Odyssey.MusicMatcher
{
    public class Query
    {
        [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
        public async Task<List<Playlist>> FeaturedPlaylists(SpotifyService spotifyService)
        {
            var response = await spotifyService.GetFeaturedPlaylistsAsync();
            var playlists = response.Playlists.Items.Select(playlist => new Playlist(playlist));
            return playlists.ToList();
        }

        [GraphQLDescription("Retrieves a specific playlist.")]
        public async Task<Playlist>? GetPlaylist([ID] string id, SpotifyService spotifyService)
        {
            var response = await spotifyService.GetPlaylistAsync(id);
            return new Playlist(response);
        }
    }
}
