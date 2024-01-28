using UnityEngine;
using UnityEngine.UI;

public class CoinMenuManager : MonoBehaviour
{
    public Text menuCoinCountText;

    void Start()
    {
        int coinCount = PlayerPrefs.GetInt("CoinCount", 0);

        menuCoinCountText.text = "Pièces ramassées : " + coinCount.ToString();
    }
}
