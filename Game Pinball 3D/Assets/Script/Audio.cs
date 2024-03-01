using UnityEngine;

namespace Script
{
    public class Audio : MonoBehaviour
    {
        public AudioSource bgmAudioSource;
        public GameObject sfxAudioSourceBumper;
        public GameObject sfxAudioSourceSwitchon;
        public GameObject sfxAudioSourceSwitchoff;
        private void Start()
        {
            // jalankan BGM saat game dimulai
            PlayBGM();
        }
	
        // fungsi yang disiapkan untuk perintah menjalankan bgm dari script lain
        private void PlayBGM()
        {
            bgmAudioSource.Play();
        }
        // fungsi yang disiapkan untuk perintah menjalankan sfx dari script lain
        public void PlaySFXBumper(Vector3 spawnPosition)
        {
            // berbeda dengan bgm, disini kita buat script untuk 
            // memunculkan prefabnya pada posisi sesuai dengan parameternya
            GameObject.Instantiate(sfxAudioSourceBumper, spawnPosition, Quaternion.identity);
        }
        
        public void PlaySFXSwitchon(Vector3 spawnPosition)
        {
            GameObject.Instantiate(sfxAudioSourceSwitchon, spawnPosition, Quaternion.identity);
        }
        public void PlaySFXSwitchoff(Vector3 spawnPosition)
        {
            GameObject.Instantiate(sfxAudioSourceSwitchoff, spawnPosition, Quaternion.identity);
        }
    }
}
