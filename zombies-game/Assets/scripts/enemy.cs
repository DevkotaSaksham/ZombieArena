using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    private Transform target;
    public Transform looktarget;
    private NavMeshAgent agent;

    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        agent.speed = Random.Range(2, 5);

    }
      void LateUpdate()
      {
          targetPos = target.position;
          thisPos = transform.position;
          targetPos.x = targetPos.x - thisPos.x;
          targetPos.y = targetPos.y - thisPos.y;
          angle = Mathf.Atan2(  targetPos.y, targetPos.x) * Mathf.Rad2Deg;
          transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle -90));
      }


    void Update()
    {

        agent.SetDestination(target.transform.position);
       

    }
}
