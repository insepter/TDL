using System.Collections;
using UnityEngine;

namespace TDL.Controller
{
    public class ConManage : MonoBehaviour
    {
        public TestCon SubTestCon { get; set; }
        public TestCon2 SubTestCon2 { get; set; }
        IEnumerator Start()
        {
            Debug.Log($"Block Start Before Views");
            yield return new WaitForEndOfFrame();
            Debug.Log($"AfterC");
            SubTestCon = new TestCon
            {
                Score = "Score: 50"
            };
            SubTestCon2 = new TestCon2();
        }
    }
}
