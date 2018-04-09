using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float min=2f;
	public float max=3f;
	public GameController gameController;

	// Use this for initialization
	void Start () {
		min=transform.position.x;
    max=transform.position.x + 3;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.PingPong(Time.time * 2,max - min) + min, transform.position.y, transform.position.z);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player"){
			Destroy(other.gameObject);
			gameController.GameOver();
		}
	}
}
