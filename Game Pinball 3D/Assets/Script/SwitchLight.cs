using System.Collections;
using UnityEngine;

namespace Script
{
    public class SwitchLight : MonoBehaviour
    {
    
        private enum SwitchState
        {
            Off,
            On,
            Blink
        }

        public Collider bola;
        public Material offMaterial;
        public Material onMaterial;
        public Audio audioManager;
        private SwitchState _state;
        private Renderer _renderer;
        public VFXManager VFXManager;
        public ScoreManage scoreManager;
        private void Start()
        {
            _renderer = GetComponent<Renderer>();

            Set(false);

            StartCoroutine(BlinkTimerStart(5));
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other == bola)
            {
                Toggle(bola);
                scoreManager.AddScore(10);
            }
        }

        private void Set(bool active)
        {
            if (active == true)
            {
                _state = SwitchState.On;
                _renderer.material = onMaterial;
                StopAllCoroutines();
            }
            else
            {
                _state = SwitchState.Off;
                _renderer.material = offMaterial;
                StartCoroutine(BlinkTimerStart(5));
            }
        }

        private void Toggle(Collider ball)
        {
            var position = ball.transform.position;
            
            if (_state == SwitchState.On)
            {
                Set(false);
                audioManager.PlaySFXSwitchon(position);//sfx
                VFXManager.PlayVFXSwitchon(position);//vfx 
            }
            else
            {
                Set(true);
                audioManager.PlaySFXSwitchoff(position);//sfx
                VFXManager.PlayVFXSwitchoff(position);//vfx 
            }
        }

        private IEnumerator Blink(int times)
        {
            _state = SwitchState.Blink;

            for (int i = 0; i < times; i++)
            {
                _renderer.material = onMaterial;
                yield return new WaitForSeconds(0.5f);
                _renderer.material = offMaterial;
                yield return new WaitForSeconds(0.5f);
            }

            _state = SwitchState.Off;

            StartCoroutine(BlinkTimerStart(5));
        }

        private IEnumerator BlinkTimerStart(float time)
        {
            yield return new WaitForSeconds(time);
            StartCoroutine(Blink(2));
        }
    }
}

