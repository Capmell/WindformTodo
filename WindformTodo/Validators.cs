using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindformTodo
{
    public static class Validators
    {
        public static bool IsEmpyText(Control control)
        {
            return control.Text == "";
        } 

        public static bool IsMinLength(Control control, int minLength)
        {
            return control.Text.Length == minLength;
        } 

        public static bool isTextNull(Control control)
        {
            return control.Text == null;
        } 

        public static bool IsValidData(Control control)
        {
            DateTime temp = DateTime.Now;
            return DateTime.TryParse(control.Text, out temp);
        }

    }
}
