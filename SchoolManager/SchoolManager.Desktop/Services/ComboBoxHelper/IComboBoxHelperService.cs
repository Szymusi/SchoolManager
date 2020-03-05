using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Services.ComboBoxHelper
{
    public interface IComboBoxHelperService
    {
        void AddElementsToComboBox<TItem>(ComboBox comboBox, IEnumerable<TItem> items, Func<TItem, string> displayFunc);

        TItem GetSelectedElement<TItem>(ComboBox comboBox, IEnumerable<TItem> items, Func<TItem, string> indicator);
    }
}
