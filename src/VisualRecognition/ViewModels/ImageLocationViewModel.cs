﻿using Newtonsoft.Json;

namespace VisualRecognition.ViewModels
{
    public class ImageLocationViewModel
    {
        [JsonProperty("left")]
        public int LeftOffset { get; set; }
        [JsonProperty("top")]
        public int TopOffset { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}