// SPDX-FileCopyrightText: Copyright 2023 Holo Interactive <dev@holoi.com>
// SPDX-FileContributor: Yuchen Zhang <yuchen@holoi.com>
// SPDX-License-Identifier: MIT

using UnityEngine;
using HoloInteractive.XR.HoloKit.iOS;

namespace HoloInteractive.XR.HoloKit.Samples.GazeGestureInteraction
{
    public class ButtonInteractableController : MonoBehaviour, IGazeGestureInteractable
    {
        // Hover starts
        public void OnSelectionEntered()
        {

        }

        // Hover ends
        public void OnSelectionExited()
        {

        }

        public void OnSelected(float deltaTime)
        {

        }

        // Pinched
        public void OnGestureSelected()
        {

        }
    }
}
