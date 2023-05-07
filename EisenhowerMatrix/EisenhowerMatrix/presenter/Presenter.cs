using EisenhowerMatrix.model;
using EisenhowerMatrix.view;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisenhowerMatrix.presenter
{
    public class Presenter
    {

        private IModel _model;
        private IView _view;

        public Presenter(IView view){
            _model = new Model();
            _view = view;

            _view.AddCaseEvent += new EventHandler(AddCase);


            

        }

        private void AddCase(object sender, EventArgs e) {
            //_model.CreateNewRequest();
        }

    }
}
