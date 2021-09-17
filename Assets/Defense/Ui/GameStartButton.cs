using Defense.Manager;
using UnityEngine;

namespace Defense.Ui
{
    public class GameStartButton : MonoBehaviour
    {
        public void GameStart()
        {
            EventManager.Instance.Emit("onGameStart", null);
        }
    }
}
