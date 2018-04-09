using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    SpriteRenderer renderer;
    BoxCollider2D bc;
    bool isRed = false;
    public GameController gameController;

	// Use this for initialization
	void Start () {

        renderer = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();

        InvokeRepeating("SwitchPlatform", Random.Range(0.0f, 5.0f), 5.0f);
	}

	// Update is called once per frame
	void Update () {

	}

    void SwitchPlatform()
    {
        if (!isRed)
        {
            renderer.color = new Color(1f, 0f, 0f, 1f);
            bc.isTrigger = true;
            isRed = true;
        }
        else
        {
            renderer.color = new Color(0.4f, 0.4f, 0.6f, 1f);
            bc.isTrigger = false;
            isRed = false;
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && isRed)
        {
            Destroy(other.gameObject);
            gameController.GameOver();
        }
    }
}
