using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("T'as perdu mais flemme de faire le menu");
            SceneManager.LoadScene("Menu");
        }
        Destroy(other.gameObject);
/*        OnTrapDestroyed(gameObject);*/
        Destroy(gameObject);
    }
}