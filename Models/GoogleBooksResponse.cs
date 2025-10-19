using System.Collections.Generic;

namespace BibliotecaApi.Models
{
    public class GoogleBooksResponse
    {
        public List<GoogleBookItem> items { get; set; }
    }

    public class GoogleBookItem
    {
        public VolumeInfo volumeInfo { get; set; }
    }

    public class VolumeInfo
    {
        public string? title { get; set; }
        public List<string>? authors { get; set; }
    }
}
