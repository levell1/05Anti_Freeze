using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeatherManager : MonoBehaviour
{
    ChangeWeatherImage changeWeatherImage;
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
        changeWeatherImage = GetComponent<ChangeWeatherImage>();
        StartCoroutine(ChangeWeather());
    }
    
    IEnumerator ChangeWeather()
    {
        while(true)
        {
            TodayWeather();
            TodayTemperature();
            Debug.Log("������ �ٲ�����ϴ�.");
            yield return new WaitForSeconds(0.01f);
            changeWeatherImage.ChangeIcon();

            yield return new WaitForSeconds(20f);
        }
    }

}
