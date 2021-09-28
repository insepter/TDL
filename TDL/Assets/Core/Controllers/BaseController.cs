using System.Collections;
using UnityEngine;

namespace Assets.Core
{
    public abstract class BaseController<T> where T : class
    {
        protected T UIInstance { get; set; }
        public BaseController()
        {
            Debug.Log($"Controller: {this.GetType().Name}");
            UIInstance = UIManager.Instatnce.GetInstanceUI<T>(typeof(T));
        }
    }
}
