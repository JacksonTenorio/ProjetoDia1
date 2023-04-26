using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerControllerPoints : MonoBehaviour
{
    private TMP_Text mytText;

    private void OnEnable()
    {
        PlayerObserverManager.OnPointsChanged += UpdatePoints;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnPointsChanged -= UpdatePoints;
    }

    private void Awake()
    {
        mytText = GetComponent<TMP_Text>();
    }
    
    private void UpdatePoints(int valor)
    {
        mytText.text = valor.ToString();
    }
}
