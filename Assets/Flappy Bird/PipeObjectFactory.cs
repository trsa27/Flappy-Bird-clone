using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeObjectFactory : MonoBehaviour {


	public GameObject Pipe;

	public GameObject player;
	public float timer;
	public int isSpawning;
	
	public List<GameObject> PipeCloneList;
	float spawnRate;
	// Use this for initialization
	void Start () {
		PipeCloneList = new List<GameObject>();
		Pipe = GameObject.Find("Pipe");
		timer = 0.0f;
		spawnRate = 3.0f;
		isSpawning = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isSpawning != 0)
		{
			timer += Time.deltaTime;
			if(timer > spawnRate)
			{
				ResetTimer();
				SpawnPipe();
				CheckForDespawn();
			}
		}
		
	}

	void SpawnPipe()
	{
		GameObject movingPipe = GameObject.Instantiate(Pipe);
		movingPipe.AddComponent<MovingPipeLogic>();
		movingPipe.transform.position = new Vector3(movingPipe.transform.position.x,GetPipeHeight(),movingPipe.transform.position.z);
		PipeCloneList.Add(movingPipe);
		print(PipeCloneList.Count);
		
	}
	void ResetTimer()
	{
		timer = 0f;
	}
	void CheckForDespawn()
	{
		if(PipeCloneList[0] == null)
		{
			PipeCloneList.RemoveAt(0);
			print("Despawned" + PipeCloneList[0]);
		}
	}
	float GetPipeHeight()
	{
		return 50 + Random.Range(0f,10f);
	}
	
	
	
	
}

