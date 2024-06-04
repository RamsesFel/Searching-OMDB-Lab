using Newtonsoft.Json;
using System.Net;

namespace Searching_OMDB_Lab.Models
{
    public class MovieDAL
    {
        public static MovieModel GetMovie(string Movie) 
        {
            string url = $"http://www.omdbapi.com/?apikey={Secret.apiKey}&s={Movie}"; 

            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();


            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);
            return result;
        }
    }
}
