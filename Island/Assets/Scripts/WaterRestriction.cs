using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRestriction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            print("Oyunu Bitir");
        }
    }
}
