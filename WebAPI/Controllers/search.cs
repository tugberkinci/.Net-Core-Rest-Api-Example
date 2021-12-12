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
using System.Text;

namespace WebAPI.Controllers
{

 
    [ApiController]
    [Route("api_base/[controller]")]
    public class search : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public search(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public JsonResult Post(SearchModel sm)
        {
            string client_id = "-1crg8D_obRhgc2tkC8DsaXf5id6i5ym-tzml6xWuvc";

            //string qq = sm.query;
            var url = string.Format($"https://api.unsplash.com/search/photos?page=1&per_page={sm.per_page}&order_by=latest&query={sm.query}&client_id={client_id}");

            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "GET";
            HttpWebResponse responseObject = (HttpWebResponse)requestObject.GetResponse();
            string streamResult = null;
            
            using (Stream stream = responseObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                streamResult = sr.ReadLine();
                sr.Close();

            }

            JObject json = JObject.Parse(streamResult);
            string first = "{ \"Images\": { ";
            string last = " } }";
            string urlReturn =null ;
            for (int i = 0; i < sm.per_page; i++)
            {
              
                
                urlReturn =urlReturn+ $"\"img{i+1}_URL\":" + "\"" + (string)json["results"][i]["urls"]["full"]+ "\"," ;
                
            }
           

            urlReturn = first+urlReturn+last ;

            return new JsonResult(JObject.Parse(urlReturn));


            
        }

       



    }
}