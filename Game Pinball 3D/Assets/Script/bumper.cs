using UnityEngine;

namespace Script
{
    public class Bumper : MonoBehaviour
    {
        public Collider bola;
        public float multiplier;
        public Color color;
        public Audio audioManager;
        private Renderer _renderer;
        private Animator _animator;
        public VFXManager VFXManager;
        public ScoreManage ScoreManager;
        private void Start()
        {
            _renderer = GetComponent<Renderer>();
            _animator = GetComponent<Animator>();

            _renderer.material.color = color;
        }

        private void OnCollisionEnter(Collision collision)
        {
            var position = collision.transform.position;
            if (collision.collider == bola)
            {
                _animator.SetTrigger("hit");//animasi
                //mantul
                Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
                bolaRig.velocity *= multiplier;
                audioManager.PlaySFXBumper(position);//sfx
                VFXManager.PlayVFXBumper(position);//vfx 
                ScoreManager.AddScore(5);

            }
        }
    }


}
