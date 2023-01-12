﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jay
{
    /// <summary>
    /// 射擊系統
    /// </summary>
    public class recoilscript : MonoBehaviour
    {
        public GameObject Gun;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                StartCoroutine(StartRecoil());
            }
        }

        IEnumerator StartRecoil()
        {
            Gun.GetComponent<Animator>().Play("射擊動畫");
            yield return new WaitForSeconds(0.20f);
            Gun.GetComponent<Animator>().Play("New State");
        }
    }
}