using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PageManeger : MonoBehaviour
{
    [SerializeField] private List<GameObject> Page = new List<GameObject>();
    [SerializeField] private Transform[] PosPage;
    private int StartIndexPage = 0;
    private void Awake()
    {
        Page[0].transform.position = PosPage[0].position;
    }
    public void VariablePage(int Var)
    {
        StartCoroutine(MovePage(Var));
    }
    IEnumerator MovePage(int Var)
    {
        Page[Var].SetActive(true);
        Page[Var].transform.DOMove(PosPage[0].position, 1f);
        yield return new WaitForSeconds(1);
        Page[StartIndexPage].SetActive(false);
        Page[StartIndexPage].transform.position = PosPage[1].position;
        StartIndexPage = Var;
    }
}
