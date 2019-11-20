using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger : Monobehavior
{
    public int key = 0;
    public void OnTriggerEnter(Collider Player)
    {
        if (enter)
        {
            if(GameObject.FindObjectsWithTag("Room1")){
                key++;
                destroy(CollectionBase.gameObject.GetComponent<Collider>());
            }

            else if(GameObject.FindObjectsWithTag("Room2")){
                key++;
                destroy(CollectionBase.gameObject.GetComponent<Collider>());
            }

            else if(GameObject.FindObjectsWithTag("Room3")){
                key++;
                destroy(CollectionBase.gameObject.GetComponent<Collider>());
            }

            else if(GameObject.FindObjectsWithTag("Room4")){
                key++;
                destroy(CollectionBase.gameObject.GetComponent<Collider>());
            }
        }

        if(key == 4){
            destroy(MainPlatform_M);
        }
    }
}