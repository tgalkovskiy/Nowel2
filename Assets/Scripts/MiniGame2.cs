using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MiniGame2 : MonoBehaviour
{
    [SerializeField] private Transform[] PosPage =default;
    [SerializeField] private GameObject[] Page = default;
    [SerializeField] private GameObject ThisPage = default;
    [SerializeField] private Text[] Var_Text = default;
    [Header("Варианты ответа")]public int One = 0; 
    public int Two = 0;
    public int Tree = 0;
    public int Four = 0;
    public int Five = 0;
    int Count = 0;
    public void ChangeButtom1(int Var)
    {
        One = Var;
        Var_Text[0].text = Var.ToString();
    }
    public void ChangeButtom2(int Var)
    {
        Two = Var;
        Var_Text[1].text = Var.ToString();
    }
    public void ChangeButtom3(int Var)
    {
        Tree = Var;
        Var_Text[2].text = Var.ToString();
    }
    public void ChangeButtom4(int Var)
    {
        Four = Var;
        Var_Text[3].text = Var.ToString();
    }
    public void ChangeButtom5(int Var)
    {
        Five = Var;
        Var_Text[4].text = Var.ToString();
    }
    
    public void Resech()
    {
        if(One == 192)
        {
            Count += 1;
        }
        if(Two == 110)
        {
            Count += 1;
        }
        if(Tree == 226)
        {
            Count += 1;
        }
        if (Four == 764)
        {
            Count += 1;
        }
        if (Five == 694)
        {
            Count += 1;
        }
        if(Count == 5)
        {
            StartCoroutine(Lit(0));
        }
        else
        {
            StartCoroutine(Lit(1));
        }
    }

    IEnumerator Lit(int Var)
    {
        Page[Var].SetActive(true);
        Page[Var].transform.DOMove(PosPage[0].position, 1f);
        yield return new WaitForSeconds(1);
        ThisPage.SetActive(false);
        ThisPage.transform.position = PosPage[1].position;
    }
}
