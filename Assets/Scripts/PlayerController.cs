using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float MoveSpeed;

        public float JumpForce;

        private Rigidbody2D _playeRigidbody;

        public bool IsGrounded;

        public LayerMask WhatIsGround;

        private Collider2D _playCollider; 
        // Use this for initialization
        void Start ()
        {
            _playeRigidbody = GetComponent<Rigidbody2D>();
            _playCollider = GetComponent<Collider2D>();
        }
	
        // Update is called once per frame
        void Update ()
        {
            IsGrounded = Physics2D.IsTouchingLayers(_playCollider, WhatIsGround);
		    _playeRigidbody.velocity=new Vector2(MoveSpeed,_playeRigidbody.velocity.y);
            if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(0))
            {
                if (IsGrounded)
                {
                    _playeRigidbody.velocity = new Vector2(_playeRigidbody.velocity.x, JumpForce);
                }
            }
        }
    }
}
