using UnityEngine;

namespace Assets.Scripts
{
    public class PlatformGenerator : MonoBehaviour
    {

        public GameObject ThePlatform;

        public Transform GenerationPoint;

        public float DistanceBetween;

        private float _platformWidth;

        // Use this for initialization
        void Start ()
        {
            _platformWidth = ThePlatform.GetComponent<BoxCollider2D>().size.x;
        }
	
        // Update is called once per frame
        void Update () {
            if (transform.position.x < GenerationPoint.position.x)
            {
                transform.position=new Vector3(transform.position.x+_platformWidth+DistanceBetween,transform.position.y,transform.position.z);
                Instantiate(ThePlatform, transform.position, transform.rotation);
            }
        }
    }
}
