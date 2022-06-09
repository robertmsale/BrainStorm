using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectHeart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
        {
        if (other.CompareTag("Player")) 
            {
            other.GetComponent<Player>().currentHealth += 50;
            
            Destroy(gameObject);
            }
        }
}
