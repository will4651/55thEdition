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
            if (data is null) return null;

            var viewName = data.GetType().FullName!.Replace("ViewModel", "View", StringComparison.InvariantCulture);
            var viewType = Type.GetType(viewName);

            if (viewType is null) return null;

            var control = (Control)Activator.CreateInstance(viewType)!;

            control.DataContext = data;
            return control;
        }

        public bool Match(object? data)
        {
            return data is ViewModelBase;
        }
    }
}
