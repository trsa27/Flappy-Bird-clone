using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;
using NDream.AirConsole;
public class Player : MonoBehaviour {

	public PipeObjectFactory pipeFactRef;

	Rigidbody rb;
	public int Score;
	Vector3 JumpVector;
	AirConsole airConsole;
	AudioSource[] AudioList;

	public int timesPressed;
	Dictionary<string, AudioSource> audioDictionary;
	// Use this for initialization
	void Start () {
		airConsole = new AirConsole();
		Score = 0;
		timesPressed = 0;
		AirConsole.instance.onMessage += OnMessage;
		JumpVector = new Vector3(0,8,0);
		gameObject.AddComponent<Rigidbody>();
		rb = gameObject.GetComponent<Rigidbody>();
		//rb.velocity = JumpVector;
		InitAudioDictionary();
		rb.useGravity = false;
		pipeFactRef = GameObject.Find("PipeFactory").GetComponent<PipeObjectFactory>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space))
		{
			Jump();
		}
	}
	void OnMessage(int from, JToken data) {
	
		if((bool)data["Jump"] == true)
		{
			Jump();
			timesPressed++;

		}

	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "Pipe")
		{
			Score++;
			
		}
	}

	void OnPlayerDeath()
	{

	}
	void InitAudioDictionary()
	{
		
	}
	void Jump()
	{
		if(rb.useGravity == false)
		{
			rb.useGravity = true;
			pipeFactRef.isSpawning = 1;
		} 
		rb.velocity = JumpVector;
		gameObject.GetComponent<AudioSource>().Play();
	}


}
