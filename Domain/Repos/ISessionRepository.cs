using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repos
{
	public interface ISessionRepository
	{
		void Delete(OSession e);
		IEnumerable<OSession> GetOfDay(DateTime date);
		void Save(OSession e);
		int GetSecondsOfDay(DateTime dt, INode dir);

		//IEnumerable<INode> GetAllChildren(INode n);
		IEnumerable<OSession> GetSessionOf(int year, int month, INode n);
		IEnumerable<int> GetAllChildTaskIdOf(INode n);
	}
}
