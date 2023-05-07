using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisenhowerMatrix.view
{
    public interface IView
    {
         event EventHandler AddCaseEvent;
         event EventHandler RemoveCaseEvent;
    }
}
