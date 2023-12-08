using UnityEngine;

public class MenuControllerUI : MonoBehaviour
{
    public void ChangeScene(string _sceneName)
    {
        GameManager.Instance.DestroyScene();
        GameManager.Instance.ChangeScene(_sceneName);
    }
}
