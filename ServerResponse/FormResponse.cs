using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerResponse
{
    public class FormResponse : ResponseBase
    {
        public string Code { get; set; }

        public IEnumerable<string> ErrorMessages { get; set; }
        public IEnumerable<string> WarningMessages { get; set; }
        public IEnumerable<string> Successessages { get; set; }

        public IEnumerable<FieldStatus> Fields { get; set; }
    }
}
