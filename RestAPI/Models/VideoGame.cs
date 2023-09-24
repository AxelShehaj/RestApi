using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Studio { get; set; }
    }
}
