using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EntPosts
    {
        public string PostId { get; set; }
        
        public string title { get; set; }

        public string content { get; set; }

        public int timeUploaded { get; set; }

        public String TimePassed { get; set; }
    }
}
