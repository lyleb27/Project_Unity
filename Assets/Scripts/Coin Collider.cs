using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Détruire l'objet
            Destroy(gameObject);

            // Appeler la méthode IncrementCoinCount du script CoinManager
            CoinManager coinManager = FindObjectOfType<CoinManager>();
            if (coinManager != null)
            {
                coinManager.IncrementCoinCount();
            }
            else
            {
                Debug.LogWarning("CoinManager not found in the scene.");
            }
        }
    }
}
