using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace ExtendedWindow
{
    public class FunctionBar : HeaderedItemsControl
    {
        public FunctionBar()
        {
        }

        public ObservableCollection<object> Options { get; } = new ObservableCollection<object>();
    }
}
