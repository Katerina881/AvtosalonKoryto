using System;
using System.Collections.Generic;

namespace KorytoService.BindingModel
{
    public class RequestBindingModel
    {
        public int Id { get; set; }

        public DateTime DateCreate { get; set; }

        public List<DetailRequestBindingModel> DetailRequests { get; set; }
    }
}
