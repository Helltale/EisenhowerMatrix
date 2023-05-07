using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Core
    {
        List<string[]> data = new List<string[]>();
        List<string[]> dataClose = new List<string[]>();
        string[] tmp;

        public List<string[]> GetData() { return data; }

        public List<string[]> CreateNewRequest(string[] newData){
            data.Add(newData);
            return data;
        }

        public List<string[]> RequestClose(int index) {
            tmp = data.ElementAt(index);
            data.RemoveAt(index);
            return data;
        }

        public List<string[]> InHeaven() {
            dataClose.Add(tmp);
            tmp = null;
            return dataClose;
        }


    }
}
