using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    public event Action onMainMenu;
    public event Action onItemsMenu;
    public event Action onARposition;

    public static GameManager instance;
    private void Awake()
    {
        if (instance != null && instance != this)
        {

            Destroy(gameObject);
        }
        else
        {
            instance = this;

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        onMainMenu?.Invoke();
        Debug.Log("MainMenu activated");
    }
    public void ItemsMenu()
    {
        onItemsMenu?.Invoke();

        Debug.Log("ItemMenu activated");
    }

    public void ARposition()
    {
        onARposition?.Invoke();
        Debug.Log("ARposition Activated");
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}
