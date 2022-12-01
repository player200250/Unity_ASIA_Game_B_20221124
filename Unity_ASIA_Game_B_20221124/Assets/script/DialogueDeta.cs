using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jay 
{
    /// <summery>
    /// 對話資料
    /// </summery>
    [CreateAssetMenu(menuName = "Jay/Dialogue Deta", fileName = "New Dialogue Deta")]
    public class DialogueDeta : ScriptableObject
    {
        [Header("對話者名稱")]
        public string dialogueName;
        [Header("對話者內容"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}

