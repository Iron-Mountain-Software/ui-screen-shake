using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace IronMountain.UIScreenShake
{
    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(RectTransform))]
    public class UIScreenShake : MonoBehaviour
    {
        public static event Action<float, float> OnGlobalShake;
        
        [SerializeField] private Vector2 defaultAnchorMin = Vector2.zero;
        [SerializeField] private Vector2 defaultAnchorMax = Vector2.one;
        [SerializeField] private Vector2 maximumShake = Vector2.zero;
        [SerializeField] private TimeScaleType timeScale = TimeScaleType.Unscaled;
        
        [Header("Cache")]
        private RectTransform _rectTransform;

        private RectTransform RectTransform
        {
            get
            {
                if (!_rectTransform) _rectTransform = GetComponent<RectTransform>();
                return _rectTransform;
            }
        }

        public static void GlobalShake(float percentMaximum, float seconds)
        {
            OnGlobalShake?.Invoke(percentMaximum, seconds);
        }

        private void Awake()
        {
            defaultAnchorMin = RectTransform.anchorMin;
            defaultAnchorMax = RectTransform.anchorMax;
        }

        private void OnEnable()
        {
            OnGlobalShake += Shake;
            Reset();
        }
        
        private void OnDisable()
        {
            OnGlobalShake -= Shake;
            Reset();
        }

        public void Reset()
        {
            StopAllCoroutines();
            RectTransform.anchorMin = defaultAnchorMin;
            RectTransform.anchorMax = defaultAnchorMax;
            RectTransform.offsetMin = Vector2.zero;
            RectTransform.offsetMax = Vector2.zero;
        }

        public void Shake(float percentMaximum, float seconds)
        {
            StopAllCoroutines();
            StartCoroutine(ShakeAnimation(percentMaximum, seconds));
        }

        private IEnumerator ShakeAnimation(float percentMaximum, float seconds)
        {
            for (float timer = 0f;
                timer < seconds;
                timer += timeScale == TimeScaleType.Scaled ? Time.deltaTime : Time.unscaledDeltaTime)
            {
                float progress = timer / seconds;
                Vector2 shake = percentMaximum * new Vector2(
                    Random.Range(-maximumShake.x, maximumShake.x),
                    Random.Range(-maximumShake.y, maximumShake.y));
                shake = Vector2.Lerp(shake, Vector2.zero, progress);
                RectTransform.anchorMin = defaultAnchorMin + shake;
                RectTransform.anchorMax = defaultAnchorMax + shake;
                RectTransform.offsetMin = Vector2.zero;
                RectTransform.offsetMax = Vector2.zero;
                yield return null;
            }
            Reset();
        }

        private void OnValidate()
        {
            Reset();
        }
    }
}
