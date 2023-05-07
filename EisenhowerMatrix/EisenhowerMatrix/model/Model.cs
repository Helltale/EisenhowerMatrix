using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EisenhowerMatrix.model
{
    public class Model : IModel
    {
        Core core = new Core();

        public List<string[]> GetData()                             { return core.GetData(); }

        public List<string[]> CreateNewRequest(string[] newData)    { return core.CreateNewRequest(newData); }

        public List<string[]> RequestClose(int index)               { return core.RequestClose(index); }

        public List<string[]> InHeaven()                            { return core.InHeaven(); }

    }
}
