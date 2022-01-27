using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CanvasController : MonoBehaviour
{
    [SerializeField] private GameObject victoryWin;
    [SerializeField] private GameObject[] emptyStars;
    [SerializeField] private GameObject[] fullStars;
    public int amount;
    void Start()
    {
        foreach (var fullStar in fullStars)
        {
            fullStar.SetActive(false);
        }
        victoryWin.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            amount = 1;
            victoryWin.SetActive(true);
            ActivateStars();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            amount = 2;
            victoryWin.SetActive(true); 
            ActivateStars();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            amount = 3;
            victoryWin.SetActive(true); 
            ActivateStars();
        }
    }

    public void ActivateStars()
    {
        for (int i = 0; i < emptyStars.Length; i++)
        {
            fullStars[i].SetActive(i < amount);
            emptyStars[i].SetActive(i >= amount);
        }
    }

}
