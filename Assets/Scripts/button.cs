using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class button : MonoBehaviour {

	Animator animator;
	public GameObject gameManager;

	// Use this for initialization
	void Start () {
		
		animator = GetComponent<Animator>();
		AudioSource audio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		gameManager.GetComponent<GameManager> ().hasPopped = true;

		animator.SetTrigger("Click");
		GetComponent<AudioSource>().Play();
		GetComponent<Animation>().Play();

	}
}
