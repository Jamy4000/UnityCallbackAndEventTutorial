using System.Collections;
using UnityEngine;

namespace EventCallbacks
{
    /// <summary>
    /// This class is just an example on how to raise an event based on the EventCallbacks System.
    /// To use it, just put it on a GameObject in your scene. It will output a message every 1.5 second in the console.
    /// </summary>
    public class EventRaiserExample : MonoBehaviour
    {
        // Update is called once per frame
        void Start()
        {
            StartCoroutine(RaiserExampleCoroutine());
        }

        /// <summary>
        /// This coroutine just fire a new EventExample with random values every 1.5 seconds.
        /// </summary>
        /// <returns></returns>
        IEnumerator RaiserExampleCoroutine()
        {
            var vector3Param = new Vector3(Random.Range(0, 100), Random.Range(0, 100), Random.Range(0, 100));
            var floatParam = Random.Range(0, 100);

            // What you should do : 
            new EventExample(vector3Param, floatParam);

            // What you shouldn't do : 
            // var test = new EventExample(vector3Param, floatParam);
            // test.FireEvent(test);

            yield return new WaitForSeconds(1.5f);

            StartCoroutine(RaiserExampleCoroutine());
        }
    }
}