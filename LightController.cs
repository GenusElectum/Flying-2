using System.Collections;
using UnityEditor;
using UnityEngine;
namespace lightControl

{
    public class LightController : MonoBehaviour
    {
        public Light myLight;
        public float duration = 1.0f; // duration of the color change

        public void ChangeC()
        {

            StartCoroutine(ChangeLightColor());

        }

        IEnumerator ChangeLightColor()
        {
            while (true)
            {
                // change color to blue over the duration
                float t = 0;
                Color startColor = myLight.color;
                while (t < duration)
                {
                    myLight.color = Color.Lerp(startColor, Color.blue, t / duration);
                    t += Time.deltaTime;
                    yield return null;
                }

                // change color to orange over the duration
                t = 0;
                startColor = myLight.color;
                while (t < duration)
                {
                    myLight.color = Color.Lerp(startColor, new Color(1, 0.64f, 0), t / duration); // RGB for orange is (1, 0.64, 0)
                    t += Time.deltaTime;
                    yield return null;
                }
            }
        }
    }
}
