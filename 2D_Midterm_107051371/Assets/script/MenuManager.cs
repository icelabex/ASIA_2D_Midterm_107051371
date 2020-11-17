using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        print("start");

        SceneManager.LoadScene("關卡1");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        print("quit");
        Application.Quit();
    }
}