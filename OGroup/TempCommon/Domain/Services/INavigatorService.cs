using Domain.Entities;
using Domain.Repos;

namespace Domain.Services
{
	public interface INavigatorService : IObservableCollection
	{
		INodeNavigator Navigator { get; }
		void Attach(INode n);
		void Update();
	}
}