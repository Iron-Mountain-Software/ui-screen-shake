using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace IronMountain.UIScreenShake
{
    [RequireComponent(typeof(Button))]
    public class UIScreenShakeButton : MonoBehaviour
    {
        [SerializeField] [Range(0, 1)] private float percentMaximum;
        [SerializeField] private float seconds;
        [SerializeField] private bool shakeGlobally = true;
        [SerializeField] private List<UIScreenShake> componentsToShake = new ();
        
        [Header("Cache")]
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            if (_button) _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            if (_button) _button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            if (shakeGlobally) UIScreenShake.GlobalShake(percentMaximum, seconds);
            else
            {
                foreach (UIScreenShake component in componentsToShake)
                {
                    if (!component) continue;
                    component.Shake(percentMaximum, seconds);
                }
            }
        }

        private void OnValidate()
        {
            if (shakeGlobally) componentsToShake.Clear();
        }
    }
}