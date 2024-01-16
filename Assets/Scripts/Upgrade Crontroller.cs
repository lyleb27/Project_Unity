using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeController : MonoBehaviour
{
    public float speed = 50f;
    public float followDistance = 0.5f;
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
            followDistance = 2f;
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Finish")
        {
            Destroy(collision.gameObject);
        }
    }
}
