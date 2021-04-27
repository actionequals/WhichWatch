using System;
using System.ComponentModel.DataAnnotations;

namespace AERestAPI.Model {
    public class WatchEditModel {
        public string Key { get; set; } = Guid.NewGuid().ToString();
        [Required(ErrorMessage = "Watch name is required")]
        public string Name { get; set; }
    }
}
