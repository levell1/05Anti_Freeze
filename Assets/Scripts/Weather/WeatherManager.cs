using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeatherManager : MonoBehaviour
{
    ChageWeatherImage chageWeatherImage;
    public Sprite[] icons;
    public float WeatherStatus;
    public float Temperature;
    private void TodayWeather()
    {
        WeatherStatus = Random.Range(0, 3);
        ///0�̸� ����
        ///1�̸� �긲
        ///2�̸� ������
    }
    private void TodayTemperature()
    {
        Temperature = Random.Range(-10f, 10f);
    }

    
    void Start()
    {
        StartCoroutine(ChangeWeather());
    }
    void FixedUpdate()
    {
            
    }
    IEnumerator ChangeWeather()
    {
        TodayWeather();
        TodayTemperature();
        Debug.Log("������ �ٲ�����ϴ�.");
        yield return new WaitForSecondsRealtime(1f);
        ChangeWeather();
    }

}
