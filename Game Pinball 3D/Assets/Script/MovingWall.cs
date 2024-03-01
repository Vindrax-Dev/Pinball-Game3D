using UnityEngine;

namespace Script
{
    public class MovingWall : MonoBehaviour
    {
        public float speed = 2f; // Kecepatan gerakan tembok
        public float moveDistance = 90f; // Jarak maksimum yang bisa dijalankan ke kanan dan ke kiri
        private bool _movingRight = true; // Status arah gerakan

        void Update()
        {
            // Gerakkan tembok ke samping sesuai arah
            if (_movingRight)
            {
                transform.Translate(Vector3.right * (speed * Time.deltaTime));
            }
            else
            {
                transform.Translate(Vector3.left * (speed * Time.deltaTime));
            }

            // Cek apakah mencapai batas pergerakan, jika iya, ubah arah gerakan
            if (transform.position.x >= moveDistance && _movingRight)
            {
                _movingRight = false;
            }
            else if (transform.position.x <= -moveDistance && !_movingRight)
            {
                _movingRight = true;
            }
        }
    }
}