using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour
{

    public GameObject player;
    private NavMeshAgent agent;
    public bool playerInSight = false;
    public Vector3 playerLastSighted;
    public float enemyFieldOfView = 120;


    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        Vector3 vectorFromEnemyToPlayer = player.transform.position - transform.position;
        Vector3 forward = transform.forward;

        float angleToPlayer = Vector3.Angle(vectorFromEnemyToPlayer, forward);

        if (dist < 10 && angleToPlayer < enemyFieldOfView * 0.5)
        {
            agent = gameObject.GetComponent<NavMeshAgent>();
            agent.SetDestination(player.transform.position);
        }
    }
}

