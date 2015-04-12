using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	public float maxSpeed = 10f;
	bool facingRight = true;
	public bool active = false;
	public float move;
	public bool interaction = false;

	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700;

	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool("Ground", grounded);

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		move = Input.GetAxis ("Horizontal");

		anim.SetFloat("Speed",Mathf.Abs(move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update(){
		if (grounded && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("Ground", false);
			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
		}
	}

	public void OnTriggerEnter2DChild(Collider2D coll) {


		if (coll.gameObject.layer.Equals (10) && interaction == false) {
			Debug.Log ("Holis");
			interaction = true;
		}
	}

	public void OnTriggerExit2DChild(Collider2D coll){

		if(coll.gameObject.layer.Equals (10) && interaction == true)
			interaction = false;
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	public void Dig(){

	}

	public void Recolect(){

	}
}
