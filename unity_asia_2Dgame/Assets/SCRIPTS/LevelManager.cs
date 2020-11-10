using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void NextLevel(string newLV)
    {
        
        SceneManager.LoadScene(newLV);

    }
    public void BacktoMenu()
    {

        SceneManager.LoadScene("選單");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
