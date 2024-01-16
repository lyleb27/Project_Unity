using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Button buttonStart;
    public Button buttonExit;

    void Start()
    {
        buttonStart = GameObject.Find("ButtonStart").GetComponent<Button>();
        buttonExit = GameObject.Find("ButtonExit").GetComponent<Button>();

    }


    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
