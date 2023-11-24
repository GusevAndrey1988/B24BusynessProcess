using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B24Api.Crm
{
    public class FieldDescription
    {
        public string? Type { get; set; } = null;
        public string? UppeName { get; set; } = null;
        public string? Title { get; set; } = null;
        public bool IsRequired { get; set; } = false;
    }
}
