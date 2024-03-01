using UnityEngine;

namespace Script
{
    public class VFXManager : MonoBehaviour
    {
        public GameObject vfxSourceBumper;
        public GameObject vfxSourceSwitchon;
        public GameObject vfxSourceSwitchoff;

        public void PlayVFXBumper(Vector3 spawnPosition)
        {
            // spawn vfx pada posisi sesuai parameter
            GameObject.Instantiate(vfxSourceBumper, spawnPosition, Quaternion.identity);
        }
        public void PlayVFXSwitchon(Vector3 spawnPosition)
        {
            // spawn vfx pada posisi sesuai parameter
            GameObject.Instantiate(vfxSourceSwitchon, spawnPosition, Quaternion.identity);
        }
        public void PlayVFXSwitchoff(Vector3 spawnPosition)
        {
            // spawn vfx pada posisi sesuai parameter
            GameObject.Instantiate(vfxSourceSwitchoff, spawnPosition, Quaternion.identity);
        }
    }
}
