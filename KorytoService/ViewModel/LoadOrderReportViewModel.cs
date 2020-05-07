using System.Collections.Generic;

namespace KorytoService.ViewModel
{
    public class LoadOrderReportViewModel
    {
        public string DateCreate { get; set; }

        public int OrderId { get; set; }

        public int CarId { get; set; }

        public string CarName { get; set; }

        public int CarAmount { get; set; }

        public List<CarDetailViewModel> Details { get; set; }
    }
}
