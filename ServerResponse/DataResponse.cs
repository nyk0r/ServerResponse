using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerResponse
{
    public class DataResponse : ResponseBase
    {
        public IEnumerable<object> Data { get; set; }
        public int TotalCount { get; set; }
    }
}
