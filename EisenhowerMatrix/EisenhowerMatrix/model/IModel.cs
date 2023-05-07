using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisenhowerMatrix.model
{
    public interface IModel
    {
        List<string[]> GetData();

        List<string[]> CreateNewRequest(string[] newData);

        List<string[]> RequestClose(int index);

        List<string[]> InHeaven();

    }
}
