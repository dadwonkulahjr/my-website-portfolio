using Microsoft.AspNetCore.Mvc;

namespace mypersonalwebsite.Controllers
{
    public class SitemapController : Controller
    {
        private const string DEFAULTSITEURL = "https://dadwonkulahjr.dev";
        // Action method to generate the sitemap
        public IActionResult Index()
        {
            // List of URLs to include in the sitemap
            List<string> urls = new List<string>
            {
                Url.Action("Index", "Home", null, Request.Scheme), // Example: Home/Index
                Url.Action("ContactMe", "Home",null, Request.Scheme), // Example: Home/About
                Url.Action("AboutMe", "Home",null, Request.Scheme), 
                // Add more URLs as needed
            };

            // Generate the sitemap XML
            string xml = GenerateSitemapXml(urls, DEFAULTSITEURL);

            // Return the XML content
            return Content(xml, "application/xml");
        }

        // Helper method to generate sitemap XML
        private string GenerateSitemapXml(List<string> urls, string baseUrl)
        {
            // Construct the XML string
            string xml = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                          <urlset xmlns=""http://www.sitemaps.org/schemas/sitemap/0.9"">";

            foreach (var url in urls)
            {
                // Ensure absolute URLs
                string absoluteUrl = new Uri(new Uri(baseUrl), url).AbsoluteUri;
                xml += $@"<url><loc>{absoluteUrl}</loc></url>";
            }

            xml += "</urlset>";
            return xml;
        }

    }
}
