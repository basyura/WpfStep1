using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfStep1.Commands;
using WpfStep1.Models;

namespace WpfStep1
{
    public class MainWindowViewModel : BindableBase
    {
        private User _User;
        public User User 
        {
            get { return _User; }
            set { SetProperty(ref _User, value); }
        }
        /// <summary></summary>
        public ICommand InitializeCommand { get; set; }
        /// <summary></summary>
        public ICommand ChangeUserCommand { get; set; }
        /// <summary></summary>
        public CommandBase GetTextCommand { get; set; }
        /// <summary></summary>
        public DelegateCommand GetTextDelegateCommand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MainWindowViewModel()
        {
            // Initialize
            InitializeCommand = new DelegateCommand(() =>
            {
                User = new User()
                {
                    Name = "yamada taro",
                };
                Message = "Hello";
                Text = "Wpf 導入ツール";
            });
            // Change User
            ChangeUserCommand = new ChangeUserCommand(this);
            // get text 
            GetTextCommand = new GetTextCommand(this);
            // get text delaegate
            GetTextDelegateCommand = new DelegateCommand(() =>
            {
                MessageBox.Show(this.Text);
            },
            () =>
            {
                return !string.IsNullOrEmpty(this.Text);
            });
        }
        /// <summary>
        /// 
        /// </summary>
        public string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                SetProperty(ref _text, value);
                GetTextCommand.RaiseCanExecuteChanged();
                GetTextDelegateCommand.RaiseCanExecuteChanged();
            }
        }
    }
}
