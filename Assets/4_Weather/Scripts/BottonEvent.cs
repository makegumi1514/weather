﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using MiniJSON;

public class BottonEvent : MonoBehaviour {

    public WeatherManager manager;

    private IEnumerator ClickCity(int number) {
        string url = "http://necknecco.co.jp/jsontest/weather.php?id=" + number.ToString();
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
            City c = manager.cityList[number - 2];
            c.weather = weather;
            manager.SetIcon();
        }
    }

    public void OnClick(int number) {
        StartCoroutine("ClickCity", number);
    }
}
