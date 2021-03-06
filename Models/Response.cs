using Newtonsoft.Json;

namespace TodoApiNet.Models
{
    public class Response<T> where T : class
    {
        public bool Status { get; set; }

        public T Data { get; set; }

        public string Message { get; set; } = "OK";

        [JsonProperty("paginate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Paginate Paginate { get; set; } = null;
    }
}