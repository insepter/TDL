using Assets.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDL.Model;
using TDL.View;

namespace TDL.Controller
{
    public class TestCon2 : BaseController<IStatus>
    {
        public StatusModel Status { get; set; } = new StatusModel();
        public TestCon2()
        {
            Status.Atk = "50";
            UIInstance?.SetStatus(Status.Atk);
        }
    }
}
