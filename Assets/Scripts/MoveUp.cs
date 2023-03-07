using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public Transform[] patrolPoints1;
    public int targetPoint1;
    public float speed1;
    // Start is called before the first frame update
    void Start()
    {
        targetPoint1 = 0;
         
    }

    // Update is called once per frame
    void Update()
    {
         StartCoroutine(ExampleCoroutine());
       IEnumerator ExampleCoroutine()
       {
        yield return new WaitForSeconds(7);
        if(transform.position == patrolPoints1[targetPoint1].position )
        {
          
       increaseTargetInt();
             
        }
              transform.position = Vector3.MoveTowards(transform.position, patrolPoints1[targetPoint1].position, speed1 * Time.deltaTime);
       }
    }
        void increaseTargetInt()
    {
       targetPoint1++;
       if(targetPoint1>= patrolPoints1.Length)
       {
        targetPoint1 = 0;
       }
       
    }
     
}

