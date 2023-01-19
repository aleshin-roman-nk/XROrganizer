using Domain.dto;
using Domain.Entities;
using Shared.UI.Interfaces.Enums;
using Shared.UI.Interfaces.EventArgsDefinition;
using System;
using TaskBank.Presenters.EventDefinition;

namespace TaskBank.Presenters
{
    public interface IOpenObjectManager
    {
        bool AnyWorkingWindow { get; }

        event EventHandler<NodeDTO> CreateSession;
        event EventHandler<NodeTextPage> DeleteNodeTextPage;
        event EventHandler<GetNodeEventArgs> GetNode;
        event EventHandler<GetSessionsEvenArgs> GetSessions;
        event EventHandler<int> OpenTasksCountChanged;
        event EventHandler<SaveNodeEventArgs> SaveNode;
        event EventHandler<OSession> SaveSession;
        event EventHandler<WorkingSessionPlayState> WorkingSessionPlayStateChanged;
        event EventHandler WorkingSessionWindowCompleted;
        event EventHandler WorkingSessionWindowOpen;

        void DefaultOpenNode(INode n);
        void OpenNodeById(int id);
        bool IsOpened(int inodeId);
        void OpenSession(OSession s);
        void OpenTask(FTask t);
        void SetWorkingSessionPlayState(WorkingSessionPlayState st);
        void TryRestoreSessionWindow();
    }
}