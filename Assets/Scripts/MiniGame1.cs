using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame1 : MonoBehaviour
{
   private GameObject NowButtom;
   public void Bolt_Change(GameObject Buttom)
   {
        NowButtom = Buttom;
   }

    private void Update()
    {
        if (NowButtom)
        {

        }
    }
}
