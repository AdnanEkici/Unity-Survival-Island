using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameplay : MonoBehaviour
{
    public Transform bulletLoc; // merminin cıkacagı pozisyon
    public GameObject bullet;// olusacak mermiler
    public GameObject atesEfect;// patlama efecti
    public GameObject dumanEfect;// duman efecti

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(bullet, bulletLoc.position, bulletLoc.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = bulletLoc.transform.forward * 1000f; // ileri yönde hız uygula
            GameObject goatesEfect = Instantiate(atesEfect, bulletLoc.position, bulletLoc.rotation) as GameObject;
            GameObject godumanEfect = Instantiate(dumanEfect, bulletLoc.position, bulletLoc.rotation) as GameObject;
            Destroy(go.gameObject, 10f);
            Destroy(goatesEfect.gameObject, 1f);
            Destroy(godumanEfect.gameObject, 1f);
        }
       


    }


    private void OnCollisionEnter(Collision collision)
    {
        print("dokundum");
        if(collision.gameObject.tag.Equals("zombi"))
        {
            print("zombi ısırıyor");
        }
    }




}
