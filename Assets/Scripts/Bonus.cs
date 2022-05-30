using System;
using UnityEngine;

namespace Maze
{
    public abstract class Bonus : MonoBehaviour, IExecute
    {
        private bool _isInteractable;

        public Transform _transform;
        public bool IsInteractable
        { 
            get { return _isInteractable; }
            private set 
            { 
                _isInteractable = value; 
                GetComponent<Renderer>().enabled = value;
                GetComponent<Collider>().enabled = value;
            }
        }

        private void Awake()
        {
            _transform = GetComponent<Transform>();
        }
        void Start()
        {
            _isInteractable=true;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Interaction();
                _isInteractable=false;
            }
        }
        protected abstract void Interaction();
        public abstract void Update();
        
    }
}