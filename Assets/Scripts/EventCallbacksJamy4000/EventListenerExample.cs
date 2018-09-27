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
        void Start()
        {
            // We register the listener on start
            EventExample.RegisterListener(OnEventFired);
        }

        void OnDisable()
        {
            // We unregister the listener on disable
            EventExample.UnregisterListener(OnEventFired);
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