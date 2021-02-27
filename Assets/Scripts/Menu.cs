using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void MenuActiv(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
    public void MenuDeactive(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
}
