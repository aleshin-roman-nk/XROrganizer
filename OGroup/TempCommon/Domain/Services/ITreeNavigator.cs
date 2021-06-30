using Domain.Entities;
using System;

namespace Domain.Services
{
	public interface ITreeNavigator
	{
		string CurrentNodeFullName { get; }
		INode HighlightedNode { get; }

		event EventHandler OwnerChanged;
		INode CurrentOwner { get; }
		void Enter(INode n);
		void JumpBack();
		void Update();
	}
}