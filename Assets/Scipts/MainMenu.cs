using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject instructionsMenu;

    public void LoadMainMenu()
    {
        PauseManager.ResetGame();
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
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
