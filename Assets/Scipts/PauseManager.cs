using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public static bool paused = false;
    public GameObject instructionsMenu;
    public GameObject menu;
    PauseAction action;

    private void Awake()
    {
        action = new PauseAction();
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void Start()
    {
        action.Pause.PauseGame.performed += ctx => DeterminedPause();
    }

    private void DeterminedPause()
    {
        if (paused)
        {
            ResumeGame();
        }
        else
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        paused = true;
        menu.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        paused = false;
        menu.SetActive(false);
    }

    public static void ResetGame()
    {
        Time.timeScale = 1f;
        paused = false;
    }

    public void OpenInstructions()
    {
        menu.SetActive(false);
        instructionsMenu.SetActive(true);
    }

    public void CloseInstructions()
    {
        instructionsMenu.SetActive(false);
        menu.SetActive(true);
    }
}
