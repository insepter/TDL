using Assets.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScencNext : MonoBehaviour
{
    private void Start()
    {
        GetComponentInChildren<UnityEngine.UI.Text>().text = UIManager.Instatnce.name;
    }
    public void Next()
    {
        SceneManager.LoadScene(1);
    }
}
