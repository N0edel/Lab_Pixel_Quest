using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public string startsScene;
    public void Loadlevel()
    {
        SceneManager.LoadScene(startsScene);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        {
            Application.Quit();
        }
    }
}
