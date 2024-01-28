using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    private int coinCount = 0;
    public Text coinCountText;

    void Start()
    {
        // Charger le nombre de pièces collectées depuis PlayerPrefs
        coinCount = 0;

        // Mettre à jour le texte
        UpdateCoinCountText();
    }

    public void IncrementCoinCount()
    {
        coinCount++;

        // Enregistrer le nouveau nombre de pièces dans PlayerPrefs
        PlayerPrefs.SetInt("CoinCount", coinCount);
        PlayerPrefs.Save();

        // Mettre à jour le texte
        UpdateCoinCountText();
    }

    void UpdateCoinCountText()
    {
        coinCountText.text = "Pièces ramassées : " + coinCount.ToString();
    }

    public void ResetCoinCount()
    {
        // Réinitialiser le nombre de pièces à zéro
        coinCount = 0;

        // Enregistrer la réinitialisation dans PlayerPrefs
        PlayerPrefs.SetInt("CoinCount", coinCount);
        PlayerPrefs.Save();

        // Mettre à jour le texte
        UpdateCoinCountText();
    }
}
