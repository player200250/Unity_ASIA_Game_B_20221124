using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Jay
{
    /// <summery>
    /// ���޲z��
    /// </summery>
    

    public class MenuManager : MonoBehaviour
    {
        /// <summary>
        /// �}�l�C��
        /// </summary>

        private Button btnPlay;

        private void Awake()
        {
            btnPlay = GameObject.Find("�}�l�C��").GetComponent<Button>();
            btnPlay.onClick.AddListener(StartGame);
        }

        private void StartGame() 
        {
            SceneManager.LoadScene("����");
        }
    }
}

