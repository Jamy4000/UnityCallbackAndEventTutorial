using UnityEngine;

namespace EventCallbacks
{
    /// <summary>
    /// This class is just an example on how to add listeners to an event based on the EventCallbacks System.
    /// To use it, just put it on a GameObject in your Scene. You could technically add Listeners without the class behing a Monobehaviour.
    /// </summary>
    public class EventListenerExample : MonoBehaviour
    {
        // Use this for initialization
        void Awake()
        {
            // We register the listener on awake using a secured way
            EventExample.Listeners += OnEventFired;

            // Here's another way to register the events, less secure :
            // EventExample.RegisterListener(OnEventFired);
        }

        void OnDestroy()
        {
            // We unregister the listener on Destroy using a secured way
            EventExample.Listeners -= OnEventFired;

            // Here's another way to unregister the events, less secure :
            // EventExample.UnregisterListener(OnEventFired);
        }

        /// <summary>
        /// Method called when the event is fired
        /// </summary>
        /// <param name="eventExample">The example event that is being raised. Allow us to access its datas.</param>
        void OnEventFired(EventExample eventExample)
        {
            Debug.Log("The event was fired with the following description :\n" + eventExample.Description);
            Debug.Log("The float linked to it is :\n" + eventExample.ExampleFloat);
            Debug.Log("The Vector3 linked to it is :\n" + eventExample.ExampleVector3);
        }
    }
}