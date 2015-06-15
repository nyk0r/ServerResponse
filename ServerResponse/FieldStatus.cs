using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerResponse
{
    public class FieldStatus
    {
        public string Name { get; set; }
        public IEnumerable<ErrorFieldMessage> ErrorMessages { get; set; }
        public IEnumerable<WarningFieldMessage> WarningMessages { get; set; }
        public IEnumerable<SuccessFieldMessage> SuccessMessages { get; set; }
    }
}
