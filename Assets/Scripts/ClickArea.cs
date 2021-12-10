using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickArea : MonoBehaviour
{
    public static event Action ClickHappend;

    public void Click() {
        ClickHappend?.Invoke();
    }
}
