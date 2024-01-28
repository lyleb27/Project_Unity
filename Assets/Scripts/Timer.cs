using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float tempsÉcoulé = 0.0f;
    public Text texteTemps;

    void Start()
    {
        tempsÉcoulé = 0;

        UpdateTimeText();
    }

    void Update()
    {
        tempsÉcoulé += Time.deltaTime;

        PlayerPrefs.SetFloat("TempsÉcoulé", tempsÉcoulé);
        PlayerPrefs.Save();

        UpdateTimeText();
    }

    void UpdateTimeText()
    {
        texteTemps.text = "Temps écoulé : " + tempsÉcoulé.ToString("F1") + "s";
    }

    public void ResetTime()
    {
        tempsÉcoulé = 0.0f;

        PlayerPrefs.SetFloat("TempsÉcoulé", tempsÉcoulé);
        PlayerPrefs.Save();

        UpdateTimeText();
    }
}
