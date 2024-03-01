using UnityEngine;

namespace Script
{
    public class TrigerZoomOut : MonoBehaviour
    {
        public Collider bola;
        public CameraControl cameraController;

        private void OnTriggerEnter(Collider other)
        {
            if (other == bola)
            {
                Debug.Log("Hit");
                cameraController.GoBackToDefault();
                
            }
        }
    
    }
}
