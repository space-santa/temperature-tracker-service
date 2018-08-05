﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Windows.Data.Json;
using Logger;

namespace BackgroundApplication1
{
    class PostWriter : ITemperatureWriter
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task Write(string value)
        {
            var json = new JsonObject();
            json.Add("device", JsonValue.CreateStringValue(Config.Instance.Device));
            json.Add("timestamp", JsonValue.CreateStringValue(DateTime.UtcNow.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:sszzz")));
            json.Add("temperature", JsonValue.CreateStringValue(value));

            var content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
            Log.Instance.Write(json.ToString());

            try
            {
                var response = await client.PostAsync(Config.Instance.EndPoint, content);
                var responseString = await response.Content.ReadAsStringAsync();
                Log.Instance.Write($"Got this response: {responseString}!");
            }
            catch (HttpRequestException e)
            {
                Log.Instance.Write(e.Message);
                Log.Instance.Write(e.ToString());
            }
        }
    }
}
