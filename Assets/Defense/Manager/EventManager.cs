using System;
using System.Collections.Generic;
using UnityEngine;

namespace Defense.Manager
{
    public class EventManager : MonoBehaviour
    {
        private Dictionary<string, List<Action<object>>> _eventDatabase;
        
        public static EventManager Instance;

        private void Awake()
        {
            Instance = this;
            _eventDatabase = new Dictionary<string, List<Action<object>>>();
        }

        /// <summary>
        /// 이벤트가 발동할 때 행할 행동들을 정의
        /// </summary>
        public void On(string eventName, Action<object> action)
        {
            // 일단 event Database에 공간이 마련이 되었는지 확인
            if (!_eventDatabase.ContainsKey(eventName)) 
                _eventDatabase.Add(eventName, new List<Action<object>>());
            
            _eventDatabase[eventName].Add(action);
        }

        /// <summary>
        /// 이벤트를 발동 시킴
        /// </summary>
        public void Emit(string eventName, object param)
        {
            // 해당 키값이 존재 하는지 확인해야 함.
            if(!_eventDatabase.ContainsKey(eventName))
                print($"{eventName}이라는 이벤트는 존재하지 않습니다.");
            else
            {
                if (_eventDatabase[eventName].Count > 0)
                    foreach (var action in _eventDatabase[eventName])
                    {
                        action.Invoke(param);
                    }
            }
        }
        

    }
}
