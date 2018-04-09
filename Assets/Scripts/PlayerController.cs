using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	bool grav = true;
	public float gravitySpeed;
	public Vector3 direction;
	public float speed;
	public Text storyText;
	Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		storyText.text = "";
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("r") && grav == true){
			rb.gravityScale = -gravitySpeed;
			grav = false;
		}
		else if(Input.GetKeyDown("r") && grav == false){
			rb.gravityScale = gravitySpeed;
			grav = true;
		}


	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis("Horizontal");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

		rb.AddForce(movement * speed);

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Story1"){
			storyText.text = "Welcome to Gravity Fall! use left arrow and right arrow to move left and right";
		}
		if(other.gameObject.tag == "Story2"){
			storyText.text = "Evil red Robots have attacked your peaceful homeworld of indifferent green robots";
		}
		if(other.gameObject.tag == "Story3"){
			storyText.text = "They have used their disruption cannon to disrupt the space time continuum";
		}
		if(other.gameObject.tag == "Story4"){
			storyText.text = "press r to reverse the current direction of gravity";
		}
		if(other.gameObject.tag == "Story5"){
			storyText.text = "However, something went wrong with their attack this time!";
		}
		if(other.gameObject.tag == "Story6"){
			storyText.text = "They have accidentally transported you to their ex machina obstacle course";
		}
		if(other.gameObject.tag == "Story7"){
			storyText.text = "And they have given you the ability to control gravity by accident";
		}
		if(other.gameObject.tag == "Story8"){
			storyText.text = "If you can reach the end of the obstacle course, you will destroy the red robots";
		}
		if(other.gameObject.tag == "Story9"){
			storyText.text = "Avoid the killer spikes that the red robots have placed around the course";
		}
		if(other.gameObject.tag == "Story10"){
			storyText.text = "Avoid the red robots buzzing around the course";
		}
		if(other.gameObject.tag == "Story11"){
			storyText.text = "The obstacle course has some platforms that you can't touch";
		}
		if(other.gameObject.tag == "Story12"){
			storyText.text = "These platforms are red in color";
		}
		if(other.gameObject.tag == "Story13"){
			storyText.text = "Luckily, these platforms are malfunctioning";
		}
		if(other.gameObject.tag == "Story14"){
			storyText.text = "They will periodically switch from red to purple, then purple to red";
		}
		if(other.gameObject.tag == "Story15"){
			storyText.text = "Only touch them when they are purple";
		}
	}

	void OnTriggerExit2D(Collider2D other){
		storyText.text = "";
	}
}
