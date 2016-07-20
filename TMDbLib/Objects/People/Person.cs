﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using TMDbLib.Helpers;
using TMDbLib.Objects.Changes;
using TMDbLib.Objects.General;

namespace TMDbLib.Objects.People
{
    public class Person
    {
        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("also_known_as")]
        public List<string> AlsoKnownAs { get; set; }

        [JsonProperty("biography")]
        public string Biography { get; set; }

        [JsonProperty("birthday")]
        [JsonConverter(typeof(TmdbPartialDateConverter))]
        public DateTime? Birthday { get; set; }

        [JsonProperty("deathday")]
        [JsonConverter(typeof(TmdbPartialDateConverter))]
        public DateTime? Deathday { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("place_of_birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePath { get; set; }

        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }
        
        [JsonProperty("images")]
        public ProfileImages Images { get; set; }

        [JsonProperty("changes")]
        public ChangesContainer Changes { get; set; }

        [JsonProperty("movie_credits")]
        public MovieCredits MovieCredits { get; set; }

        [JsonProperty("tv_credits")]
        public TvCredits TvCredits { get; set; }

        [JsonProperty("tagged_images")]
        public SearchContainer<TaggedImage> TaggedImages { get; set; }

        [JsonProperty("external_ids")]
        public ExternalIds ExternalIds { get; set; }
    }
}