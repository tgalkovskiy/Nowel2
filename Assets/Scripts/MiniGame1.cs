using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class MiniGame1 : MonoBehaviour
{
   [Header("Клавишы ответов")][SerializeField]private KeyCode[] Code;
   [Header("Количество оборотов винта")][SerializeField]private int CountFulRot = 0;
   [Header("Крышка")] [SerializeField] private GameObject Panel = default;
   [SerializeField] List<GameObject> Var = new List<GameObject>();
   [SerializeField] List<GameObject> Bottum_Clouse = new List<GameObject>();
   [SerializeField] private GameObject Buttom_Exit = default;
   [SerializeField] private Image MainSprite = default;

   private string[] Simvol = new string[4] {"A", "W", "D", "S"};
   private GameObject NowButtom;
   private Text Text_Buttom;
   private int Index = 0;
   private float Z = 360;
   private int CountRot = 0;
   private int End_Mini_Game1 = 0;
   public void Bolt_Change(GameObject Buttom)
   {
        Index = 0;
        NowButtom = Buttom;
        Text_Buttom = NowButtom.GetComponentInChildren<Text>();
        Text_Buttom.text = Simvol[Index];
        Z = 0;
   }
   
   public void Change_Sprite(int Varible)
   {
        Var[Varible].SetActive(true);
        Buttom_Exit.SetActive(true);
        for(int i =0; i< Bottum_Clouse.Count; i++)
        {
            Bottum_Clouse[i].SetActive(false);
        }
   }

   private void Update()
    {
        if (NowButtom)
        {
            if (Input.GetKeyDown(Code[Index]))
            {
                Z -= 90;
                NowButtom.transform.DORotate(new Vector3(0,0,Z), 0.2f);
               
                if (Index < 4)
                {
                    Index += 1;
                }
                if(Index == 4)
                {
                    Index = 0;
                    CountRot += 1;
                    Z = 0;
                    
                }
                Text_Buttom.text = Simvol[Index];
                if (CountRot >= CountFulRot)
                {
                    NowButtom.SetActive(false);
                    CountRot = 0;
                    End_Mini_Game1 += 1;
                }
                if (End_Mini_Game1 == 4)
                {
                    Panel.SetActive(true);
                }
            }

        }
    }
}
