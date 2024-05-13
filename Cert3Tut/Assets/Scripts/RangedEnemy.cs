using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : Enemy
{
    [SerializeField] float range;

	Transform target;
	private void Awake()
	{
		target = FindObjectOfType<PlayerMovement>().transform;
	}

    void Update()
    {
		MyUpdate();
        if(Vector3.Distance(target.position, transform.position) <= range)
		{
			agent.isStopped = true;
			Attack();
		}
		else
		{
			agent.isStopped = false;
			agent.SetDestination(target.position);
		}
    }

	public override void Attack()
	{
		Debug.Log("Firing Projectile");

	}
}
