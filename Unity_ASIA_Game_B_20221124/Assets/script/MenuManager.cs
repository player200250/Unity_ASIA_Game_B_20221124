using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Jay
{
    /// <summery>
    /// 選單管理器
    /// </summery>
    

    public class MenuManager : MonoBehaviour
    {
        /// <summary>
        /// 開始遊戲
        /// </summary>

        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("開始遊戲").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }

        private void StartGame() 
        {
            SceneManager.LoadScene("場景");
        }
    }
}

