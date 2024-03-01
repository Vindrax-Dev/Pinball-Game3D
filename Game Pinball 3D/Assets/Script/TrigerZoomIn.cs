using UnityEngine;

namespace Script
{
    public class TrigerZoomIn : MonoBehaviour
    {
        public Collider bola;
        public CameraControl cameraController;
        public float length;

        private void OnTriggerEnter(Collider other)
        {
            if (other == bola)
            {
                cameraController.FollowTarget(bola.transform, length);
            }
        }
  
    }
}

