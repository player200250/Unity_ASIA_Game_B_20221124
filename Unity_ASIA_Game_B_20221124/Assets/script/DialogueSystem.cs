using UnityEngine;
using TMPro;
using System.Collections;

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

            StartCoroutine(FadeGroup());
            StartCoroutine(TypeEffect());

        } 
        #endregion

        private IEnumerator FadeGroup() 
        {
            for(int i = 0; i<10; i++) 
            {
                groupDialogue.alpha += 0.1f;
                yield return new WaitForSeconds(0.1f);
            }
        }

        /// <summary>
        /// 打字效果
        /// </summary>

        private IEnumerator TypeEffect() 
        {
            textName.text = dialogueOpening.dialogueName;
            textContext.text = "";

            string dialogue = dialogueOpening.dialogueContents [1];

            for (int i = 0; i < dialogue.Length; i++)
            {
                textContext.text += dialogue[i];
                yield return dialogueInterval;
            }

            goTriangle.SetActive(true);

        }
    }

}

