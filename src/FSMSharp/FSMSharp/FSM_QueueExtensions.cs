namespace FSMSharp
{
    /// <summary>
    /// Extension methods to easily use the FSM as a queueing of consecutive states.
    /// </summary>
    public static class FSM_QueueExtensions
    {
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<int> Queue(this FSM<int> fsm)
        {
            return fsm.Add(fsm.Count)
                .GoesTo(fsm.Count);
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<long> Queue(this FSM<long> fsm)
        {
            return fsm.Add(fsm.Count)
                .GoesTo(fsm.Count);
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<uint> Queue(this FSM<uint> fsm)
        {
            return fsm.Add((uint)fsm.Count)
                .GoesTo((uint)(fsm.Count));
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<ulong> Queue(this FSM<ulong> fsm)
        {
            return fsm.Add((ulong)fsm.Count)
                .GoesTo((ulong)(fsm.Count));
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<short> Queue(this FSM<short> fsm)
        {
            return fsm.Add((short)fsm.Count)
                .GoesTo((short)(fsm.Count));
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<ushort> Queue(this FSM<ushort> fsm)
        {
            return fsm.Add((ushort)fsm.Count)
                .GoesTo((ushort)(fsm.Count));
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<byte> Queue(this FSM<byte> fsm)
        {
            return fsm.Add((byte)fsm.Count)
                .GoesTo((byte)(fsm.Count));
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<sbyte> Queue(this FSM<sbyte> fsm)
        {
            return fsm.Add((sbyte)fsm.Count)
                .GoesTo((sbyte)(fsm.Count + 1));
        }
        /// <summary>
        /// Queues a new state to specified FSM.
        /// </summary>
        /// <param name="fsm">The FSM.</param>
        /// <returns>The newly created state.</returns>
        public static FsmStateBehaviour<char> Queue(this FSM<char> fsm)
        {
            return fsm.Add((char)fsm.Count)
                .GoesTo((char)(fsm.Count + 1));
        }
    }
}
