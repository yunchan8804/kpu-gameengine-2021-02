using UnityEngine;

namespace Defense.Monster
{
    public class Monster : MonoBehaviour
    {
        private void OnEnable()
        {
            Invoke(nameof(Dead), 3);
        }

        void Dead()
        {
            gameObject.SetActive(false);
        }
    }
}