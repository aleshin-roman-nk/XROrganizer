using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repos
{
	public interface ISessionRepository
	{
		void Delete(OSession e);
		IEnumerable<OSession> GetOfDay(DateTime date);
		void Update(OSession e);
		int GetSecondsOfDay(DateTime dt, INode dir);

		IEnumerable<OSession> GetSessionOf(int year, int month, INode n);
		IEnumerable<int> GetAllChildIdOf(INode n);
		//bool SessionExists(int ownerId, DateTime dt);

		//SessionForNode ForNode(INode n);
		SessionForNode ForNode(int parentNode);
    }
}
