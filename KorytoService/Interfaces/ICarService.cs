using KorytoService.BindingModel;
using KorytoService.ViewModel;
using System.Collections.Generic;

namespace KorytoService.Interfaces
{
    public interface ICarService
    {
        List<CarViewModel> GetList();

        List<CarViewModel> GetFilteredList();

        CarViewModel GetElement(int id);

        void AddElement(CarBindingModel model);

        void UpdateElement(CarBindingModel model);

        void DeleteElement(int id);
    }
}
