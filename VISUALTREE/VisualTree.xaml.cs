using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VISUALTREE
{
    /// <summary>
    /// VisualTree.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class VisualTree : Window
    {
        public VisualTree()
        {
            InitializeComponent();
        }
        public void Process(DependencyObject root)
        {
            treeView.Items.Clear();
            ProcessElement(root, null);
        }

        private void ProcessElement(DependencyObject element, TreeViewItem previousItem)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = element.GetType().Name;

            item.IsExpanded = true;

            if (previousItem == null)
                treeView.Items.Add(item);
            else
                previousItem.Items.Add(item);

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(element); i++)
            {
                ProcessElement(VisualTreeHelper.GetChild(element, i), item);
            }
        }
    }
}
