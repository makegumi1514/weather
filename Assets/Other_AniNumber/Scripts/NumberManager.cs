using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberManager : MonoBehaviour {

    public GameObject numbers, canvas;
    private GameObject currentNumbers = null;
    private GameObject nextNumbers = null;
    public Sprite num0, num1, num2, num3, num4, num5, num6, num7, num8, num9;
    private int m, n, o;
    private int time, reloadTime;

    [SerializeField]
    private Image mImg, nImg, oImg;

    // Use this for initialization
    void Start() {
        time = 0;
        reloadTime = 120;
        ChangeImage(mImg, m);
        ChangeImage(nImg, n);
        ChangeImage(oImg, o);

        ReloadNumbers();
    }

    // Update is called once per frame
    void Update() {
        if (time % reloadTime == 0) {
            ReloadNumbers();
        }
        else if((currentNumbers.transform.position.y - canvas.transform.position.y) > 0){
            currentNumbers.transform.Translate(new Vector3(0, -4, 0));
        }
        time++;
    }

    private void ReloadNumbers() {
        m = (int)Random.Range(0, 10);
        n = (int)Random.Range(0, 10);
        o = (int)Random.Range(0, 10);
        ChangeImage(mImg, m);
        ChangeImage(nImg, n);
        ChangeImage(oImg, o);

        if (currentNumbers != null) {
            Destroy(currentNumbers);
            currentNumbers = nextNumbers;
            nextNumbers = (GameObject)Instantiate(numbers, canvas.transform.position + new Vector3(0, 300, 0), Quaternion.identity);
            nextNumbers.transform.SetParent(canvas.transform);
        }
        else {
            currentNumbers = (GameObject)Instantiate(numbers, canvas.transform.position, Quaternion.identity);
            currentNumbers.transform.SetParent(canvas.transform);
            m = (int)Random.Range(0, 10);
            n = (int)Random.Range(0, 10);
            o = (int)Random.Range(0, 10);
            ChangeImage(mImg, m);
            ChangeImage(nImg, n);
            ChangeImage(oImg, o);
            nextNumbers = (GameObject)Instantiate(numbers, canvas.transform.position + new Vector3(0, 300, 0), Quaternion.identity);
            nextNumbers.transform.SetParent(canvas.transform);
        }
    }

    private void ChangeImage(Image img, int num) {
        switch (num) {
            case 0:
                img.sprite = num0;
                break;
            case 1:
                img.sprite = num1;
                break;
            case 2:
                img.sprite = num2;
                break;
            case 3:
                img.sprite = num3;
                break;
            case 4:
                img.sprite = num4;
                break;
            case 5:
                img.sprite = num5;
                break;
            case 6:
                img.sprite = num6;
                break;
            case 7:
                img.sprite = num7;
                break;
            case 8:
                img.sprite = num8;
                break;
            case 9:
                img.sprite = num9;
                break;
            default:
                Debug.Log("error");
                break;
        }
    }
}
