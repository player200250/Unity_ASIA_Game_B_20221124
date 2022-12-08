using System.Collections;
using UnityEngine;


namespace Jay
{
    /// <summary>
    /// 認識協同程序,簡稱協程 Coroutine
    /// 目的讓程是停留或等待
    /// </summary>

    public class LearnCoroutine : MonoBehaviour
    {
        //使用協同勝的四個物件
        //1. 引用命名空間 System.Collections
        //2. 定義一個傳回 IEnumerator 的方法
        //3. 方法內必須使用 yield return (等待)
        //4. 使用 StartCoroutine 啟動

        //字串是一個 char 陣列
        private string textDialogue = "我不做人啦!jojo";

        private void Awake()
        {
            //StartCoroutine(Test());

            print("第一個字 : " + textDialogue[0]);

            //StartCoroutine(ShowText());

            StartCoroutine(ShowTextUseFor());
        }

        private IEnumerator Test() 
        {
            print("<color=#33ff33>第一行</color>");
            yield return new WaitForSeconds(2);
            print("<color=#33ff33>第二行</color>");
            yield return new WaitForSeconds(3.5f);
            print("<color=#33ff33>第三行</color>");


        }
        private IEnumerator ShowText() 
        {
            print(textDialogue[0]);
            yield return new WaitForSeconds(0.1f);
            print(textDialogue[1]);
            yield return new WaitForSeconds(0.1f);
            print(textDialogue[2]);
            yield return new WaitForSeconds(0.1f);

        }
        private IEnumerator ShowTextUseFor()
        {
           for (int i = 0; i < textDialogue.Length; i++) 
            {
                print(textDialogue[i]);
                yield return new WaitForSeconds((0.3f));
            }
        }
    }

}
