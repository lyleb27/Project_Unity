using UnityEngine;
using UnityEngine.UI;

public class CoinManagerMenu : MonoBehaviour
{
    public Text menuCoinCountText;

    void Start()
    {
        // Récupérer le nombre de pièces depuis PlayerPrefs
        int coinCount = PlayerPrefs.GetInt("CoinCount", 0);

        // Mettre à jour le texte
        menuCoinCountText.text = "Pièces ramassées : " + coinCount.ToString();
    }
}
