using KorytoService.BindingModel;
using KorytoService.ViewModel;
using System.Collections.Generic;

namespace KorytoService.Interfaces
{
    public interface IClientService
    {
        List<ClientViewModel> GetList();

        ClientViewModel GetElement(int id);

        void AddElement(ClientBindingModel model);

        void UpdateElement(ClientBindingModel model);

        void DeleteElement(int id);
    }
}