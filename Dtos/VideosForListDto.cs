using System;
using System.Collections.Generic;

namespace VideoIdxApp.API.Dtos
{
    public class VideosForListDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Duration { get; set; }
        public string Created { get; set; }
        
       /* public string UserName { get; set; }
        public string SourceLanguage { get; set; }
        public string ProcessingProgress { get; set; }
        public string PrivacyMode { get; set; } */
        public string AccessToken { get; set; }
        public string ThumbnailId { get; set; }     
        public string Base64ThumbnailImage {get; set;}
        public string EmbedPlayerUrl { get; set; }   
        public string EmbedInsightsUrl { get; set; }
    }
}