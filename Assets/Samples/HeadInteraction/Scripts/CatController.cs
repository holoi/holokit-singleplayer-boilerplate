using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloInteractive.XR.HoloKit.Samples.HeadInteraction
{
    public class CatController : MonoBehaviour
    {
        [SerializeField]
        Transform m_CatNeck;
        [SerializeField]
        Transform m_CatNeckWithOffset;

        Transform head;
        // Start is called before the first frame update
        void Start()
        {
            head = FindObjectOfType<HoloKitCameraManager>().CenterEyePose;
        }

        private void LateUpdate()
        {
            m_CatNeckWithOffset.LookAt(head);

            m_CatNeck.eulerAngles = m_CatNeckWithOffset.rotation.eulerAngles + new Vector3(60f,0,0);
        }
    }
}

