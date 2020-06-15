using System;

namespace FSMSharp
{
    public struct FsmSnapshot<T>
    {
        internal T CurrentState { get; private set; }
        internal float StateAge { get; private set; }

        internal FsmSnapshot(float age, T currentState)
        {
            CurrentState = currentState;
            StateAge = age;
        }
    }
}

