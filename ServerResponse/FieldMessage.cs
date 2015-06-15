using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerResponse
{
    public class FieldMessageBase
    {
        public string Message { get; set; }
    }

    public class ErrorFieldMessage : FieldMessageBase
    {
        public FieldErrorMessageTypes Type { get; set; }
    }

    public class WarningFieldMessage : FieldMessageBase
    {
        public FieldWarningMessageTypes Type { get; set; }
    }

    public class SuccessFieldMessage : FieldMessageBase
    {
        public FieldSuccessMessageTypes Type { get; set; }
    }
}
