using UnityEngine;
using UnityEngine.UI;

public class TimerMenuManager : MonoBehaviour
{
    public Text menuTimeText;

    void Start()
    {
        // Récupérer le temps écoulé depuis PlayerPrefs
        float tempsÉcoulé = PlayerPrefs.GetFloat("TempsÉcoulé", 0.0f);

        // Mettre à jour le texte
        menuTimeText.text = "Temps écoulé : " + tempsÉcoulé.ToString("F1") + "s";
    }
}
