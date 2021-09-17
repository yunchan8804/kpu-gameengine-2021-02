using System;
using Defense.Manager;
using UnityEngine;

namespace Defense.Ui
{
    public class PauseButton : MonoBehaviour
    {
        private void Start()
        {
            EventManager.Instance.On("onGameStart", OnGameStart);
            EventManager.Instance.On("onGamePaused", OnGamePaused);
        }

        public void PauseButtonDown()
        {
            EventManager.Instance.Emit("onGamePaused", null);
        }

        private void OnGameStart(object obj)
        {
            gameObject.SetActive(true);
        }


        void OnGamePaused(object param)
        {
            gameObject.SetActive(false);
        }
    }
}