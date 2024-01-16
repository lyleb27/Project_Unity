using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fireball : MonoBehaviour
{
    public float speed = 10f;

    public void Launch(Vector2 direction)
    {
        GetComponent<Rigidbody>().velocity = direction * speed;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (string.IsNullOrEmpty(collision.gameObject.tag))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        Destroy(gameObject);
    }

    void Update()
    {
        if (transform.position.x < -9f || transform.position.x > 9f)
        {
            Debug.Log("Perdu mon reuf");
        }
        if (transform.position.y < -4.7f || transform.position.y > 4.7f)
        {
            Debug.Log("Perdu mon reuf");
        }
    }
}