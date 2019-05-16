using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{

   private void OnTriggerEnter2D(Collider2D obj)
    {	
    	// Si tuyau dépassé alors instancier le score
        if(obj.GetComponent<Bird>() != null)
        {
            GameController.Instance.Score();
        }
    }
}
