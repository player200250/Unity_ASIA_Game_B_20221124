using Jay;
using UnityEngine;


namespace MyNamespace
{
    /// <summary>
    /// ���a�����޲z ; �L��
    /// </summary>
    public class playerFinal : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collision)
        {
            //�L��
            FinalManager.instance.GameOver("�C������!�P�§A���C��!!!");
        }
    }
}
