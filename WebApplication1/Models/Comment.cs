using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int MemberID { get; set; }
        public string Content { get; set; }
    }
}
