using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject head = null;
    private GameObject xrrig = null;
    private float movementSpeed = .5f;
    void Start()
    {
      //  xrrig = GameObject.Find("XRRig");
      //  head = xrrig.cameraGameObject;
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        float horizontalMovement = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)[0];
        float verticalMovement = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick)[1];
        //Vector3 movement = new Vector3(horizontalMovement, 0.0f, verticalMovement);
        Vector3 forward = Camera.main.transform.forward;
        forward = forward.normalized;
        Vector3 right = Camera.main.transform.right;
        Vector3 movement = (horizontalMovement*right + verticalMovement*forward);
        movement = new Vector3(movement.x*movementSpeed, 0.0f, movement.z*movementSpeed);
        transform.position += movement;
        if(OVRInput.Get(OVRInput.Button.One))
  			{
  					Debug.Log("Jump!");
  				//	OVRPlayerController.Jump();
          //  head.GetComponent<Rigid
            StartCoroutine("Jump");

  			}

    }
    IEnumerator Jump()
    {
      for(int i=0; i < 100; i++)
      {
          transform.position += new Vector3(0.0f, 0.02f, 0.0f);
          yield return new WaitForSeconds(0.01f);

      }
      for(int i=0; i < 100; i++)
      {
          transform.position -= new Vector3(0.0f, 0.02f, 0.0f);
          yield return new WaitForSeconds(0.01f);

      }
    }
}
