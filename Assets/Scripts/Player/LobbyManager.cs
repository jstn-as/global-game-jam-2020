using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Users;

namespace Player
{
    public class LobbyManager : MonoBehaviour
    {
        [SerializeField] private GameObject _playerPrefab;
        [SerializeField] private List<int> _players;

        private void OnEnable()
        {
            InputUser.listenForUnpairedDeviceActivity = 1;
        }

        private void OnDisable()
        {
            InputUser.listenForUnpairedDeviceActivity = 0;
        }
        private void Awake()
        {
            InputUser.onUnpairedDeviceUsed += OnUnpairedDeviceUsed;
        }


        private void OnUnpairedDeviceUsed(InputControl control, InputEventPtr ptr)
        {
            // Don't respond to paired devices.
            if (_players.Contains(ptr.id)) return;

            // Keyboard & Mouse
            if (ptr.id == 1 || ptr.id == 2)
            {
            }
        }
    }
}
