using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("OnHead"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("DeathTrigger"))
        {
            Destroy(other.transform.parent.gameObject);
        }
    }
}
