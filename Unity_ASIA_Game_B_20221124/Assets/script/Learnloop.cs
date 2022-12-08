﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jay 
{
    /// <summary>
    /// 學習迴圈,重複執行程式
    /// for while do while foreach
    /// </summary>

    public class Learnloop : MonoBehaviour
    {
        private void Awake()
        {
            //for 迴圈語法
            //for (初始值; 布林值 條件 ; 迴圈結束執行) { 程式 }
            for (int i = 0; i<10; i++)
            {

                print("for 迴圈內容 : " + 1);

            }

            for (int number = 0; number < 5; number++)
            {

                print("迴圈 : " + number);
            
            }
        }
    }
}


