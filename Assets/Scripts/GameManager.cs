using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public bool hasPopped;
	private float timer = 0;
	public float time = 0;
	public string nextLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= time) {
			Application.LoadLevel(nextLevel);
		}
	}
}
