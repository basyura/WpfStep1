using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfStep1.Commands;

namespace WpfStep1
{
    public class MainWindowViewModel : BindableBase
    {
        /// <summary></summary>
        public ICommand InitializeCommand { get; set; }
        /// <summary></summary>
        public ICommand GetTextCommand { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public MainWindowViewModel()
        {
            // Initialize
            InitializeCommand = new DelegateCommand(() =>
            {
                Message = "Hello";
                Text = "Wpf 導入ツール";
            });
            // get text 
            GetTextCommand = new DelegateCommand(() =>
            {
                MessageBox.Show(Text);
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
            set { SetProperty(ref _text, value); }
        }
    }
}
