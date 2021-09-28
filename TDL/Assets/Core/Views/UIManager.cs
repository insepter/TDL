using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Core
{
    public class UIManager : LazySingleton<UIManager>
    {
        readonly IList<BaseUI> _allUIInScene = new List<BaseUI>();
        void Awake()
        {
            // Run OnEnable
            SceneManager.sceneLoaded += (scene, mode) =>
            {
                Debug.Log($"NewScene: {scene.name}");
                _allUIInScene.Clear();
            };
        }

        public void AddUIInScene(BaseUI baseUI) => _allUIInScene.Add(baseUI);
        public T GetInstanceUI<T>(Type type)
        {
            var baseUIInstance = _allUIInScene.FirstOrDefault(item => item.GetType().GetInterface(type.Name) != null);
            var instance = baseUIInstance.GetComponent<T>();
            return instance;
        }
    }
}
