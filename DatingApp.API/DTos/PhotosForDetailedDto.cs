using System;

namespace DatingApp.API.DTos
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Descritption { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}