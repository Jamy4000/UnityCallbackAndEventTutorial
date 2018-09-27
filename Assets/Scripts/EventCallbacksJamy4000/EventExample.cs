using UnityEngine;

namespace EventCallbacks
{
    /// <summary>
    /// An example class extending the Event class. This version is firing the event directly from the constructor,
    /// but you can as well make a reference to your event and call FireEvent later on.
    /// </summary>
    public class EventExample : Event<EventExample>
    {
        public readonly Vector3 ExampleVector3;
        public readonly float ExampleFloat;

        /// <summary>
        /// Constructor example for this event. As you can see, we inject the Description of the Event by calling
        /// base("") at the end of the constructor.
        /// </summary>
        /// <param name="vector3Param">The vector3 to inject in ExampleVector3</param>
        /// <param name="floatParam">The float to inject in ExampleFloat</param>
        public EventExample(Vector3 vector3Param, float floatParam) : base("This is just an example event.")
        {
            // We inject the parameters in the variables of the event
            ExampleVector3 = vector3Param;
            ExampleFloat = floatParam;

            // We fire the event
            FireEvent(this);
        }
    }
}