using UnityEngine;

namespace Script
{
    public class ChangeColor : MonoBehaviour
    {
        // untuk mengatur warna bumper
        public Color color;


// komponen renderer pada object yang akan diubah
        private new Renderer  renderer;


        private void Start()
        {
            // karena material ada pada component Rendered, maka kita ambil renderernya
            renderer = GetComponent<Renderer>();

            // kita akses materialnya dan kita ubah warna nya saat Start
            renderer.material.color = color;
        }
    }
}
