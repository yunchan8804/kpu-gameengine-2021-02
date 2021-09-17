using System;
using Defense.Manager;
using TMPro;
using UnityEngine;

namespace Defense.Ui
{
    public class GameStatePrinter : MonoBehaviour
    {
        private TMP_Text _text;

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
        }

        void Update()
        {
            _text.text = GameManager.Instance.state.ToString();
        }
    }
}