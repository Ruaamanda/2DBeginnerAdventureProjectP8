using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        DuckController controller = other.GetComponent<DuckController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
