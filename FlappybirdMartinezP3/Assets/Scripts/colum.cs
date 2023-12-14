using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colum : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Spaceship>() != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
