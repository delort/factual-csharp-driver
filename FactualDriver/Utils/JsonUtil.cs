﻿using FactualDriver.Filters;
using Newtonsoft.Json;
using System.Linq;
using System.Web;

namespace FactualDriver.Utils
{
    /// <summary>
    /// Utility which convertes filters to json represenation. 
    /// </summary>
    public class JsonUtil
    {

         /// <summary>
         /// Converts an array of filters into a uri encoded query string which can be sent to factual api.
         /// </summary>
         /// <param name="filters">A parameter array of IFilter objects.</param>
         /// <returns>Returns uri encoded query string.</returns>
         public static string ToQueryString(params IFilter[] filters)
         {
             var parameters = filters.Select(filter => string.Format("{0}={1}", filter.Name, HttpUtility.UrlEncode(JsonConvert.SerializeObject(filter)))).ToList();
             return string.Join("&", parameters);
         }
    }
}
