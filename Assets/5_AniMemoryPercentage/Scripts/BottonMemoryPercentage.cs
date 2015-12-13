using UnityEngine;
using System.Collections;

using MiniJSON;

public class BottonMemoryPercentage : MonoBehaviour {

    public GameObject low;
    public GameObject middle;
    public GameObject high;
    private GameObject animObj = null;

    // Use this for initialization
    void Start() {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick() {
        int rand = Random.Range(0, 101);
        if (animObj != null) {
            Destroy(animObj);
        }

        if (0 <= rand && rand < 40) {
            animObj = Instantiate(low);
        } else if (rand < 80) {
            animObj = Instantiate(middle);
        } else if (rand <= 100) {
            animObj = Instantiate(high);
        } else {
            Debug.LogError("error");
            return;
        }

        animObj.GetComponent<CountController>().countResult = rand;
        animObj.GetComponent<Animator>().Play("FirstHalf01");
    }

    //public void OnClick() {
    //    StartCoroutine(CreateAnimObjByJson());
    //}

    //private IEnumerator CreateAnimObjByJson() {
    //    string url = "http://xxxx";
    //    WWW www = new WWW(url);
    //    yield return www;

    //    if (www.error == null) {
    //        IDictionary jsonData = (IDictionary)Json.Deserialize(www.text);

    //        int memPer = (int)((long)jsonData["xxx"]);

    //        CreateObj(memPer);

    //        animObj.GetComponent<CountController>().countResult = memPer;
    //        animObj.GetComponent<Animator>().Play("FirstHalf01");
    //    }
    //}

    //private void CreateObj(int memPer) {
    //    if(animObj != null) {
    //        Destroy(animObj);
    //    }
    //
    //    if (0 <= memPer && memPer < 40) {
    //        animObj = Instantiate(low);
    //    }
    //    else if (memPer < 80) {
    //        animObj = Instantiate(middle);
    //    }
    //    else if (memPer <= 100) {
    //        animObj = Instantiate(high);
    //    }
    //    else {
    //        Debug.LogError("error");
    //        return;
    //    }
    //}
}
