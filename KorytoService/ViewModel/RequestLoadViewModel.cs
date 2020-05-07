using System;
using System.Collections.Generic;

namespace KorytoService.ViewModel
{
    public class RequestLoadViewModel
    {
        public string DateRequst { get; set; }

        public IEnumerable<Tuple<string, int>> Details { get; set; }
    }
}
