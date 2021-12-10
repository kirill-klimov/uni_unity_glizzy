using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewManager : MonoBehaviour
{
    [SerializeField] Canvas shopCanvas; 

    public void ShowShopCanvas() {
        shopCanvas.gameObject.SetActive(true);
    }

    public void ShowGameCanvas() {
        shopCanvas.gameObject.SetActive(false);
    }
}
