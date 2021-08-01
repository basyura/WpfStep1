using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfStep1.Models;

namespace WpfStep1.Commands
{
    public class ChangeUserCommand : CommandBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vm"></param>
        public ChangeUserCommand(MainWindowViewModel vm) : base(vm)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public override void Execute()
        {
            ViewModel.User.Name = "Mine fujiko";
        }
    }
}
