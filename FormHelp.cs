using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFC_10000
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();

            textBoxHelp.Text =
                    "Приложение создано в рамках учебной дисциплины «Проектная деятельность»\r\n \r\n" +
                    "Разработчик:\r\n" +
                    "студент гр. ПИН - 211\r\n" +
                    "Ложников Алексей\r\n \r\n" +
                    "Версия от 07.12.22\r\n \r\n";
        }
    }
}
