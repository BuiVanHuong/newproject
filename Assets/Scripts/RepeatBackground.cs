using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour

{
  //Initialize variables
public float speed;
public int background_count;
public float background_height;
	
// Update is called once per frame
void Update () {
	//Move down
	transform.Translate (Vector3.down *  speed  * Time.deltaTime);
		
	Vector3 pos = transform.position;
	if (pos.y < -background_height) {
		pos.y += background_height * background_count;
		transform.position = pos;
	}
}
   
}
