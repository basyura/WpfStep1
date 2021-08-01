using System;
using System.ComponentModel;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStep1.Commands
{
    public abstract class CommandBase : BindableBase, ICommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vm"></param>
        public CommandBase(MainWindowViewModel vm)
        {
            ViewModel = vm;
        }
        /// <summary></summary>
        protected  MainWindowViewModel ViewModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual bool CanExecute
        {
            get
            {
                return true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public abstract void Execute();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        void ICommand.Execute(object parameter)
        {
            Execute();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute;
        }
        /// <summary>
        /// 
        /// </summary>
        event EventHandler ICommand.CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            RaisePropertyChanged("CanExecute");
        }
    }
}
