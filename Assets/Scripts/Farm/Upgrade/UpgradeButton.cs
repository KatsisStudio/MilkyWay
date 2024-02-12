﻿using CowMilking.Persistency;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace CowMilking.Farm.Upgrade
{
    public class UpgradeButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void Start()
        {
            UpdateUI();
        }

        public void UpdateUI()
        {
            _button.interactable = PersistencyManager.Instance.SaveData.OwnedCows.Any(x => x == "NEUTRAL") && PersistencyManager.Instance.SaveData.Potions.Any();
        }

        public void OnClick()
        {
            FarmManager.Instance.ClickAction = ClickAction.Upgrade;

            foreach (var c in FarmManager.Instance.Cows)
            {
                if (c.Info.Element == Character.Player.ElementType.None)
                {
                    c.Allow();
                }
                else
                {
                    c.Disallow();
                }
            }
        }
    }
}