using Avalonia.Controls;
using Avalonia.Controls.Templates;
using BallBearing.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallBearing
{
    public class ViewLocator : IDataTemplate
    {
        public Control? Build(object? data)
        {
            // null check
            if (data is null) return null;

            // get name of viewmodel to store expected view name and type
            var viewName = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.InvariantCulture);
            var viewType = Type.GetType(viewName);

            // null check
            if (viewType is null) return null;

            // create view
            var control = (Control)Activator.CreateInstance(viewType)!;

            // set DataContext of created view and return it
            control.DataContext = data;
            return control;
        }

        public bool Match(object? data)
        {
            return data is ViewModelBase;
        }
    }
}
