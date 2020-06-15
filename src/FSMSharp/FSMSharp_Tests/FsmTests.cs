using System;
using FSMSharp;
using NUnit.Framework;

namespace FSMSharp_Tests
{
	[TestFixture]
	public class FsmTests
	{
		public class RefContainer<T>
		{
			public T Value;
		}


		[Test]
		public void SimpleExpiration()
		{
			FSM<int> F = new FSM<int>("");
			F.Add(1)
				.Expires(5)
				.GoesTo(2);
			F.Add(2);

			F.CurrentState = 1;

			F.Process(0f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(1f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(2f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(3f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(4f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(5.1f);
			Assert.AreEqual(2, F.CurrentState);
		}

		[Test]
		public void OnEnterAndOnLeaveHandlers()
		{
			FSM<int> F = new FSM<int>("");
			RefContainer<int> x = new RefContainer<int>();

			F.Add(1)
				.Expires(5)
				.GoesTo(2)
				.OnLeave(() => x.Value += 15);
			F.Add(2)
				.OnEnter(() => x.Value *= 2);

			F.CurrentState = 1;
			F.Process(0f);

			F.Process(5.1f);
			Assert.AreEqual(30, x.Value);
			F.Process(5.2f);
			Assert.AreEqual(30, x.Value);
			F.Process(5.3f);
			Assert.AreEqual(30, x.Value);
			F.Process(5.4f);
			Assert.AreEqual(30, x.Value);
		}

		[Test]
		public void StateIsLeavedImmediatelyOnSuddenExpiration()
		{
			FSM<int> F = new FSM<int>("");
			RefContainer<int> x = new RefContainer<int>();

			F.Add(1)
				.Expires(1)
				.GoesTo(2);
			F.Add(2)
				.GoesTo(3)
				.Expires(1)
				.OnLeave(() => x.Value += 15);
			F.Add(3)
				.OnEnter(() => x.Value *= 2);

			F.CurrentState = 1;
			F.Process(0f);

			F.Process(1.5f);
			F.Process(3f);

			Assert.AreEqual(3, F.CurrentState);
			Assert.AreEqual(30, x.Value);
		}

		[Test]
		public void SnapshotRestore()
		{
			FSM<int> F = new FSM<int>("");
			F.Add(1)
				.Expires(5)
				.GoesTo(2);
			F.Add(2);

			F.CurrentState = 1;

			F.Process(0f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(1f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(2f);
			Assert.AreEqual(1, F.CurrentState);

			var snap = F.SaveSnapshot();

			F.Process(3f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(4f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(5.1f);
			Assert.AreEqual(2, F.CurrentState);

			F.RestoreSnapshot(snap, false);
			Assert.AreEqual(1, F.CurrentState);

			F.Process(3f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(4f);
			Assert.AreEqual(1, F.CurrentState);
			F.Process(5.1f);
			Assert.AreEqual(2, F.CurrentState);

		}
	}
}
