using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Jay
{
   /// <summary>
    /// 結束管理器
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        /// <summary>
        /// 結束畫布
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// 結束標題
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// 重新遊戲
        /// </summary>
        private Button btnReplay;
        private void Awake()
        {
            instance= this;

            groupFinal = GameObject.Find("遊戲結束").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        public void GameOver(string title) 
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// 淡入
        /// </summary>
        private IEnumerator FadeIn()
         {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 1.0f;
                yield return new WaitForSeconds(0.05f);

            }

            groupFinal.interactable= true;
            groupFinal.blocksRaycasts= true;

        }

        private void Replay()
        {
            
            SceneManager.LoadScene("開頭場景");
        }
    }
}

