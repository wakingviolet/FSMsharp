namespace FSMSharp
{
    /// <summary>
    /// Data regarding the current running state. Used as an argument to callbacks.
    /// </summary>
    public struct FsmStateData<T>
    {
        /// <summary>
        /// Gets the finit state machine to which this data is coming from.
        /// </summary>
        public FSM<T> Machine { get; internal set; }
        /// <summary>
        /// Gets the behaviour.
        /// </summary>
        public FsmStateBehaviour<T> Behaviour { get; internal set; }
        /// <summary>
        /// Gets the current state.
        /// </summary>
        public T State { get; internal set; }
        /// <summary>
        /// Gets the state "age"
        /// </summary>
        public float StateTime { get; internal set; }
        /// <summary>
        /// Gets the absolute time.
        /// </summary>
        public float AbsoluteTime { get; internal set; }
        /// <summary>
        /// Gets the state progress (available only if an expiration time has been set on the behaviour)
        /// </summary>
        public float StateProgress { get; internal set; }

        /// <summary>
        /// Shortcut for Machine.Next();
        /// </summary>
        public void Next()
        {
            Machine.Next();
        }
    }
}
