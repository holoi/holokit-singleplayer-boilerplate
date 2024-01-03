// SPDX-FileCopyrightText: Copyright 2023 Holo Interactive <dev@holoi.com>
// SPDX-FileContributor: Yuchen Zhang <yuchenz27@outlook.com>
// SPDX-License-Identifier: MIT

using UnityEngine;
using HoloInteractive.XR.HoloKit.iOS;

namespace HoloInteractive.XR.HoloKit.Samples.ResetWorldOrigin
{
    public class WorldOriginResetter : MonoBehaviour
    {
        private HoloKitARKitNativeProvider m_ARKitNativeProvider;

        private HoloKitCameraManager m_HoloKitCameraManager;

        private void Start()
        {
            m_ARKitNativeProvider = new();

            m_HoloKitCameraManager = FindFirstObjectByType<HoloKitCameraManager>();
        }

        private void OnDestroy()
        {
            m_ARKitNativeProvider.Dispose();
        }

        // Reset origin to the current center eye position
        public void ResetOrigin()
        {
            Vector3 position = m_HoloKitCameraManager.CenterEyePose.position;
            Quaternion rawRotation = m_HoloKitCameraManager.CenterEyePose.rotation;
            Quaternion rotation = Quaternion.Euler(0f, rawRotation.eulerAngles.y, 0f);
            m_ARKitNativeProvider.ResetOrigin(position, rotation);
        }
    }
}
