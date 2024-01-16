using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public GameObject fireballPrefab; // Ajoutez une référence à votre préfab "fireball"

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        if (transform.position.x < -9f)
        {
            transform.position = new Vector2(-9f, transform.position.y);
        }
        if (transform.position.x > 9f)
        {
            transform.position = new Vector2(9f, transform.position.y);
        }

        if (transform.position.y < -4.7f)
        {
            transform.position = new Vector2(transform.position.x, -4.7f);
        }
        if (transform.position.y > 4.7f)
        {
            transform.position = new Vector2(transform.position.x, 4.7f);
        }
        Vector2 movement = new Vector2(moveX, moveY) * speed * Time.deltaTime;
        transform.Translate(movement);

        // Si le joueur appuie sur la touche "Fire1" (généralement le clic gauche de la souris ou Ctrl gauche), instanciez la "fireball"
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnFireball(movement);
        }
    }

    void SpawnFireball(Vector2 direction)
    {
        // Instanciez la "fireball" à la position du joueur
        GameObject fireball = Instantiate(fireballPrefab, transform.position, Quaternion.identity);

        // Ajoutez votre logique pour déplacer la "fireball" dans la même direction que le joueur
        // Par exemple, si votre "fireball" a un script avec une fonction "Launch(Vector2 direction)", vous pouvez l'appeler ici
        fireball.GetComponent<Fireball>().Launch(direction);
    }
}