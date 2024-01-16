using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject TrapPrefab;
    public GameObject CoinPrefab;
    public GameObject MobPrefab;
    public GameObject UpgradePrefab;

    public Vector2[] trapCoords = new Vector2[] { new Vector2(8, -3), new Vector2(8, 3), new Vector2(-8, -3), new Vector2(-8, 3) };
    public Vector2[] coinCoords = new Vector2[] { new Vector2(9, -4), new Vector2(9, 4), new Vector2(-9, -4), new Vector2(-9, 4) };
    public Vector2[] mobCoords = new Vector2[] { new Vector2(3, 2.5f), new Vector2(3, -2.5f), new Vector2(-3, 2.5f), new Vector2(-3, -2.5f) };
    public Vector2[] upgradeCoords = new Vector2[] { new Vector2(8, 4), new Vector2(-8, -4) };

    void Start()
    {
        SpawnItems(TrapPrefab, trapCoords);
        SpawnItems(CoinPrefab, coinCoords);
        SpawnItems(MobPrefab, mobCoords);
        SpawnItems(UpgradePrefab, upgradeCoords);
    }

    void SpawnItems(GameObject prefab, Vector2[] coords)
    {
        foreach (Vector2 coord in coords)
        {
            Instantiate(prefab, coord, Quaternion.identity);
        }
    }
}