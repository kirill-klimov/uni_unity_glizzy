using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyAmountText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.MoneyAmountUpdated += OnMoneyUpdate;
    }

    void OnMoneyUpdate() {
        GetComponent<TextMeshProUGUI>().text = "$" + GameManager.MoneyAmount;
    }
}
