using Assets.Core;
using TDL.View;

namespace TDL.Controller
{
    public class TestCon : BaseController<ITest>
    {
        string _score;
        public string Score 
        {
            get => _score;
            set => UIInstance?.SetScore(_score = value);
        }
    }
}
