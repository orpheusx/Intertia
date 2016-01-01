using UnityEngine;
using System.Collections;

/*
 * NOTE: the RigidBody2D component we attached to the Player01 object includes a Gravity Scale property that 
 * was causing the sprite to slowly move downwards whenever it was idle. Setting the property to 0 removed that behavior.
 */
public class PlayerMovement : MonoBehaviour {

	Rigidbody2D rbody;
	Animator anim;
    
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> (); 
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 movementVector = new Vector2(
			Input.GetAxisRaw("Horizontal"),
		    Input.GetAxisRaw("Vertical")
			);
		if(movementVector!=Vector2.zero) {
			anim.SetBool("isWalking", true);
			anim.SetFloat("input_x", movementVector.x);
			anim.SetFloat("input_y", movementVector.y);
		} else {
			anim.SetBool("isWalking", false);
		}

        float t = Time.deltaTime;
        //Debug.Log("pos: " + rbody.position + ", mvec: " + movementVector + ", time:" + t );
		rbody.MovePosition(rbody.position + movementVector * t);
	}
}
