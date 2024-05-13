using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    Vector3 respawnPos;
    bool currentCheckPoint;

    void Start()
    {
        respawnPos = transform.position;    
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
        {
            currentCheckPoint = true;
            Debug.Log("checkpointSet");
        }
	}
}
