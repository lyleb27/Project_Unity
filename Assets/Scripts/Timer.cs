using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float tempsÉcoulé = 0.0f;
    public Text texteTemps;

    void Start()
    {
        // Charger le temps écoulé depuis PlayerPrefs
        tempsÉcoulé = 0;

        // Mettre à jour le texte
        UpdateTimeText();
    }

    void Update()
    {
        tempsÉcoulé += Time.deltaTime;

        // Enregistrer le temps écoulé dans PlayerPrefs
        PlayerPrefs.SetFloat("TempsÉcoulé", tempsÉcoulé);
        PlayerPrefs.Save();

        // Mettre à jour le texte
        UpdateTimeText();
    }

    void UpdateTimeText()
    {
        texteTemps.text = "Temps écoulé : " + tempsÉcoulé.ToString("F1") + "s";
    }

    public void ResetTime()
    {
        // Réinitialiser le temps à zéro
        tempsÉcoulé = 0.0f;

        // Enregistrer la réinitialisation dans PlayerPrefs
        PlayerPrefs.SetFloat("TempsÉcoulé", tempsÉcoulé);
        PlayerPrefs.Save();

        // Mettre à jour le texte
        UpdateTimeText();
    }
}
