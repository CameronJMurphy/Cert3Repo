using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController cc;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
		for (int i = 0; i < 10; i++)
		{
            Debug.Log("Looping");
		}
	}

    // Update is called once per frame
    void Update()
    {
        cc.Move(Input.GetAxis("Vertical") * transform.forward * Time.deltaTime * speed); //forward and back movement
        cc.Move(Input.GetAxis("Horizontal") * transform.right * Time.deltaTime * speed); //Left and right

        if(Input.GetKeyDown(KeyCode.G))
        {
            ThrowBomb(Random.Range(1,1000));
        }
    }

    void ThrowBomb(float radius)
    {
        Debug.Log($"Thew bomb it exploded in a radius of {radius} meters");
    }
}
