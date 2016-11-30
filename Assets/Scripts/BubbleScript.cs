using UnityEngine;
using System.Collections;

public class BubbleScript : MonoBehaviour {

	private GameObject gameManager;

	public Sprite BubbleUnpopped, BubblePopped;
	private SpriteRenderer spriteRender;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("GameManager");
		spriteRender = gameObject.GetComponent<SpriteRenderer>();
		AudioSource audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(isTouched()) {
			spriteRender.sprite = BubblePopped;
			gameManager.GetComponent<GameManager> ().hasPopped = true;
		}
	}
	public bool isTouched() {
		bool result = false;

		if (Input.GetMouseButtonDown (0)) {
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D hitCollider = Physics2D.OverlapPoint (mousePosition);
			GetComponent<AudioSource>().Play();

			if (hitCollider.gameObject == gameObject) {
				result = true;
			}

		}
		return result;

	}
}