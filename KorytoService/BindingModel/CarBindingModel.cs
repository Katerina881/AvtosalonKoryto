using System.Collections.Generic;

namespace KorytoService.BindingModel
{
    public class CarBindingModel
    {
        public int Id { get; set; }

        public string CarName { get; set; }

        public decimal Price { get; set; }

        public int Year { get; set; }

        public virtual List<CarDetailBindingModel> CarDetails { get; set; }

    }
}
