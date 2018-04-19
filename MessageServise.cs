using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecochip_4._0
{
    public interface IMessage
    {
        void ShowMessage(string message);
        void ShowExclamation(string exlamation);
        void ShowError(string Error);
    }
    class MessageServise: IMessage
    {
        public void ShowMassage(string Message)
        {
            MessageBox.Show(Message, "сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ShowExclamation(string exlamation)
        {
            MessageBox.Show(exlamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShovError(string Error)
        {
            MessageBox.Show(Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowError(string Error)
        {
            throw new NotImplementedException();
        }
    }
}
