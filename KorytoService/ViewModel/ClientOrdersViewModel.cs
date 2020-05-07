using System.Collections.Generic;

namespace KorytoService.ViewModel
{
    public class ClientOrdersViewModel
    {
        public string ClientName { get; set; }

        public string DateCreateOrder { get; set; }

        public List<OrderCarViewModel> OrderCars { get; set; }

        public decimal TotalSum { get; set; }

        public string StatusOrder { get; set; }
    }
}
