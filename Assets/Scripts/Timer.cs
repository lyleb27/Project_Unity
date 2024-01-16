using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float tempsÉcoulé = 0.0f;
    public Text texteTemps;

    void Start()
    {
        texteTemps.text = "Temps écoulé : 0s";
    }

    void Update()
    {
        tempsÉcoulé += Time.deltaTime;

        texteTemps.text = "Temps écoulé : " + tempsÉcoulé.ToString("F1") + "s";
    }
}