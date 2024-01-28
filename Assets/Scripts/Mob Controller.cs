using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobController : MonoBehaviour
{
    public float speed = 4.0f;
    public float followDistance = 5.0f;
    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < followDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Trigger");
        // recupérer le game object qui contient ton script dans ton editeur (quand tu es en jeu)
        // Recupéerer le component (script) qui est contenu dans le game object
        // appeler la méthode du component (script)
/*        OnMobDestroyed(gameObject);
*/        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}