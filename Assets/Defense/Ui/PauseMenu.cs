using Defense.Manager;
using UnityEngine;

namespace Defense.Ui
{
    public class PauseMenu : MonoBehaviour
    {
        void Start()
        {
            EventManager.Instance.On("onGameStart", OnGameStarted);
            EventManager.Instance.On("onGamePaused", OnGamePaused);
        }

        void OnGameStarted(object param)
        {
            gameObject.SetActive(false);
        }

        void OnGamePaused(object param)
        {
            gameObject.SetActive(true);
        }
    }
}