using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager Instance;

    [SerializeField] private List<EnemySO> Enemyes;
    [SerializeField] private GameObject enemyPrefab;

        private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        } 
    }
    
    public void LoadLevel(String scenename)
    {
        SceneManager.LoadScene(scenename);
        SceneManager.LoadScene("GUI", LoadSceneMode.Additive);
    }

    public void LoadScene(String scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadScene("Splash");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MainMenu");
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene("Initialization");
        }*/
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
            SpawnEnemy(0);
        }
        if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
            SpawnEnemy(1);
        }
        if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
            SpawnEnemy(2);
        }
        
    }

    public void SpawnEnemy(int type)
    {
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.GetComponent<EnemyController>().InitializeEnemy(Enemyes[type].maxEnergy, Enemyes[type].wnemySprite);
    }
}
