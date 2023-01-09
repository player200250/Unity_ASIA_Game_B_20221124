using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Jay
{
   /// <summary>
    /// �����޲z��
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        /// <summary>
        /// �����e��
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// �������D
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// ���s�C��
        /// </summary>
        private Button btnReplay;
        private void Awake()
        {
            instance= this;

            groupFinal = GameObject.Find("�C������").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        public void GameOver(string title) 
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// �H�J
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
            
            SceneManager.LoadScene("�}�Y����");
        }
    }
}

