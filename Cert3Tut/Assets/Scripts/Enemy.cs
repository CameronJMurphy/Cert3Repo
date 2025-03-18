using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected int damage;
    [SerializeField] protected int health;
    protected NavMeshAgent agent;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
	}

	protected void MyUpdate()
	{
		//agent.speed += Time.deltaTime * 2f;
	}

	public bool Hurt(int damage)
    {
        health -= damage;
        Debug.Log($"Ouch my Health is now {health}");
        if(health <= 0)
        {
            Die();
        }
        return health <= 0;
    }

    private void Die()
    {
        Destroy(gameObject);
    }

    public virtual void Attack()
    {
        Debug.Log("Attack");
    }
}
