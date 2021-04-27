using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AERestAPI.Model {
    public class WitchEditModel {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Witch name is required")]
        public string Name { get; set; }
        public string watching { get; set; }
        public List<WatchEditModel> AvailableWatches = new List<WatchEditModel>();
    }
}
