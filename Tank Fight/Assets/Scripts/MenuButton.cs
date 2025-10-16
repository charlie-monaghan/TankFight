using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public void StartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
