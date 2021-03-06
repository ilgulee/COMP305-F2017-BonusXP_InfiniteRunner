﻿using UnityEngine;

namespace Assets.Scripts
{
    public class PlatformDestroyer : MonoBehaviour
    {
        public GameObject PlatformDestructionPoint;
        // Use this for initialization
        void Start () {
		    PlatformDestructionPoint=GameObject.Find("PlatformDestructionPoint");
        }
	
        // Update is called once per frame
        void Update () {

            if (transform.position.x < PlatformDestructionPoint.transform.position.x)
            {
                Destroy(gameObject);
            }
        }
    }
}
