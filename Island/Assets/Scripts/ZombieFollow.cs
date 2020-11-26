using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieFollow : MonoBehaviour
{

    GameObject player;
    private int vurulma = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<NavMeshAgent>().destination = player.transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag.Equals("bullet"))
        {
            vurulma = vurulma + 1;
            if(vurulma == 3)
            {
                vurulma = 0;
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject,1.667f);//1,667 animasyon süresi o süre sonra yok et
            }
        }




    }

}
