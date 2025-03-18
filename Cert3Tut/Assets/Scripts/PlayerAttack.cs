using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] BoxCollider attackZone;
    [SerializeField] LayerMask mask;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        Debug.Log("Player attack");

        Collider[] hitObjs = Physics.OverlapBox(attackZone.transform.position, attackZone.bounds.extents, attackZone.transform.rotation, mask);

        foreach (Collider col in hitObjs)
        {
            Enemy e = col.GetComponent<Enemy>();
            if(e != null)
            {
                e.Hurt(damage);
            }
        }

    }
}
