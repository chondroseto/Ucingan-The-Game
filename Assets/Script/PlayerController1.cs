using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
	public float moveSpeed;
	float down = 0;
	float up = 0;
	float l = 0,r=0;
	
	public KeyCode left;
	public KeyCode right;
	public KeyCode top;
	public KeyCode bottom;
	
	private Rigidbody2D theRB;
	
	private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(left))
		{
			theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);
			down = 0;
			up = 0;
			l = 1;
			r = 0;
		}else if(Input.GetKey(right))
		{
			theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);
			l = 0;
			r = 1;
			down = 0;
			up = 0;
		}else if(Input.GetKey(top))
		{
			theRB.velocity = new Vector2(theRB.velocity.x,moveSpeed);
			up = 1;
			down = 0;
			l = 0;
			r = 0;
		}else if(Input.GetKey(bottom))
		{
			theRB.velocity = new Vector2(theRB.velocity.x,-moveSpeed);
			down = 1;
			up = 0;
			l = 0;
			r = 0;
		}else {
			theRB.velocity = new Vector2(0, 0);
			down = 0;
			up = 0;
			l = 0;
			r = 0;
		}
		anim.SetFloat("up",up);
		anim.SetFloat("down",down);
		anim.SetFloat("left",l);
		anim.SetFloat("right",r);
    }
}
