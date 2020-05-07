using KorytoService.BindingModel;
using KorytoService.ViewModel;
using System.Collections.Generic;

namespace KorytoService.Interfaces
{
    public interface IRequestService
    {
        List<RequestViewModel> GetList();

        RequestViewModel GetElement(int id);

        void AddElement(RequestBindingModel model);

        void DeleteElement(int id);

        LoadRequestReportViewModel GetDetailsRequest(int id);

        void SaveRequestToWord(LoadRequestReportViewModel request, string fileName);

        void SaveRequestToExcel(LoadRequestReportViewModel request, string fileName);
    }
}