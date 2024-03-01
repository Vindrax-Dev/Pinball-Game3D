using System;
using System.Collections;
using UnityEngine;

namespace Script
{
    public class LauncherController : MonoBehaviour
    {

        public Collider bola; // referensi ke bola
        public Material offMaterial;
        public Material onMaterial;
        private Renderer _renderer;
        public float maxTimeHold; //lama waktu hold
        public float maxForce; //maximum forcenya/tekanan
        private bool _isHold; //state
            
        private void Start()
        {
            _isHold = false; //set false
            _renderer = GetComponent<Renderer>();
            _renderer.material = onMaterial;
        }

        // hanya dapat membaca input saat bersentuhan dengan bola saja
        private void OnCollisionStay(Collision collision)
        {
            _renderer.material = onMaterial;
            if (collision.collider == bola)
            {
                ReadInput(bola);
            }
        }

        // baca input
        private void ReadInput(Collider collider)
        {
            if (Input.GetKey(KeyCode.L) && !_isHold)
            {
                StartCoroutine(StartHold(collider)); //jalanin coroutinenya
                
            }
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private IEnumerator StartHold(Collider collider)
        {
            float f = 0.0f;
            float timeHold = 0.0f;
            _isHold = true; //set true
            _renderer.material = offMaterial;
            while (Input.GetKey(KeyCode.L))
            {
                    // hitung force menggunakan lerp
                f = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);
                
                yield return new WaitForEndOfFrame();
                timeHold += Time.deltaTime;
            }

            collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * f);
            _isHold = false;
        } 
    }
}

