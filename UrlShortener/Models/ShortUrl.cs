using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortener.Models
{
    public class ShortUrl
    {
        public int Id { get; set; }

        [Required]
        public string OriginalUrl { get; set; }
    }
}
