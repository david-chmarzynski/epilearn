using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private GameManager manager;

    private void Start()
    {
        manager = GameManager.Instance;
    }
    public void ChangeScene(string _sceneName)
       {
        manager.ChangeScene(_sceneName);
       }

      public void Quit()
       {
        manager.Quit();
       }
}
