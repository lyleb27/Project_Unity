using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    private int coinCount = 0;
    public Text coinCountText;

    void Start()
    {
        coinCount = 0;

        UpdateCoinCountText();
    }

    public void IncrementCoinCount()
    {
        coinCount++;

        PlayerPrefs.SetInt("CoinCount", coinCount);
        PlayerPrefs.Save();

        UpdateCoinCountText();
    }

    void UpdateCoinCountText()
    {
        coinCountText.text = "Pièces ramassées : " + coinCount.ToString();
    }

    public void ResetCoinCount()
    {
        coinCount = 0;

        PlayerPrefs.SetInt("CoinCount", coinCount);
        PlayerPrefs.Save();

        UpdateCoinCountText();
    }
}
