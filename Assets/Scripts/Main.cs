using System;
using UnityEngine;


namespace Maze
{
    public class Main : MonoBehaviour
    {
        private ListExecuteObject _interactiveObject;
        private InputController _inputController;

        [SerializeField] private GameObject _player;
        private void Awake()
        {
            _inputController = new InputController(_player.GetComponent<Unit>());
            _interactiveObject = new ListExecuteObject();

           // _inputController.AddExecuteObject(_inputController);
        }
        
        void Update()
        {
            for (int i = 0; i < _interactiveObject.Length; i++)
            {
                if  (_interactiveObject[i] == null)
                {
                    continue;
                }
                _interactiveObject[i].Update();
            }
        }
    }
}