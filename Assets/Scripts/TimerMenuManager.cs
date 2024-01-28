using UnityEngine;
using UnityEngine.UI;

public class TimerMenuManager : MonoBehaviour
{
    public Text menuTimeText;

    void Start()
    {
        float tempsÉcoulé = PlayerPrefs.GetFloat("TempsÉcoulé", 0.0f);

        menuTimeText.text = "Temps écoulé : " + tempsÉcoulé.ToString("F1") + "s";
    }
}
