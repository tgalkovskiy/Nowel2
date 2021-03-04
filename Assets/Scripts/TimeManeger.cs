using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TimeManeger : MonoBehaviour
{
   [Header("Время на ответ")][SerializeField] private float TimeVariand = default;
   [Header("Слайдер для времени")] [SerializeField] private Slider TimeSlider = default;
   [Header("Станица загрзуки если игрок не успел")] [SerializeField] private GameObject Page_Lose_Time = default;
   [Header("Позиция для новой страницы")] [SerializeField] private Transform Start = default;
   [Header("Позиция для старой страницы")] [SerializeField] private Transform Finish = default;
    private float TimeG=0;
    private void Awake()
    {
        TimeG = TimeVariand;
    }
    private void OnDisable()
    {
        TimeG = TimeVariand;
    }
    private void OnValidate()
    {
        if (TimeG < 0)
        {
            TimeG = 0;
        }
        TimeSlider.maxValue = TimeVariand;
    }

    private void Update()
    {
        if (TimeG > 0)
        {
            StartCoroutine(MinusTime());
        }
    }
    IEnumerator MinusTime()
    {
        yield return new WaitForSeconds(1f);
        TimeG -= Time.deltaTime;
        TimeSlider.value = TimeG;
        if (TimeG <= 0)
            {
                Page_Lose_Time.SetActive(true);
                Page_Lose_Time.transform.DOMove(Start.transform.position, 1f);
                this.gameObject.SetActive(false);
                this.transform.DOMove(Finish.transform.position, 1f);
            }
    }
}
