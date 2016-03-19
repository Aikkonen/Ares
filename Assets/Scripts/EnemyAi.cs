using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour
{

    public GameObject player;
    private NavMeshAgent agent;
    public float enemyFieldOfView = 120;
    public float enemyViewDistance = 40;
    public float enemyCloseAwake = 5;


    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);
        Vector3 vectorFromEnemyToPlayer = player.transform.position - transform.position;
        float angleToPlayer = Vector3.Angle(vectorFromEnemyToPlayer, transform.forward);

        if(dist< enemyCloseAwake)
        {
			RaycastHit hit;
			if (Physics.Raycast(transform.position, vectorFromEnemyToPlayer.normalized, out hit, enemyViewDistance))
			{
				if (hit.collider.gameObject == player)
				{
					agent = gameObject.GetComponent<NavMeshAgent>();
					agent.SetDestination(player.transform.position);

				}
			}
            //agent = gameObject.GetComponent<NavMeshAgent>();
            //agent.SetDestination(player.transform.position);
        }

        if (dist < enemyViewDistance && angleToPlayer < enemyFieldOfView * 0.5)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, vectorFromEnemyToPlayer.normalized, out hit, enemyViewDistance))
            {
                if (hit.collider.gameObject == player)
                {
                    agent = gameObject.GetComponent<NavMeshAgent>();
                    agent.SetDestination(player.transform.position);

                }
            }
        }
    }
}


