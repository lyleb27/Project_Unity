using UnityEngine;
using UnityEngine.UI;

public class MobManager : MonoBehaviour
{
    private int monstersKilled = 0;
    public Text monstersKilledText;

    void Start()
    {
        monstersKilled = 0;
        UpdateMonsterCounterText();
    }

    public void IncrementMonsterCounter()
    {
        monstersKilled++;
        UpdateMonsterCounterText();
    }

    void UpdateMonsterCounterText()
    {
        monstersKilledText.text = "Monstres tués : " + monstersKilled.ToString();
    }

    public void ResetMonsterCounter()
    {
        monstersKilled = 0;
        UpdateMonsterCounterText();
    }
}