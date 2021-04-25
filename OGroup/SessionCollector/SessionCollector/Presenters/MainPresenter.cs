using SessionCollector.BL;
using SessionCollector.BL.Entities;
using SessionCollector.BL.Services;
using SessionCollector.Tools;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector
{
	public class MainPresenter
	{
		IMainView _view;
		ISessionView _sessionview;

		IMainRepository _mainRepository;

		Services _services;

		public MainPresenter(IMainView v, ISessionView sess_view, IMainRepository r, Services s)
		{
			_mainRepository = r;
			_view = v;
			_sessionview = sess_view;
			_services = s;

			_view.CommandCreateSession += _view_CommandCreateSession;
			_view.CommandSaveDayImage += _view_CommandSaveDayImage;
			_view.CommandDateChanged += _view_CommandDateChanged;
			_view.CommandOrderAndAlign += _view_CommandOrderAndAlign;
			_view.CommandWorkSession += _view_CommandWorkSession;

			//_view.DisplaySessions(_mainRepository.Sessions.Get());
		}

		private void _view_CommandWorkSession(object sender, OSession e)
		{
			var res = _sessionview.Go(e.Clone());

			if (res.Accept)
			{
				e.Accept(res.Data);

				_mainRepository.Sessions.Save(e);

				displaySessions(_view.CurrentDateTime);
			}
		}

		private void displaySessions(DateTime d)
		{
			var items = _mainRepository.Sessions.GetByDay(d);
			items = _services.Sessions.SortAndAlign(items);
			_view.DisplaySessions(items, _services.Sessions.GetAllocatedHours(items));

			//_view.DisplaySessions(items);

			//var items = _mainRepository.Sessions.GetByDay(d);
			//_view.DisplaySessions(items, _services.SessionSortService.GetAllocatedHours(items));
		}

		private void _view_CommandOrderAndAlign(object sender, DateTime e)
		{
			//var items = _mainRepository.Sessions.GetByDay(e);
			//items = _services.Sessions.SortAndAlign(items);
			//_view.DisplaySessions(items);

			displaySessions(e);
		}

		private void _view_CommandDateChanged(object sender, DateTime e)
		{
			displaySessions(e);

			//_view.DisplaySessions(_mainRepository.Sessions.GetByDay(e));
		}

		private void _view_CommandSaveDayImage(object sender, EventArgs e)
		{
			_mainRepository.Save();
		}

		private void _view_CommandCreateSession(object sender, DateTime e)
		{
			OSession session = new OSession();

			session.PlanStart = e;
			session.PlanHours = 1.0m;

			var res = _sessionview.Go(session);

			if (res.Accept)
			{
				_mainRepository.Sessions.Save(res.Data);

				displaySessions(e);

				//_view.DisplaySessions(_mainRepository.Sessions.GetByDay(e));
			}
		}
	}
}
