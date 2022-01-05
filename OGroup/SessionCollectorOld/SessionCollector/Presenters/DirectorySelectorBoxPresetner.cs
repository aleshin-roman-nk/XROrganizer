using mvp_base;
using SessionCollector.BL.Entities;
using SessionCollector.BL.Services;
using SessionCollector.Forms;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.Presenters
{
	public class DirectorySelectorBoxPresetner: IDirectorySelectorBoxPresenter
	{
		IDirectoriesView _view;
		IDirectoriesService _service;

		public DirectorySelectorBoxPresetner(IDirectoriesView dir_view, IDirectoriesService dir_service)
		{
			_view = dir_view;
			_service = dir_service;

			_view.CreateDirectory += _view_CreateDirectory;
			_view.DeleteDirectory += _view_DeleteDirectory;
			_view.RenameDirectory += _view_RenameDirectory;
		}

		private void _view_RenameDirectory(object sender, INode e)
		{
			throw new NotImplementedException();
		}

		private void _view_DeleteDirectory(object sender, INode e)
		{
			_service.Repo.Delete(e);
			_view.SetNodes(_service.Repo.Get());
		}

		private void _view_CreateDirectory(object sender, EventArgs e)
		{
			InputDataDialog inputData = new InputDataDialog();

			if (inputData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ODirectory d = new ODirectory { Name = inputData.InputText };

				_service.Repo.Save(d);
				_view.SetNodes(_service.Repo.Get());
			}
		}

		public ViewResponse<INode> Go(INode selectedNode = null)
		{
			_view.SetNodes(_service.Repo.Get(), selectedNode);
			return _view.Go();
		}
	}
}
