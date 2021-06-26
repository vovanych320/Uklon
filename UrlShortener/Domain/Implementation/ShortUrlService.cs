using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener.Models;

namespace UrlShortener.Domain.Abstract
{
    public class ShortUrlService : IShortUrlService
    {
        private readonly UrlShortenerContext _context;

        public ShortUrlService(UrlShortenerContext context)
        {
            _context = context;
        }

        public ShortUrl GetById(int id)
        {
            return _context.ShortUrls.Find(id);
        }

        public ShortUrl GetByPath(string path)
        {
            return _context.ShortUrls.Find(ShortUrlHelper.Decode((path)));
        }

        public ShortUrl GetByOriginalUrl(string originalUrl)
        {
            foreach (var shortUrl in _context.ShortUrls) {
                if (shortUrl.OriginalUrl == originalUrl) {
                    return shortUrl;
                }
            }

            return null;
        }

        public int Save(ShortUrl shortUrl)
        {
            _context.ShortUrls.Add(shortUrl);
            _context.SaveChanges();

            return shortUrl.Id;
        }
    }
}
