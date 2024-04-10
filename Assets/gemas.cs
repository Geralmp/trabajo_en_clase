using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gema : MonoBehaviour
{
    public static int gemaCount = 0;

    private void Start()
    {
        gemaCount = gemaCount + 1;
        Debug.Log("Empieza el juego. " + gemaCount + " gemas"); 
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player"))
        {
            gemaCount--; // Disminuir la cantidad de gemas
            Debug.Log("Recogida de gemas. " + gemaCount + " gemas");

            if(gemaCount == 0)
            {
                Debug.Log("No hay más gemas");
            }

            Destroy(gameObject);
        }
    }
}