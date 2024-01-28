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

    private GameObject currentCoin;
    private GameObject currentUpgrade;

    void Start()
    {
        SpawnItems(TrapPrefab, trapCoords);
        SpawnItems(MobPrefab, mobCoords);
        SpawnCoin();
        SpawnUpgrade();
    }

    void SpawnItems(GameObject prefab, Vector2[] coords)
    {
        foreach (Vector2 coord in coords)
        {
            Instantiate(prefab, coord, Quaternion.identity);
        }
    }

    void SpawnCoin()
    {
        if (currentCoin != null)
        {
            Destroy(currentCoin);
        }
        Vector2 spawnPos = coinCoords[Random.Range(0, coinCoords.Length)];
        currentCoin = Instantiate(CoinPrefab, spawnPos, Quaternion.identity);
    }

    void SpawnUpgrade()
    {
        if (currentUpgrade != null)
        {
            return;
        }
        Vector2 spawnPos = upgradeCoords[Random.Range(0, upgradeCoords.Length)];
        currentUpgrade = Instantiate(UpgradePrefab, spawnPos, Quaternion.identity);
    }

    public void OnTrapDestroyed(GameObject trap)
    {
        StartCoroutine(RespawnTrap(trap.transform.position));
    }

    IEnumerator RespawnTrap(Vector2 position)
    {
        yield return new WaitForSeconds(10);
        Instantiate(TrapPrefab, position, Quaternion.identity);
    }

    public void OnMobDestroyed(GameObject mob)
    {
        StartCoroutine(RespawnMob(mob.transform.position));
    }

    IEnumerator RespawnMob(Vector2 position)
    {
        yield return new WaitForSeconds(10);
        Instantiate(MobPrefab, position, Quaternion.identity);
    }
}
