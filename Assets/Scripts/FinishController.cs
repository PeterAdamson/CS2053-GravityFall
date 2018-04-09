using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour {

	public GameController gameController;
    AudioSource audioSource;
    public AudioClip finish;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(finish, 1f);
            switch (SceneManager.GetActiveScene().name)
            {
                case "Level 01":
                    SceneManager.LoadScene("Level 02");
                    break;
                case "Level 02":
                    SceneManager.LoadScene("Level 03");
                    break;
                case "Level 03":
                    SceneManager.LoadScene("Level 04");
                    break;
				case "Level 04":
					gameController.win();
					break;
            }
        }
    }
}
