using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;
    public bool ischecks = true;
    // Start is called before the first frame update
    void Start()
    {
        targetPoint = 0;
          StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if ( ischecks == true)
        {
            
              transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
              
        }
    }
    
    IEnumerator ExampleCoroutine()
        {
            yield return new WaitForSeconds(3);
            targetPoint++;
            yield return new WaitForSeconds(2);
            targetPoint++;
            yield return new WaitForSeconds(2);
            targetPoint++;
           ischecks = false;
        }
 
}

