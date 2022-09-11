using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPipeLogic : MonoBehaviour {

	float speed;

	// Use this for initialization
	void Start () {
	 speed = 7.0f;
	}
	
	// Update is called once per frame
	void Update () {
		MovePipe();
		destroyPipe();
	}
	void MovePipe()
	{
		this.transform.Translate(-1 *speed* Time.deltaTime,0,0);
	}
	void destroyPipe()
	{
		if(gameObject.transform.position.x > 25)
		{
			
			GameObject.Destroy(gameObject);
		}
		
	}
}
