using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject clickArea;
    static List<GameItem> itemList = new List<GameItem>() {
        new GameItem() {
            Id = 0,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 0,
        },
        new GameItem() {
            Id = 1,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 0,
        },
        new GameItem() {
            Id = 2,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 0,
        },
        new GameItem() {
            Id = 3,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 0,
        },

        new GameItem() {
            Id = 4,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 1,
        },
        new GameItem() {
            Id = 5,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 1,
        },
        new GameItem() {
            Id = 6,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 1,
        },
        new GameItem() {
            Id = 7,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 1,
        },
    };
    static List<GameItem> boughtItems = new List<GameItem>() {
        new GameItem() {
            Id = 4,
            Price = 1,
            ProgressMultiplier = 1,
            MoneyMultiplier = 1,
            Type = 1,
        },
    };
    public static float ProgressMultiplier = 1f; 
    public static int MoneyAmount = 0;
    static int moneyMultiplier = 1; 
    static int doctorAmount = 1;
    [SerializeField] GameObject[] doctors;
    public static event Action MoneyAmountUpdated;
    void Start()
    {
        ProgressBar.Completed += OnProgressComplete;
        UpdateMoneyText();
    }

    void OnProgressComplete() {
        MoneyAmount += moneyMultiplier;
        UpdateMoneyText();
    }

    public void BuyImprovment(int index) {
        GameItem boughtItem = boughtItems.Find(item => item.Id == index);
        if (boughtItem != null) return;
        GameItem item = itemList.Find(item => item.Id == index);

        
        if (MoneyAmount >= item.Price) {
            ProgressMultiplier += item.ProgressMultiplier;
            moneyMultiplier += item.MoneyMultiplier;
            MoneyAmount -= item.Price;
            if (item.Type == 1) {
                doctorAmount += 1;
                doctors[doctorAmount-1].SetActive(true);
            }
            boughtItems.Add(item);
        }
        UpdateMoneyText();
    }

    static void UpdateMoneyText() {
        MoneyAmountUpdated?.Invoke();
    }
}