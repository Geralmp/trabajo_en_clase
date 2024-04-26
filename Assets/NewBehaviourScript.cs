using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    NavMeshAgent myNavMeshAgent;
    public GameObject jugador;

    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();
        // myNavMeshAgent.enabled = true; // No es necesario habilitar ya que se activa por defecto
    }

    void FixedUpdate()
    {
        if (myNavMeshAgent.enabled)
        {
            myNavMeshAgent.SetDestination(jugador.transform.position);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myNavMeshAgent.enabled = true;
        }
    }
}
