using UnityEngine;

namespace Defense.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;

        public GameState state;

        private void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            state = GameState.Ready;
            EventManager.Instance.On("onGameStart", OnGameStart);
            EventManager.Instance.On("onGamePaused", OnGamePaused);
            EventManager.Instance.On("onGameEnded", OnGameEnded);
        }

        void OnGameStart(object obj)
        {
            state = GameState.Playing;
        }

        void OnGamePaused(object obj)
        {
            state = GameState.Paused;
        }

        void OnGameEnded(object obj)
        {
        }
    }
}