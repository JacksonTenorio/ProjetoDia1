using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class PlayerObserverManager
{
    public static Action<int> OnPointsChanged;

    public static Action<float> OnEnergyChanged;

    public static void PointsChanged(int valor)
    {
        OnPointsChanged?.Invoke(valor);
    }

    public static void EnergyChanged(float valor)
    {
        OnEnergyChanged?.Invoke(valor);
    }
}
