using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jay 
{
    /// <summary>
    /// 音效系統
    /// </summary>
    /// 要求元件:在第一次套用此腳本時會添加裡面指定元件
    [RequireComponent(typeof(AudioSource))]
    public class soundSystem : MonoBehaviour
    {
        private AudioSource aud;

        private void Awake()
        {
                aud= GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        ///<param name="sound">要撥放的音效</param>
        public void Playsound(AudioClip sound) 
        {
            //音效來源,播放一次音樂(音效)
            aud.PlayOneShot(sound);
        }
    }
}

