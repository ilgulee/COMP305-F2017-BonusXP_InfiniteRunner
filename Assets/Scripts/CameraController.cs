using UnityEngine;

namespace Assets.Scripts
{
    public class CameraController : MonoBehaviour
    {

        public PlayerController ThePlayer;

        private Vector3 _lastPlayerPosition;
        private float _distanceToMove;

        // Use this for initialization
        void Start ()
        {
            ThePlayer = FindObjectOfType<PlayerController>();
            _lastPlayerPosition = ThePlayer.transform.position;
        }
	
        // Update is called once per frame
        void Update ()
        {
            _distanceToMove = ThePlayer.transform.position.x -_lastPlayerPosition.x;
            transform.position=new Vector3(transform.position.x+_distanceToMove,transform.position.y,transform.position.z);//camera
            _lastPlayerPosition = ThePlayer.transform.position;
        }
    }
}
