using Assets.Core;
using TMPro;
namespace TDL.View
{
    public interface ITest
    {
        void SetScore(string result);
    }
    public class TestUI : BaseUI, ITest
    {
        public TextMeshProUGUI scoreTMP;
        public void SetScore(string result) => scoreTMP.text = result;
    }
}
