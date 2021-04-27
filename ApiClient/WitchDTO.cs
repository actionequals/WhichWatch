using System;

namespace AERestAPI.ApiClient {
    public class WitchDTO {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string watching { get; set; }    //watch key
    }
}
