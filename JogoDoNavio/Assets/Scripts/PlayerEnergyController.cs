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
        PlayerObserverManager.OnEnergyChanged += Quantidade;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnEnergyChanged -= Quantidade;
    }

    private void Start()
    {
        Energy = GetComponent<Slider>();
    }

    private void Quantidade(float valor)
    {
        Energy.value = valor;
    }
}
