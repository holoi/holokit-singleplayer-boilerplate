// SPDX-FileCopyrightText: Copyright 2023 Holo Interactive <dev@holoi.com>
// SPDX-FileContributor: Yuchen Zhang <yuchen@holoi.com>
// SPDX-License-Identifier: MIT

using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace HoloInteractive.XR.HoloKit.Samples.GazeInteraction
{
    public class GazeAndDwellButtonController : MonoBehaviour, IGazeRaycastInteractable
    {
        [SerializeField] private Transform m_ActiveBG;

        [SerializeField] private float m_MaxLoad = 1f;

        private bool isSelected = false;

        private float load = 0;

        private float percentageLoad = 0;

        private void Start()
        {
            UpdatePercentageState();
        }

        private void Update()
        {
            if (!isSelected && load > 0f)
            {
                load -= Time.fixedTime;
                if (load < 0f)
                    load = 0f;
                UpdatePercentageState();
            }

            if(isSelected)
            {
                if (percentageLoad == 1)
                {
                    load = 0;
                    UpdatePercentageState();
                }
            }
        }

        private void UpdatePercentageState()
        {
            percentageLoad = load / m_MaxLoad;
            m_ActiveBG.localScale = new Vector3(percentageLoad, 1,1);
        }

        public void OnSelectionEntered()
        {
            isSelected = true;
        }

        public void OnSelectionExited()
        {
            isSelected = false;
        }

        public void OnSelected(float deltaTime)
        {
            load += deltaTime;
            if (load > m_MaxLoad)
            {
                load = m_MaxLoad;
            }
            UpdatePercentageState();
        }
    }
}
