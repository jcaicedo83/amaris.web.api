using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amaris.web.api.core.dto
{
    public class DummyResponse
    {
        public string status {  get; set; }
        public List<Employee> data { get; set; }
        public string message { get; set; }
    }
    public class SingleDummyResponse
    {
        public string status { get; set; }
        public Employee data { get; set; }
        public string message { get; set; }
    }
}
