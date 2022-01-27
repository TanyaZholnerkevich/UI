using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject victoryWin;

    void Start()
    {
        victoryWin.SetActive(false);
    }

    public void PlayLevel()
    {
        menu.SetActive(false);
    }
    
}
