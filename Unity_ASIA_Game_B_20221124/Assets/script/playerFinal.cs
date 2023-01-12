using Jay;
using UnityEngine;


namespace Jay
{
    /// <summary>
    /// 玩家結束管理 ; 過關
    /// </summary>
    public class playerFinal : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collision)
        {
            //過關
            FinalManager.instance.GameOver("遊戲結束!感謝你的遊玩!!!");
        }
    }
}
