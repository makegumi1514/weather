using UnityEngine;
using System.Collections;

public class AnimationEventer : MonoBehaviour {

    private GameObject button;

	// Use this for initialization
	void Start () {
        button = GameObject.Find("Retry");
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void ActiveButton() {
        button.SetActive(true);
    }

    public void NonActiveButton() {
        button.SetActive(false);
    }
}
