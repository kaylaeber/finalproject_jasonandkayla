using UnityEngine;
using System.Collections;

public class BannerBehaviour : MonoBehaviour {

	public GameObject gameManager;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	

		if(gameManager.GetComponent<GameManager>().hasPopped == true){
			Animator animator;
			animator = GetComponent<Animator>();
			animator.SetBool ("BubblePopped", true);
		}
	}
}