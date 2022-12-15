using UnityEngine;
using TMPro;
using System.Collections;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;

namespace Jay 
{
    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        #region 資料區域
        [SerializeField, Header("對話間隔"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;
        [SerializeField, Header("開頭對話")]
        private DialogueDeta dialogueOpening;
        [SerializeField, Header("對話按鍵")]
        private KeyCode dialogueKey = KeyCode.Mouse0;

        private WaitForSeconds dialogueInterval => new WaitForSeconds(dialogueIntervalTime);

        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContext;
        private GameObject goTriangle;
        #endregion

        #region 事件區域
        private void Awake()
        {
            groupDialogue = GameObject.Find("對話系統").GetComponent<CanvasGroup>();
            textName = GameObject.Find("對話者名稱").GetComponent<TextMeshProUGUI>();
            textContext = GameObject.Find("對話內容").GetComponent<TextMeshProUGUI>();
            goTriangle = GameObject.Find("對話圖示");
            goTriangle.SetActive(false);

            StartDialogue(dialogueOpening);
        }
        #endregion

        public void StartDialogue(DialogueDeta deta) 
        {
            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect(deta));
        }
        

        private IEnumerator FadeGroup(bool fadIn = true) 
        {
            // 三元運算子 ? :
            //語法 :
            //布林值 ? 布林值為true : 布林值為false
            // true ? 1 : 10 結果 1
            // false ? 1 : 10 結果 10

            float increase =fadIn? +1.0f : -1.0f;


            for(int i = 0; i<10; i++) 
            {
                groupDialogue.alpha += increase;
                yield return new WaitForSeconds(0.1f);
            }
        }

        /// <summary>
        /// 打字效果
        /// </summary>

        private IEnumerator TypeEffect(DialogueDeta deta) 
        {
            textName.text = deta.dialogueName;

            for (int j = 0; j < deta.dialogueContents.Length; j++)
            {

                textContext.text = "";
                goTriangle.SetActive(false);

                string dialogue =deta.dialogueContents[j];

                for (int i = 0; i < dialogue.Length; i++)
                {
                    textContext.text += dialogue[i];
                    yield return dialogueInterval;
                }

                goTriangle.SetActive(true);

                while (!Input.GetKeyDown(dialogueKey))
                {
                    yield return null;
                }

                print("<color=#993300>玩家按下按鍵!</color>");
            }

            StartCoroutine(FadeGroup(false));
        }
    }

}

