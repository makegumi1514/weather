using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using System.Collections.Generic;
using MiniJSON;

public class WeatherManager : MonoBehaviour {

    private const string url = "http://necknecco.co.jp/jsontest/weather.php?id=0";

    [SerializeField]
    private Sprite[] sprites = new Sprite[5];

    void Start() {
        StartCoroutine(SetWeather());
    }

    IEnumerator SetWeather() {
        WWW www = new WWW(url);
        yield return www;

        if (www.error == null) {
            Debug.Log(www.text);

            // 初期化処理
            GameObject japan = GameObject.Find("Japan");
            for (int i = 0; i < japan.transform.childCount; i++) {
                japan.transform.GetChild(i).gameObject.SetActive(true);
            }

            string json = www.text;

            // 1層目
            IDictionary jsonData = (IDictionary)Json.Deserialize(json);
            // 2層目
            string country = (string)jsonData["base"];
            IList main = (IList)jsonData["main"];
            // 3層目
            IList<IDictionary> dictList = new List<IDictionary>();
            foreach (IDictionary dict in main) {
                dictList.Add(dict);
            }
            // 4層目
            foreach (IDictionary dict in dictList) {
                City city = new City();
                city.city = (string)dict["city"];
                city.weather = (string)dict["weather"];
                SetIcon(city);
                Debug.Log("city:" + city.city + " weather" + city.weather);
            }
        }
    }

    public void SetIcon(City city) {
        GameObject obj = GameObject.Find(city.city);
        Image objImg = null;
        if (obj != null) {
            objImg = obj.GetComponent<Image>();
            switch (city.weather) {
                case "晴":
                    objImg.sprite = sprites[0];
                    break;
                case "曇":
                    objImg.sprite = sprites[1];
                    break;
                case "雨":
                    objImg.sprite = sprites[2];
                    break;
                case "雷":
                    objImg.sprite = sprites[3];
                    break;
                case "雪":
                    objImg.sprite = sprites[4];
                    break;
                default:
                    Debug.LogError("error");
                    break;
            }
        }
    }
}
