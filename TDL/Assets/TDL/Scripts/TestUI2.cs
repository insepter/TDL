using Assets.Core;
using TMPro;

namespace TDL.View
{
    public interface IStatus
    {
        void SetStatus(string result);
    }
    public class TestUI2 : BaseUI, IStatus
    {
        public TextMeshProUGUI statusTMP;
        public void SetStatus(string result) => statusTMP.text = result;
    }
}