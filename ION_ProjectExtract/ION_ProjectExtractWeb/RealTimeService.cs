using System;
namespace ION_ProjectExtractWeb
{
	public class RealTimeService
	{
		private string _uiMessage;

		public string uiMessage
        {
			get { return _uiMessage;  }
			set
			{
                _uiMessage = value;
                UpdateEvent?.Invoke();
            }
		}

        private int _b;

        public int b
        {
            get { return _b; }
            set
			{
				_b = value;
				UpdateEvent?.Invoke();
			}
        }

		public event Func<Task> UpdateEvent;
    }
}

