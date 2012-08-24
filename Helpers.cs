using System.ComponentModel;
using System.Windows.Data;
using Microsoft.Windows.Controls;

namespace Labs.Filtering
{
    public static class Helpers
    {
        //public static string GetSortMemberPath(DataGridColumn column)
        //{
        //    // find the sortmemberpath
        //    string sortPropertyName = column.SortMemberPath;
        //    if (string.IsNullOrEmpty(sortPropertyName))
        //    {
        //        DataGridBoundColumn boundColumn = column as DataGridBoundColumn;
        //        if (boundColumn != null)
        //        {
        //            Binding binding = boundColumn.Binding as Binding;
        //            if (binding != null)
        //            {
        //                if (!string.IsNullOrEmpty(binding.XPath))
        //                {
        //                    sortPropertyName = binding.XPath;
        //                }
        //                else if (binding.Path != null)
        //                {
        //                    sortPropertyName = binding.Path.Path;
        //                }
        //            }
        //        }
        //    }

        //    return sortPropertyName;
        //}

        public static SortDescription? FindSortDescription(SortDescriptionCollection sortDescriptions, string sortPropertyName)
        {
            foreach (SortDescription sortDesc in sortDescriptions)
                if (string.Compare(sortDesc.PropertyName, sortPropertyName) == 0)
                    return sortDesc;
            return null;
        }
    }
}
