using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private Transform pauseMenuMaster;
    private bool isPaused;

    void Start()
    {
        isPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            Time.timeScale = 0f;
            pauseMenuMaster.gameObject.SetActive(true);
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            Time.timeScale = 1f;
            pauseMenuMaster.gameObject.SetActive(false);
            isPaused = false;
        }
    }

    public void resumeButton()
    {
        Time.timeScale = 1f;
        pauseMenuMaster.gameObject.SetActive(false);
    }

    public void resetTimeScale()
    {
        Time.timeScale = 1f;
    }
}
