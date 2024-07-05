using ArchitecturalPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturalPatterns.Presenter
{
    internal class Presenter : IPresenter
    {
        private SomeModel _model;
        private IView _view;
        public Presenter(IView view)
        {
            _view = view;
            _model = new SomeModel();
        }

        public void Load()
        {
            _view.Load(_model.Value);
        }

        public void Save(string value)
        {
            _model.Value = value;
            _view.Display(value);
        }
    }
}
