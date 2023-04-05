using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuControler : MonoBehaviour
{
    public void LoadLevel(String levelname)
    {
        GameManager.Instance.LoadScene(levelname);
    }
}
