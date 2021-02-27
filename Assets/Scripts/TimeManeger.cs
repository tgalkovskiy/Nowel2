using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TimeManeger : MonoBehaviour
{
   [Header("Время на ответ")][SerializeField] private float TimeVariand = default;
   [Header("Станица загрзуки если игрок не успел")] [SerializeField] private GameObject Page_Lose_Time = default;
   [Header("Позиция для новой страницы")] [SerializeField] private Transform Start = default;
   [Header("Позиция для новой страницы")] [SerializeField] private Transform Finish = default;
    private void OnValidate()
    {
        if (TimeVariand < 0)
        {
            TimeVariand = 0;
        }
    }

    private void Update()
    {
        if (TimeVariand > 0)
        {
            TimeVariand -= Time.deltaTime;
            if (TimeVariand <= 0)
            {
                Page_Lose_Time.SetActive(true);
                Page_Lose_Time.transform.DOMove(Start.transform.position, 1f);
                this.gameObject.SetActive(false);
                this.transform.DOMove(Finish.transform.position, 1f);
            }
        }
    }
}
