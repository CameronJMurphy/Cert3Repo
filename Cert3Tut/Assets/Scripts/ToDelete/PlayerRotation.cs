using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] float xRotSpeed;
	[SerializeField] float yRotSpeed;
	[SerializeField] Transform cameraPos;

    float xRotation;
    float yRotation;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update()
    {
        var verInput = Input.GetAxis("Mouse Y");
		var horInput = Input.GetAxis("Mouse X");

        yRotation += horInput * xRotSpeed * Time.deltaTime;

		xRotation -= verInput * yRotSpeed * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);

		cameraPos.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        transform.rotation = Quaternion.Euler(0, yRotation, 0);
	}
}
