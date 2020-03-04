using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManager.Desktop.Services.ComboBoxHelper
{
    public class ComboBoxHelp : IComboBoxHelp
    {
        public void AddElementsToComboBox<TItem>(ComboBox comboBox, IEnumerable<TItem> items, Func<TItem, string> displayFunc)
        {
            comboBox.Items.Clear();

            foreach (var item in items)
            {
                string displayText = displayFunc(item);
                comboBox.Items.Add(displayText);
            }
        }

        public TItem GetSelectedElement<TItem>(ComboBox comboBox, IEnumerable<TItem> items, Func<TItem, string> indicator)
        {
            TItem item = items.SingleOrDefault(i => indicator(i) == comboBox.SelectedItem.ToString());
            return item;
        }
    }
}
