using UnityEngine;

public class Trap : MonoBehaviour
{
	[SerializeField] protected int damage;

	public Trap(int damage)
	{
		this.damage = damage;
	}

	public virtual void Trigger()
	{
		Debug.Log("Trigger");
	}
}
