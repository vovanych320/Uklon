using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener.Models;

namespace UrlShortener.Domain.Abstract
{
    public interface IShortUrlService
    {
        ShortUrl GetById(int id);

        ShortUrl GetByPath(string path);

        ShortUrl GetByOriginalUrl(string originalUrl);

        int Save(ShortUrl shortUrl);
    }
}
