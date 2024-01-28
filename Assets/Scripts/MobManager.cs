using UnityEngine;
using UnityEngine.UI;

public class MobManager : MonoBehaviour
{
    private int mobCount = 0;
    public Text mobCountText;

    void Start()
    {
        mobCountText.text = "Ennemis tués : ";
    }

    public void IncrementMobCount()
    {
        mobCount++;
        mobCountText.text = "Ennemis tués : " + mobCount.ToString();
    }
}
