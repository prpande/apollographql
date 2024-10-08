﻿using SpotifyWeb;

namespace Odyssey.MusicMatcher.Types
{
    [GraphQLDescription("A curated collection of tracks designed for a specific activity or mood.")]
    public class Playlist
    {
        private List<Track>? _tracks;

        [ID]
        [GraphQLDescription("The ID for the playlist.")]
        public string Id { get; }

        [GraphQLDescription("The name of the playlist.")]
        public string Name { get; set; }

        [GraphQLDescription("Describes the playlist, what to expect and entices the user to listen.")]
        public string? Description { get; set; }

        [GraphQLDescription("The playlist's tracks.")]
        public async Task<List<Track>> Tracks(SpotifyService spotifyService)
        {
            if(_tracks == null)
            {
                var response = await spotifyService.GetPlaylistsTracksAsync(Id);
                _tracks = response.Items.Select(item => new Track(item.Track)).ToList();
            }

            return _tracks;
        }

        public Playlist(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public Playlist(PlaylistSimplified obj)
        {
            Id = obj.Id;
            Name = obj.Name;
            Description = obj.Description;
        }

        public Playlist(SpotifyWeb.Playlist playlist)
        {
            Id = playlist.Id;
            Name = playlist.Name;
            Description = playlist.Description;
            _tracks = playlist.Tracks.Items.Select(item => new Track(item.Track)).ToList();
        }
    }
}
