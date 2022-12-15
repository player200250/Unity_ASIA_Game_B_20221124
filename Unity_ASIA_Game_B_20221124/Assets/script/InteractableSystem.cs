using UnityEngine;

namespace Jay 
{
    ///<summery>
    ///互動系統:偵測玩家是否進入觸發區並處理互動行為
    ///</summery>

    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueDeta detaDialogue;

        private string nameTarget = "PlayerCapsule";
        private DialogueSystem dialogueSystem;

        private void Awake()
        {
            dialogueSystem = GameObject.Find("對話系統").GetComponent<DialogueSystem>();
        }

        //3D 物件
        //兩個碰撞之間必須其中一個勾選 IS Trigger
        //碰撞開始
        private void OnTriggerEnter(Collider other)
        {
            //如果 碰撞物件名稱 包含 playerCapsule 就執行 {}
            if(other.name.Contains(nameTarget))
            {
                print(other.name);
                dialogueSystem.StartDialogue(detaDialogue);
            }
        }

        //碰撞結束
        private void OnTriggerExit(Collider other) 
        {
            
        }
        //碰撞持續
        private void OnTriggerStay(Collider other)
        {
            
        }
    }

}


