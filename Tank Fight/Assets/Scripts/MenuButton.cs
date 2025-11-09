using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private string sceneName;
    private PauseManager pauseManager;
    public void StartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        pauseManager.resetTimeScale();
    }

    public void QuitButton()
    {
        pauseManager.resetTimeScale();
        Application.Quit();
    }
}
