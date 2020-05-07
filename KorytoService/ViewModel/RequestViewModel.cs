using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KorytoService.ViewModel
{
    public class RequestViewModel
    {
        public int Id { get; set; }

        [DisplayName("Дата оформления")]
        public DateTime DateCreate { get; set; }

        public List<DetailRequestViewModel> DetailRequests { get; set; }
    }
}
