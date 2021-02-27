using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MiniGame1 : MonoBehaviour
{
   [Header("Клавишы ответов")][SerializeField]private KeyCode[] Code;
   [Header("Количество оборотов винта")][SerializeField]private int CountFulRot = 0;
   private string[] Simvol = new string[4] {"A", "W", "D", "S"};
   private GameObject NowButtom;
   private Text Text_Buttom;
   private int Index = 0;
   private float Z = 360;
   private int CountRot = 0;
   public void Bolt_Change(GameObject Buttom)
   {
        Index = 0;
        NowButtom = Buttom;
        Text_Buttom = NowButtom.GetComponentInChildren<Text>();
        Text_Buttom.text = Simvol[Index];
        Z = 0;
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
                }
            }

        }
    }
}
