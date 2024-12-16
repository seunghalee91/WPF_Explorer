using System.Windows;
using System.Windows.Controls;

namespace WpfExplorer.Forms.UI.Units
{
    public class FolderTreeViewItem : TreeViewItem
    {
        static FolderTreeViewItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FolderTreeViewItem), new FrameworkPropertyMetadata(typeof(FolderTreeViewItem)));
        }
    }
}
