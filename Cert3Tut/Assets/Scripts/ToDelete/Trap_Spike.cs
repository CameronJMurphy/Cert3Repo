using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap_Spike : Trap
{
	[SerializeField] float cooldown;
	float cooldownTimer;
	bool canTrigger = false;

	public Trap_Spike(int dmg, float cooldown) : base(dmg)
	{
		this.cooldown = cooldown;
	}
	private void Update()
	{
		cooldownTimer -= Time.deltaTime;
		if(cooldownTimer <= 0 )
		{
			canTrigger = true;
		}
	}

	public override void Trigger()
	{
		Debug.Log($"Spikes stab player for {damage} damage");
		cooldownTimer = cooldown;
		canTrigger = false;
	}


	private void OnTriggerEnter(Collider other)
	{ 
		if(other.tag == "Player")
		{
			if(canTrigger)
			{
				Trigger();
			}
			else
			{
				Debug.Log($"Trap is still on cooldown for another {cooldownTimer} seconds");
			}

		}
	}

}
