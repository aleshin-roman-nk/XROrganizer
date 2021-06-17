using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
	public interface IObservableCollection<TNode>
		where TNode: INode
	{
		event EventHandler CollectionChanged;
		IEnumerable<TNode> Items { get; }
	}

	public interface IObservableCollection
	{
		event EventHandler CollectionChanged;
		IEnumerable<INode> Items { get; }
	}
}