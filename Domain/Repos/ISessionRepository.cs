using Domain.dto;
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

		IEnumerable<OSession> GetSessionOf(int year, int month, NodeDTO n);
		IEnumerable<int> GetAllChildIdOf(NodeDTO n);
		SessionForNode ForNode(int parentNode);
    }
}
