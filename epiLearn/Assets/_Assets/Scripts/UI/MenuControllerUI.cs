using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void ChangeScene(string _sceneName)
       {
        GameManager.Instance.ChangeScene(_sceneName);
       }
}
