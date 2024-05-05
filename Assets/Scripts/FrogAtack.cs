using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogAtack : MonoBehaviour
{
    // Start is called before the first frame update

public GameController gameController;


void OnTriggerEnter2D(Collider2D col)
  {
    if(col.gameObject.tag == "Player")
    {
       gameController.ShowGameOver();

    }
  }
}
