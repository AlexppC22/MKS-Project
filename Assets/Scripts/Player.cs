using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VaultProject
{
    public class Player : MonoBehaviour
    {
        private Rigidbody2D playerRB;
        public bool canControl = true;
        [SerializeField] float jumpForfce;
        private void Awake() 
        {
            playerRB = GetComponent<Rigidbody2D>();
        }

        private void Update() 
        {
            PlayerMovement();
        }

        private void PlayerMovement()
        {
            if(!canControl) return;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                playerRB.AddForce(Vector2.up * jumpForfce);
                Debug.Log("Player Up");
            }
        }
    }
}

