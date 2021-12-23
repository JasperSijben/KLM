using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlaneAI : MonoBehaviour
{
    public GameObject area;
    public NavMeshAgent agent;

    public bool isParked;

    public int number = 0;

    private bool isAtStart = false;
    private Vector3 startPos;

    void Start()
    {
        startPos = new Vector3(agent.transform.position.x, agent.transform.position.y, 3);
        agent.SetDestination(startPos);
    }

    void Update()
    {
        float currentPos = agent.transform.position.z;
        if (agent.velocity == Vector3.zero && isAtStart && !isParked)
        {
            Vector2 newRandomPos2 = ChooseRandomPoint();
            Vector3 newPos3 = new Vector3(newRandomPos2.x, agent.transform.position.y, newRandomPos2.y);
            agent.SetDestination(newPos3);
        }
        else if (currentPos == startPos.z)
        {
            isAtStart = true;
        }
    }

    private Vector2 ChooseRandomPoint()
    {
        float minX = area.transform.position.x + area.transform.localScale.x / -2;
        float maxX = area.transform.position.x + area.transform.localScale.x / 2;
        float minZ = area.transform.position.z + area.transform.localScale.z / -2;
        float maxZ = area.transform.position.z + area.transform.localScale.z / 2;

        Vector2 randomPoint = new Vector2(Random.Range(minX, maxX), Random.Range(minZ, maxZ));

        return randomPoint;
    }
}
