using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityExt.Web.Models
{
    interface IGroup
    {
        // Summary:
        //     Id of the group
        string Id { get; }
        string Name { get; set; }
    }
}
