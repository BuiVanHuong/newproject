using UnityEngine;
using System.Collections;

public class SheepController : MonoBehaviour {

    Vector3 mousePos;
    public float moveSpeed = 10;
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -10;
    public float maxY = 10;
	// Use this for initialization
	void Start () {
        mousePos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), 0);
        }
        transform.position = Vector3.Lerp(transform.position, mousePos, moveSpeed * Time.deltaTime);
    }
}
