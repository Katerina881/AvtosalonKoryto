using System;
using System.Collections.Generic;

namespace KorytoService.ViewModel
{
    public class LoadRequestReportViewModel
    {
        public string DateCreate { get; set; }
        
        public IEnumerable<Tuple<string, int>> Details { get; set; }
    }
}
