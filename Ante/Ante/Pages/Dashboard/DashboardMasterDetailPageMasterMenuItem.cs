using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ante.Pages.Dashboard
{

    public class DashboardMasterDetailPageMasterMenuItem
    {
        public DashboardMasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(DashboardMasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}