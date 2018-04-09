﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour {

	public GameController gameController;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
						gameController.GameOver();
        }
    }
}
