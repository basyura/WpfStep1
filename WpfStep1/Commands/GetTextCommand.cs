using System.Windows;
using System.Windows.Input;

namespace WpfStep1.Commands
{
    public class GetTextCommand: CommandBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vm"></param>
        public GetTextCommand(MainWindowViewModel vm) : base(vm)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public override bool CanExecute
        {
            get
            {
                bool ret = !string.IsNullOrEmpty(ViewModel.Text);
                return ret;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute()
        {
            MessageBox.Show(ViewModel.Text);
        }
    }
}
