using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace JSON_Processing
{
    class Program
    {
        private const string telerikYoutubeRSS = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        private const string xmlFileName = "../../videos.xml";

        static void Main()
        {
            DonwloadXml(telerikYoutubeRSS, xmlFileName);
            string xmlContent = GetRssContent(telerikYoutubeRSS, xmlFileName);
            string json = ConvertXmlToJson(xmlContent);

            var titles = GetVideoTitles(json);
            PrintTitles(titles);

            var videos = GetVideos(json);
            GenerateHtml(videos);
        }

        private static void DonwloadXml(string url, string fileName)
        {
            WebClient myWebClient = new WebClient { Encoding = Encoding.UTF8 };
            myWebClient.DownloadFile(url, fileName);
        }

        private static string GetRssContent(string url, string fileName)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            var data = webClient.DownloadData(url);
            string result = Encoding.UTF8.GetString(data);

            return result;
        }

        private static string ConvertXmlToJson(string xmlContent)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);

            var json = JsonConvert.SerializeObject(xmlDoc, Newtonsoft.Json.Formatting.Indented);

            return json;
        }

        private static IEnumerable<JToken> GetVideoTitles(string json)
        {
            var jsonObject = JObject.Parse(json);
            IEnumerable<JToken> allVideoTitles = jsonObject["feed"]["entry"]
                   .Select(entry => entry["title"]);

            return allVideoTitles;
        }

        private static void PrintTitles(IEnumerable<JToken> titles)
        {
            var counter = 1;
            foreach (var title in titles)
            {
                Console.WriteLine("{0}. {1}", counter, title);
                counter++;
            }
        }

        private static IEnumerable<Video> GetVideos(string json)
        {
            var jsonObject = JObject.Parse(json);
            IEnumerable<Video> allVideos = jsonObject["feed"]["entry"]
                   .Select(entry => JsonConvert.DeserializeObject<Video>(entry.ToString()));

            return allVideos;
        }

        private static void GenerateHtml(IEnumerable<Video> videos)
        {
            var html = "<!DOCTYPE html><html><head><meta charset=\"UTF-8\"></head><body>";

            foreach (var video in videos)
            {
                var date = video.Date.ToString("d MMM yyy, HH:mm:ss",
                    CultureInfo.CreateSpecificCulture("bg-BG"));

                html += string.Format("<div style=\"float:left; width: 400px; height: 530px; padding:10px;" +
                                  "margin:5px; background-color:#ffd2d2; border-radius:5px\">" +
                                  "<iframe width=\"400\" height=\"325\" " +
                                  "src=\"http://www.youtube.com/embed/{2}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "<h3>{0}</h3><h4>Автор: {1}</h4><h4>Публикувано на: {2}</h4><a href=\"{3}\"><button>" +
                                  "<strong>Go to YouTube</strong></button></a></div>",
                                  video.Title, video.Author.Name, date, video.Link.Href);
            }

            html += ("</body></html>");

            File.WriteAllText("../../index.html", html);
        }
    }
}
