using Domain.Entities;
using Shared.UI.Interfaces;
using Shared.UI.Interfaces.Enums;
using Shared.UI.UserControls;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaskBank.Forms;
using TaskBank.Presenters.EventDefinition;
using TaskBank.Properties;
using TaskBank.Views;

namespace TaskBank
{
	public partial class MainForm : Form, IMainView
	{
		public INodesView NodesView => nodesViewUC1;
		public Point LocationPoint => Location;
		IInputBox _inputBox;

		public int width => Width;

		public int height => Height;

		int _openedTaskCount = 0;
		int _nodesInClipboard = 0;
		public int OpenedTasksCout
		{
			get
			{
				return _openedTaskCount;
			}
			set
			{
				_openedTaskCount = value;
				txtOpenedTaskCount.Text = _openedTaskCount.ToString();
			}
		}

		public int ClipboardNodesCount
		{
			get
			{
				return _nodesInClipboard;
			}
			set
			{
				_nodesInClipboard = value;
				setBufferState(_nodesInClipboard);
			}
		}

        public bool SessionState
        {
            get
            {
				return true;
            }
            set
            {
				if (value)
                {
					btnSessionState.BackgroundImage = Resources.sessionwork;
					pictureSessionAnimation.Visible = true;
					btnPlayStopSessionWorking.Visible = true;
					pictureSessionAnimation.Image = Resources.sessionStoped;
					SessionWorkingState = WorkingSessionPlayState.stop;
				}
                else
                {
					btnSessionState.BackgroundImage = Resources.nosession;
					pictureSessionAnimation.Visible = false;
					btnPlayStopSessionWorking.Visible = false;
					timerSessionAnim.Enabled = false;
					timerSessionAnim.Stop();
				} 
			}
        }

		WorkingSessionPlayState _sessionWorkingState;

		Image[] animFramesImg = new Image[] { Resources.sessAnim01, Resources.sessAnim02 };

		public WorkingSessionPlayState SessionWorkingState
        {
            get
            {
				return _sessionWorkingState;
			}
            set
            {
				_sessionWorkingState = value;

				if (_sessionWorkingState == WorkingSessionPlayState.stop)
					_stopSessionAnimation();
				else
					_playSessionAnimation();
			}
        }

		private void _playSessionAnimation()
        {
			timerSessionAnim.Enabled = true;
			timerSessionAnim.Start();
			btnPlayStopSessionWorking.BackgroundImage = Resources.stopSession;
        }

		private void _stopSessionAnimation()
		{
			timerSessionAnim.Enabled = false;
			timerSessionAnim.Stop();
			pictureSessionAnimation.Image = Resources.sessionStoped;
			btnPlayStopSessionWorking.BackgroundImage = Resources.playSession;
		}

		int _currentFrame = 0;
		private void nextFrameSessionAnimation()
        {
			if (_currentFrame < animFramesImg.Count() - 1)
				_currentFrame++;
			else
				_currentFrame = 0;

			pictureSessionAnimation.Image = animFramesImg[_currentFrame];
		}

		public MainForm(IInputBox dlg)
		{
			InitializeComponent();
			_inputBox = dlg;

			SessionWorkingState = WorkingSessionPlayState.stop;
			setBufferState(0);
		}

		public event EventHandler StartDesriptionForm;
		public event EventHandler DeleteNode;
		public event EventHandler CreateNode;
		public event EventHandler RenameNode;
		public event EventHandler StartCurrentBuffer;
		public event EventHandler StartSessionCollector;
		public event EventHandler StartWindowCompletedNodes;
		public event EventHandler CreateSession;
        public event EventHandler RestoreWorkingSessionWindow;
        public event EventHandler PutTaskToBuffer;
        public event EventHandler StartStatisticWindow;
        public event EventHandler<ApplicationClosingEventArgs> ApplicationClosing;
        public event EventHandler<WorkingSessionPlayState> WorkingSessionPlayStateChanged;
        public event EventHandler OpenNode;

        void setBufferState(int items_cnt)
		{
			if (items_cnt == 0)
				txtBufferState.BackColor = Color.Gray;
			else
				txtBufferState.BackColor = Color.Yellow;

			txtBufferState.Text = $"{items_cnt}";
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				DeleteNode?.Invoke(this, EventArgs.Empty);
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.F7)
			{
				CreateNode?.Invoke(this, EventArgs.Empty);
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.F2)
			{
				RenameNode?.Invoke(this, EventArgs.Empty);
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.F3)
            {
				OpenNode?.Invoke(this, EventArgs.Empty);
				e.Handled= true;
            }
		}

		private void btntsCreate_Click(object sender, EventArgs e)
		{
			CreateNode?.Invoke(this, EventArgs.Empty);
		}

		private void btntsRename_Click(object sender, EventArgs e)
		{
			RenameNode?.Invoke(this, EventArgs.Empty);
		}

		private void btntsDelete_Click(object sender, EventArgs e)
		{
			DeleteNode?.Invoke(this, EventArgs.Empty);
		}

		private void btntsTimeTag_Click(object sender, EventArgs e)
		{
			var res = $">>> {DateTime.Now.ToString("dd-MM-yyyy HH:mm")}";
			try
			{
				Clipboard.Clear();
				Clipboard.SetText(res);
			}
			catch (Exception)
			{

			}
		}

		private void btntsTaskTag_Click(object sender, EventArgs e)
		{
			var i = NodesView.SelectedNodes.SingleOrDefault();

			if (i == null) return;

			string res = $"{i.path}#{i.id}";

			try
			{
				Clipboard.Clear();
				Clipboard.SetText(res);
			}
			catch (Exception)
			{

			}
		}

		private void btntsCreateSession_Click(object sender, EventArgs e)
		{
			CreateSession?.Invoke(this, EventArgs.Empty);
		}

        private void stbtnPutTaskToBuffer_Click(object sender, EventArgs e)
        {
			PutTaskToBuffer?.Invoke(this, EventArgs.Empty);
        }

        private void tsbtnShowCompleted_Click(object sender, EventArgs e)
        {
			StartWindowCompletedNodes?.Invoke(this, EventArgs.Empty);
		}

        private void tsbtnShowBuffer_Click(object sender, EventArgs e)
        {
			StartCurrentBuffer?.Invoke(this, EventArgs.Empty);
		}

        private void tsbtnSessionCollector_Click(object sender, EventArgs e)
        {
			StartSessionCollector?.Invoke(this, EventArgs.Empty);
		}

        private void stbtnViewEditDescription_Click(object sender, EventArgs e)
        {
			StartDesriptionForm?.Invoke(this, EventArgs.Empty);
		}

        private void btnSessionState_Click(object sender, EventArgs e)
        {
			RestoreWorkingSessionWindow?.Invoke(this, EventArgs.Empty);
		}

        private void tsbtnShowStatistic_Click(object sender, EventArgs e)
        {
			StartStatisticWindow?.Invoke(this, EventArgs.Empty);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
			var arg = new ApplicationClosingEventArgs();

			ApplicationClosing?.Invoke(this, arg);

			e.Cancel = arg.AnyWorkingWindows == true;

			if(arg.AnyWorkingWindows == true)
            {
				_inputBox.ShowMessage("There are working windows");
			}
		}

        private void timerSessionAnim_Tick(object sender, EventArgs e)
        {
			nextFrameSessionAnimation();
		}

        private void btnPlayStopSessionWorking_Click(object sender, EventArgs e)
        {
			if (SessionWorkingState == WorkingSessionPlayState.stop)
				WorkingSessionPlayStateChanged?.Invoke(this, WorkingSessionPlayState.run);
			else
				WorkingSessionPlayStateChanged?.Invoke(this, WorkingSessionPlayState.stop);
		}
    }
}