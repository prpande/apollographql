using Odyssey.MusicMatcher.Types;

namespace Odyssey.MusicMatcher
{
    public class Query
    {
        [GraphQLDescription("Playlists hand-picked to be featured to all users.")]
        public List<Playlist> FeaturedPlaylists()
        {
            return new List<Playlist>
            {
                new Playlist("1", "GraphQL Groovin'"),
                new Playlist("2", "Graph Explorer Jams"),
                new Playlist("3", "Interpretive GraphQL Dance")
            };
        }
    }
}
