using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnergyController : MonoBehaviour
{
    private Slider Energy;

    private void OnEnable()
    {
        PlayerObserverManager.OnEnergyChanged += UpdateEnergy;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnEnergyChanged -= UpdateEnergy;
    }

    private void Start()
    {
        Energy = GetComponent<Slider>();
    }

    private void UpdateEnergy(float valor)
    {
        Energy.value = valor;
    }
}
