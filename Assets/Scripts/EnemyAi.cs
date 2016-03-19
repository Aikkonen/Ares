using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour
{

    public GameObject player;
    private NavMeshAgent agent;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.SetDestination(player.transform.position);
    }
}
