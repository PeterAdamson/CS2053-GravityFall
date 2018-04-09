using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Text endText;
    public AudioClip hit;
    AudioSource audioSource;
	bool restart;

	// Use this for initialization
	void Start () {
		restart = false;
		endText.text = "";
        audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.L))
		{
			Time.timeScale = 1;
			SceneManager.LoadScene( SceneManager.GetActiveScene().name );
		}

        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                restart = false;
                Time.timeScale = 1;
                SceneManager.LoadScene("Opening");
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
	}

	public void GameOver ()
	{
        audioSource.PlayOneShot(hit, 1f);
        endText.text = "You Lose! Push 'L' to Restart.";
		Time.timeScale = 0;
	}

	public void win ()
	{
        restart = true;
        endText.text = "You Win! Push 'K' to restart game.";
		Time.timeScale = 0;
	}
}
