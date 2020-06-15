using System;
using System.Collections.Generic;

namespace FSMSharp
{
    /// <summary>
    /// Defines the behaviour of a state of a finit state machine
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class FsmStateBehaviour<T>
    {
        private List<Action<FsmStateData<T>>> m_ProcessCallbacks = new List<Action<FsmStateData<T>>>();
        private List<Action> m_EnterCallbacks = new List<Action>();
        private List<Action> m_LeaveCallbacks = new List<Action>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FsmStateBehaviour{T}"/> class.
        /// </summary>
        /// <param name="state">The state.</param>
        internal FsmStateBehaviour(T state)
        {
            State = state;
        }

        /// <summary>
        /// Gets the state associated with this behaviour
        /// </summary>
        public T State { get; private set; }

        /// <summary>
        /// Gets the time duration of the state (if any)
        /// </summary>
        public float? Duration { get; private set; }

        /// <summary>
        /// Gets the function which will be used to select the next state when this expires or Next() gets called.
        /// </summary>
        public Func<T> NextStateSelector { get; private set; }

        /// <summary>
        /// Sets a callback which will be called when the FSM enters in this state
        /// </summary>
        public FsmStateBehaviour<T> OnEnter(Action callback)
        {
            m_EnterCallbacks.Add(callback);
            return this;
        }

        /// <summary>
        /// Sets a callback which will be called when the FSM leaves this state
        /// </summary>
        public FsmStateBehaviour<T> OnLeave(Action callback)
        {
            m_LeaveCallbacks.Add(callback);
            return this;
        }

        /// <summary>
        /// Sets a callback which will be called everytime Process is called on the FSM, when this state is active
        /// </summary>
        public FsmStateBehaviour<T> Calls(Action<FsmStateData<T>> callback)
        {
            m_ProcessCallbacks.Add(callback);
            return this;
        }

        /// <summary>
        /// Sets the state to automatically expire after the given time (in seconds)
        /// </summary>
        public FsmStateBehaviour<T> Expires(float duration)
        {
            Duration = duration;
            return this;
        }

        /// <summary>
        /// Sets the state to which the FSM goes when the duration of this expires, or when Next() gets called on the FSM
        /// </summary>
        /// <param name="state">The state.</param>
        public FsmStateBehaviour<T> GoesTo(T state)
        {
            NextStateSelector = () => state;
            return this;
        }

        /// <summary>
        /// Sets a function which selects the state to which the FSM goes when the duration of this expires, or when Next() gets called on the FSM
        /// </summary>
        /// <param name="stateSelector">The state selector function.</param>
        public FsmStateBehaviour<T> GoesTo(Func<T> stateSelector)
        {
            NextStateSelector = stateSelector;
            return this;
        }


        /// <summary>
        /// Calls the process callback
        /// </summary>
        internal void Trigger(FsmStateData<T> data)
        {
            for (int i = 0, len = m_ProcessCallbacks.Count; i < len; i++)
                m_ProcessCallbacks[i](data);
        }

        /// <summary>
        /// Calls the onenter callback
        /// </summary>
        internal void TriggerEnter()
        {
            for (int i = 0, len = m_EnterCallbacks.Count; i < len; i++)
                m_EnterCallbacks[i]();
        }

        /// <summary>
        /// Calls the onleave callback
        /// </summary>
        internal void TriggerLeave()
        {
            for (int i = 0, len = m_LeaveCallbacks.Count; i < len; i++)
                m_LeaveCallbacks[i]();
        }
    }
}
