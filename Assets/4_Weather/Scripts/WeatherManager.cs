using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using System.Collections.Generic;
using MiniJSON;

public class WeatherManager : MonoBehaviour {

    private string url = "http://necknecco.co.jp/jsontest/weather.php?id=0";

    public Sprite[] sprites = new Sprite[5];
    public IList<IDictionary> dicList;
    public IList<City> cityList;

    void Start() {
        StartCoroutine("SetWeather");
    }

    IEnumerator SetWeather() {
        WWW www = new WWW(url);
        yield return www;

        if (www.error == null) {
            Debug.Log(www.text);

            string json = www.text;

            // 1層目
            IDictionary jsonData = (IDictionary)Json.Deserialize(json);
            // 2層目
            string country = (string)jsonData["base"];
            IList main = (IList)jsonData["main"];
            // 3層目
            dicList = new List<IDictionary>();
            foreach (IDictionary dic in main) {
                dicList.Add(dic);
            }
            // 4層目
            cityList = new List<City>();
            foreach (IDictionary dic in dicList) {
                City city = new City();
                city.city = (string)dic["city"];
                city.weather = (string)dic["weather"];
                cityList.Add(city);
            }
            Debug.Log("city:" + cityList[0].city + " weather" + cityList[0].weather);

            GameObject japan = GameObject.Find("Japan");
            for (int i = 0; i < japan.transform.childCount; i++) {
                japan.transform.GetChild(i).gameObject.SetActive(true);
            }
            SetIcon();
        }
    }

    public void SetIcon() {
        foreach (City city in cityList) {
            GameObject obj = GameObject.Find(city.city);
            Image objImg = null;
            if (obj != null) {
                objImg = obj.GetComponent<Image>();
            }
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
