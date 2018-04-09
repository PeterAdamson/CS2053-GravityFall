using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpeningController : MonoBehaviour {

    public Text text;
    private bool isDisplay = true;

    public AudioClip select;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Blink", 0f, 0.5f);
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
        {
            audioSource.PlayOneShot(select, 1f);
            SceneManager.LoadScene("Level 01");
        }
	}

    void Blink()
    {
        if (isDisplay)
        {
            text.text = "Press any key to start...";
            isDisplay = false;
        }
        else
        {
            text.text = "";
            isDisplay = true;
        }
    }
}
