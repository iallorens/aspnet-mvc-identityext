using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IdentityExt.Web.Models
{
    public class Group : IGroup
    {
        public Group() { }
        public Group(string groupName);

        public string Id { get; set; }
        public string Name { get; set; }
    }
}