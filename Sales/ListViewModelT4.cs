/**************************************************
Warning!
This code is automatically created.
If you change this file manually, you may lose the edited contents.
**************************************************/


using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;

namespace Sales
{
	partial class ListView : ModelBase
	{
			private ICommand _RenewCommand;
		public ICommand RenewCommand
		{
			get
			{
				if (_RenewCommand == null)
				{

					_RenewCommand = new RelayCommand(ExecuteRenewCommand);

				}
				return _RenewCommand;
			}
		}
			private ICommand _AppendCommand;
		public ICommand AppendCommand
		{
			get
			{
				if (_AppendCommand == null)
				{

					_AppendCommand = new RelayCommand(ExecuteAppendCommand);

				}
				return _AppendCommand;
			}
		}
			private ICommand _UpdateCommand;
		public ICommand UpdateCommand
		{
			get
			{
				if (_UpdateCommand == null)
				{

					_UpdateCommand = new RelayCommand(ExecuteUpdateCommand, CanExecuteUpdateCommand);

				}
				return _UpdateCommand;
			}
		}
			private ICommand _DeleteCommand;
		public ICommand DeleteCommand
		{
			get
			{
				if (_DeleteCommand == null)
				{

					_DeleteCommand = new RelayCommand(ExecuteDeleteCommand, CanExecuteDeleteCommand);

				}
				return _DeleteCommand;
			}
		}
			private ICommand _CloseCommand;
		public ICommand CloseCommand
		{
			get
			{
				if (_CloseCommand == null)
				{

					_CloseCommand = new RelayCommand(ExecuteCloseCommand);

				}
				return _CloseCommand;
			}
		}
		}
}
