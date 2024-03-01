using TMPro;
using UnityEngine;

namespace Script
{
    public class Tutorial : MonoBehaviour
    {
        // Referensi ke komponen teks
        public TMP_Text textComponent;

        // Method ini akan dipanggil saat tombol ditekan
        private void Update()
        {
            // Misalnya, kita akan menggunakan tombol "Space" untuk mengontrol teks
            if (Input.GetKeyDown(KeyCode.L))
            {
                // Nonaktifkan teks
                textComponent.enabled = false;
            }
        }
    }
}
