using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
  private static CanvasController canvasController = new CanvasController();
  
  [SerializeField] private GameObject[] stars;
  [SerializeField] private Button button;
  [SerializeField] private GameObject[] emptyStars;
  [SerializeField] private GameObject[] fullStars;

  public string tag;
  private int amount = canvasController.amount;
  
  public void OnClickButton()
  {
    tag = button.tag;
  }

  private void Update()
  {
    if (tag == button.tag)
    {
      for (int i = 0; i < emptyStars.Length; i++)      
          {                                                
            fullStars[i].SetActive(i < amount);          
            emptyStars[i].SetActive(i >= amount);        
          } 
    }
  }
  
}
