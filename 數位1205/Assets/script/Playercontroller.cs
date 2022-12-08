using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public Rigidbody PlayerRB;
    public float speed = 2f;
    public float VIinput;
    public float Jumpforce = 10f ;
    public int Jumpcount = 0;
    public float gravityMod = 1; 

    public bool isonGround =true ; //是否貼合地板?

    void Start()
    {
        //取得剛體的控制權
        PlayerRB = GetComponent<Rigidbody>();
        //PlayerRB.AddForce(Vector3.up * 1000); 
        Physics.gravity = Physics.gravity * gravityMod;
        //也可以寫成 Physics.gravity *= gravityMod 比較方便;
    }

    
    void Update()
    {
        VIinput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward *Time.deltaTime*speed*VIinput);

        if (Input.GetKeyDown(KeyCode.Space) && isonGround == true || Jumpcount < 2) 
        {

            PlayerRB.AddForce(Vector3.up * 10, ForceMode.Impulse);
            Jumpcount++;
            isonGround = false;//切換 : false
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Jumpcount = 0;
        isonGround = true;//切換 : false 2
    }
}
