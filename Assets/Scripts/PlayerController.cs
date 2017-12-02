using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        public float MoveSpeed;

        public float JumpForce;

        private Rigidbody2D _playeRigidbody;
        // Use this for initialization
        void Start ()
        {
            _playeRigidbody = GetComponent<Rigidbody2D>();
        }
	
        // Update is called once per frame
        void Update () {
		    _playeRigidbody.velocity=new Vector2(MoveSpeed,_playeRigidbody.velocity.y);
            if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(0))
            {
                _playeRigidbody.velocity=new Vector2(_playeRigidbody.velocity.x,JumpForce);
            }
        }
    }
}
