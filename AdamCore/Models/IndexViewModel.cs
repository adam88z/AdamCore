using System;
using System.Linq;
using System.Data;


namespace AdamCore.Models
{

    public class IndexViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

}
