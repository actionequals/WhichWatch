using System;
namespace AERestAPI.ApiClient {
    public class WatchDTO {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
    }
}
