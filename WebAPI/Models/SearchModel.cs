using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class SearchModel
    {
        public string query { get; set; }
        public int per_page { get; set; }

    }
}