using KorytoService.BindingModel;
using KorytoService.ViewModel;
using System.Collections.Generic;

namespace KorytoService.Interfaces
{
    public interface IDetailService
    {
        List<DetailViewModel> GetList();

        DetailViewModel GetElement(int id);

        void AddElement(DetailBindingModel model);

        void UpdateElement(DetailBindingModel model);

        void DeleteElement(int id);
    }
}