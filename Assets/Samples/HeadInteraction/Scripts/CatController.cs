using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloInteractive.XR.HoloKit.Samples.HeadInteraction
{
    public class CatController : MonoBehaviour
    {
        [SerializeField]
        Transform m_CatNeck;

        Transform head;
        // Start is called before the first frame update
        void Start()
        {
            head = FindObjectOfType<HoloKitCameraManager>().CenterEyePose;
        }

        // Update is called once per frame
        void Update()
        {
            m_CatNeck.LookAt(head);

            //m_CatNeck.localEulerAngles += new Vector3(45f,0,0);
        }
    }
}

