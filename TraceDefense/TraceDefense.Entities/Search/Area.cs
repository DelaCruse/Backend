﻿using Newtonsoft.Json;
using TraceDefense.Entities.Geospatial;

namespace TraceDefense.Entities.Search
{
    /// <summary>
    /// Defined search region
    /// </summary>
    [JsonObject]
    public class Area
    {
        /// <summary>
        /// First corner of search region
        /// </summary>
        [JsonProperty("first", Required = Required.Always)]
        public Location First { get; set; }


        /// <summary>
        /// Second corner of search region
        /// </summary>
        [JsonProperty("second", Required = Required.Always)]
        public Location Second { get; set; }


        /// <summary>
        /// Time range
        /// </summary>
        [JsonProperty("range", Required = Required.Always)]
        public TimeRange TimeRange { get; set; }
    }
}
