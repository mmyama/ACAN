using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACANApp.Views
{

    public class MasterDetailACANMasterMenuItem
    {
        public MasterDetailACANMasterMenuItem()
        {
            TargetType = typeof(MasterDetailACANMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}