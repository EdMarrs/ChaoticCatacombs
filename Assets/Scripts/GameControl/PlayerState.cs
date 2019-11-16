using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
   
        void Start()
        {
            GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health = GlobalControl.Instance.hp;
            GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts = GlobalControl.Instance.maxhp;
            gameObject.GetComponent<PlayerController>().speed = GlobalControl.Instance.speed;
            gameObject.GetComponent<PlayerController>().jumpForce = GlobalControl.Instance.jumpforce;
            gameObject.GetComponent<whipAttackScript>().damage = GlobalControl.Instance.damage;
            gameObject.GetComponent<advSpecial>().SpecialBarCurr = GlobalControl.Instance.specialBarCurr;
            gameObject.GetComponent<advSpecial>().SpecialBarMax = GlobalControl.Instance.specialBarMax;
        }

        public void SavePlayer()
        {
            GlobalControl.Instance.hp = GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().health;
            GlobalControl.Instance.maxhp = GameObject.Find("playerCollider").GetComponent<PlayerIsHit>().numberOfHearts;
            GlobalControl.Instance.speed = gameObject.GetComponent<PlayerController>().speed;
            GlobalControl.Instance.jumpforce = gameObject.GetComponent<PlayerController>().jumpForce;
            GlobalControl.Instance.damage = gameObject.GetComponent<whipAttackScript>().damage;
            GlobalControl.Instance.specialBarCurr = gameObject.GetComponent<advSpecial>().SpecialBarCurr;
            GlobalControl.Instance.specialBarMax = gameObject.GetComponent<advSpecial>().SpecialBarMax;

        }
        
}