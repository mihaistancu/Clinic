using System;
using System.Windows;

namespace Clinic.WPF.Mvvm
{
    public static class View
    {
        public static Window For<T>()
        {
            var viewModelTypeName = typeof(T).AssemblyQualifiedName;
            var viewTypeName = viewModelTypeName.Replace("ViewModel", "View");
            var viewType = Type.GetType(viewTypeName);
            return (Window)Activator.CreateInstance(viewType);
        }
    }
}
