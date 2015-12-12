using UnityEngine;
using System.Collections;

using UnityEngine.UI;
using System.Collections.Generic;
using MiniJSON;

public class WeatherManager : MonoBehaviour {

    private string url = "http://necknecco.co.jp/jsontest/weather.php?id=0";

    public Image miyagi, tokyo, aichi, osaka, ehime, fukuoka, okinawa;
    public Sprite sun, cloud, rain, snow;

    IEnumerator Start () {
        WWW www = new WWW(url);

        yield return www;

        if (www.error == null) {
            Debug.Log(www.text);

            string json = www.text;

            // 1層目
            Dictionary<string, object> jsonData = (Dictionary<string, object>)Json.Deserialize(json);
            // 2層目
            string country = (string)jsonData["base"];
            IList main = (IList)jsonData["main"];
            // 3層目
            //Dictionary<string, object> main_0 = (Dictionary<string, object>)main[0];
            IDictionary main_0 = (IDictionary)main[0];
            Dictionary<string, object> main_1 = (Dictionary<string, object>)main[1];
            Dictionary<string, object> main_2 = (Dictionary<string, object>)main[2];
            Dictionary<string, object> main_3 = (Dictionary<string, object>)main[3];
            Dictionary<string, object> main_4 = (Dictionary<string, object>)main[4];
            Dictionary<string, object> main_5 = (Dictionary<string, object>)main[5];
            Dictionary<string, object> main_6 = (Dictionary<string, object>)main[6];
            // 4層目
            string city_0 = (string)main_0["city"];
            string weather_0 = (string)main_0["weather"];
            Debug.Log("city:" + city_0 + " weather:" + weather_0);
            string city_1 = (string)main_1["city"];
            string weather_1 = (string)main_1["weather"];
            Debug.Log("city:" + city_1 + " weather:" + weather_1);
            string city_2 = (string)main_2["city"];
            string weather_2 = (string)main_2["weather"];
            Debug.Log("city:" + city_2 + " weather:" + weather_2);
            string city_3 = (string)main_3["city"];
            string weather_3 = (string)main_3["weather"];
            Debug.Log("city:" + city_3+ " weather:" + weather_3);
            string city_4 = (string)main_4["city"];
            string weather_4 = (string)main_4["weather"];
            Debug.Log("city:" + city_4 + " weather:" + weather_4);
            string city_5 = (string)main_5["city"];
            string weather_5 = (string)main_5["weather"];
            Debug.Log("city:" + city_5 + " weather:" + weather_5);
            string city_6 = (string)main_6["city"];
            string weather_6 = (string)main_6["weather"];
            Debug.Log("city:" + city_6 + " weather:" + weather_6);

            SetIcon(miyagi, weather_0);
            SetIcon(tokyo, weather_1);
            SetIcon(aichi, weather_2);
            SetIcon(osaka, weather_3);
            SetIcon(ehime, weather_4);
            SetIcon(fukuoka, weather_5);
            SetIcon(okinawa, weather_6);
        }
    }

    public void SetIcon(Image img, string weather) {
        switch (weather) {
            case "晴":
                img.sprite = sun;
                break;
            case "曇":
                img.sprite = cloud;
                break;
            case "雨":
                img.sprite = rain;
                break;
            case "雪":
                img.sprite = snow;
                break;
            default:
                Debug.Log("error");
                break;
        }
    }
}
