using Domain.Entities;
using Domain.Repos;
using System;

namespace Domain.Services
{
	public interface IDirectoriesService : IObservableCollection
	{
		ITreeNavigator Navigator { get; }
		void Attach(INode n);
		void Create(string name, DateTime d);
		void Update();
		void Save(Dir d);
		void Delete(Dir d);
		bool HasChildren(Dir d);
	}
}