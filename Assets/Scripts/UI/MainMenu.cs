using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton() => SceneManager.LoadScene("Gameplay");
    public void QuitButton() => Application.Quit();
}
