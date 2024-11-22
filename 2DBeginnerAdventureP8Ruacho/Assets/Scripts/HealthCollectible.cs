using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;
    void OnTriggerEnter2D(Collider2D other)
    {
        DuckController controller = other.GetComponent<DuckController>();
        if(controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);

            controller.PlaySound(collectedClip);
        }
    }
}
