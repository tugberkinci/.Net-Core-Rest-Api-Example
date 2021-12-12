using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using WebAPI.Models;

using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api_base/[controller]")]
    public class random : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public random(IConfiguration configuration)
        {
            _configuration = configuration;
        }


     

        [HttpGet]
        public JsonResult Get(int limit)
        {

            //var randomImage = await UnsplashService.RandomImage();
            //var uriSource = new Uri(randomImage.urls, UriKind.Absolute);

            string client_id = "-1crg8D_obRhgc2tkC8DsaXf5id6i5ym-tzml6xWuvc";
            var url = string.Format($"https://api.unsplash.com/photos/random?client_id={client_id}");

            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "GET";
            HttpWebResponse responseObject = null;
            responseObject = (HttpWebResponse)requestObject.GetResponse();
            string streamResult = null;
            string urlret = null;
            JObject json=null;
            string first = "{ \"Images\": { ";
            string last = " } }";
            
            for (int i = 0; i < limit; i++)
            {
                using (Stream stream = responseObject.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(stream);
                    streamResult =streamResult+ sr.ReadLine();
                    sr.Close();

                }
                json = JObject.Parse(streamResult);
                urlret = urlret + $"\"img{i+1}_URL\":" +"\""+ (string)json["urls"]["full"]+"\",";
                
            }

            urlret = first + urlret + last;

            return new JsonResult(JObject.Parse(urlret));
        }

    


    }
}