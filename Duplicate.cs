using Newtonsoft.Json;
using System.Collections.Generic;

namespace SearchForlder
{
    [JsonObject]
    public class Duplicate
    {
        public long size { get; set; }
        public List<string> folders { get; set; }
    }
}
