using UnityEngine;

namespace Script
{
    public class PaddleControl : MonoBehaviour
    {
        public KeyCode input;
	
        // menyimpan angka target position saat ditekan dan dilepas
        private float _targetPressed;
        private float _targetRelease;

        private HingeJoint hinge;

        private void Start()
        {
            hinge = GetComponent<HingeJoint>();
	
            // saat Start, kita set kedua target tersebut
            var limits = hinge.limits;
            _targetPressed = limits.max;
            _targetRelease = limits.min;
        }

        private void Update()
        {
            ReadInput();
        }

        private void ReadInput()
        {
            JointSpring jointSpring = hinge.spring;

            if (Input.GetKey(input))
            {
                //disini kita ganti menjadi mengubah target position nya
                jointSpring.targetPosition = _targetPressed;
            }
            else
            {
                jointSpring.targetPosition = _targetRelease;
            }
  
            hinge.spring = jointSpring;
        }
    }
}
