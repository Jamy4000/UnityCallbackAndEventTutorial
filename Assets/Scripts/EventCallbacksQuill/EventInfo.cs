﻿using System;
using UnityEngine;

namespace EventCallbacks.Quill
{
    public abstract class EventSystem<T>
    {
        /*
         * The base Event,
         * might have some generic text
         * for doing Debug.Log?
         */

        public readonly string Description;

        public EventSystem(string description)
        {
            Description = description;
        }
        
        public delegate void EventListener(T info);
        public static event EventListener Listeners;

        protected void FireEvent(T info)
        {
            Listeners(info);
        }
    }

    public class DebugEventSystem : EventSystem<DebugEventSystem>
    {
        public DebugEventSystem(int verbosityLevel) : base("Debug event.")
        {
            VerbosityLevel = verbosityLevel;
            FireEvent(this);
        }

        public readonly int VerbosityLevel;
    }

    public class UnitDeathEventSystem : EventSystem<UnitDeathEventSystem>
    {
        public UnitDeathEventSystem(GameObject go) : base("Unit death event.")
        {
            UnitGO = go;
            FireEvent(this);
        }

        public readonly GameObject UnitGO;
        /*

        Info about cause of death, our killer, etc...

        Could be a struct, readonly, etc...

        */
    }
}