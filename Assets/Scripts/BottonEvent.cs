using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class BottonEvent : MonoBehaviour {

    public WeatherManager manager;

    public IEnumerator ClickMiyagi() {
        string url = "http://necknecco.co.jp/jsontest/weather.php?id=2";
        WWW www = new WWW(url);
        yield return www;

        if (www.error == null) {
            string json = www.text;
            // 1層目
            Dictionary<string, object> jsonData = (Dictionary<string, object>)Json.Deserialize(json);
            // 2層目
            Dictionary<string, object> main = (Dictionary<string, object>)jsonData["main"];
            // 3層目
            string city = (string)main["city"];
            string weather = (string)main["weather"];
            Debug.Log("city:" + city + " weather:" + weather);
            manager.SetIcon(manager.miyagi, weather);
        }
    }

    public IEnumerator ClickTokyo() {
        string url = "http://necknecco.co.jp/jsontest/weather.php?id=3";
        WWW www = new WWW(url);
        yield return www;

        if (www.error == null) {
            string json = www.text;
            // 1層目
            Dictionary<string, object> jsonData = (Dictionary<string, object>)Json.Deserialize(json);
            // 2層目
            Dictionary<string, object> main = (Dictionary<string, object>)jsonData["main"];
            // 3層目
            string city = (string)main["city"];
            string weather = (string)main["weather"];
            Debug.Log("city:" + city + " weather:" + weather);
            manager.SetIcon(manager.tokyo, weather);
        }
    }

    public void OnClickMiyagi() {
        StartCoroutine("ClickMiyagi");
    }

    public void OnClickTokyo() {
        StartCoroutine("ClickTokyo");
    }

    //-----------以下URLと変更するImage以外同じコード-------------------
}
