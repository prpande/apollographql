namespace Odyssey.MusicMatcher.Types
{
    [GraphQLDescription("A curated collection of tracks designed for a specific activity or mood.")]
    public class Playlist
    {
        [ID]
        [GraphQLDescription("The ID for the playlist.")]
        public string Id { get; }

        [GraphQLDescription("The name of the playlist.")]
        public string Name { get; set; }

        [GraphQLDescription("Describes the playlist, what to expect and entices the user to listen.")]
        public string? Description { get; set; }

        [GraphQLDescription("The list of the songs in the playlist.")]
        public string[] Songs { get; set; }

        public Playlist(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
