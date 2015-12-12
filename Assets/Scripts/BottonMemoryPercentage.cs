using UnityEngine;
using System.Collections;

public class BottonMemoryPercentage : MonoBehaviour {

    public GameObject low, middle, high;
    private GameObject animObj = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MyOnClick() {
        int rand = Random.Range(0, 101);

        if(animObj != null) Destroy(animObj);

        if (0 <= rand && rand < 40) animObj = Instantiate(low);
        else if (rand < 80) animObj = Instantiate(middle);
        else if (rand <= 100) animObj = Instantiate(high);
        else Debug.Log("error");

        animObj.GetComponent<CountController>().countResult = rand;
        animObj.GetComponent<Animator>().Play(0);
    }
}
