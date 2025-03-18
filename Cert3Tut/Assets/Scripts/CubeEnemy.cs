using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnemy : Enemy
{
	Transform target;
	private void Awake()
	{
		target = FindObjectOfType<PlayerMovement>().transform;
	}
	private void Update()
	{
		MyUpdate();
		agent.SetDestination(target.position);
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Attack();
		}
	}
}
