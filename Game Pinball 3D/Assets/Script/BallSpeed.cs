using UnityEngine;

namespace Script
{
    public class BallSpeed : MonoBehaviour
    {
        // set max speed nya di inspector
        public float maxSpeed;

        private Rigidbody _rig;

        private void Start()
        {
            _rig = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            // cek besaran (magnitude) kecepatannya
            if (_rig.velocity.magnitude > maxSpeed)
            {
                // kalau melebihi buat vector velocity baru dengan besaran max speed
                _rig.velocity = _rig.velocity.normalized * maxSpeed;
            }
        }
    }
}
