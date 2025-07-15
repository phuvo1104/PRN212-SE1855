using BusinessObjects_EF;
using Services_EF;
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

namespace WpfApp_EF
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        ICategoryService categoryService=new CategoryService();      
        IProductService productService=new ProductService();
        public AdminWindow()
        {
            InitializeComponent();
            LoadCategoriesAndProductsIntoTreeView();
        }

        private void LoadCategoriesAndProductsIntoTreeView()
        {
            tvCategory.Items.Clear();
            //tạo Gốc:
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho Hàng Cát Lái";
            tvCategory.Items.Add(root);
            //Nạp Danh mục lên TreeView:
            List<Category> categories = categoryService.GetCategories();
            foreach (Category category in categories)
            {
                //Tạo Cate node:
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);

                //nạp Product theo danh mục:
                List<Product>products=productService
                                    .GetProductsByCategory(category.CategoryId);
                category.Products= products;
                //đưa Product Node vào Cate Node
                foreach (Product product in category.Products)
                {
                    TreeViewItem product_node=new TreeViewItem();
                    product_node.Header = product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                }    
            }
            root.ExpandSubtree();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue == null)
                return;
            TreeViewItem item= e.NewValue as TreeViewItem;
            if (item == null)
                return;
            List<Product> products = null;
            object data=item.Tag;
            if (data == null)
            {//người dùng nhấn vào Node GỐC
             //==> hiển thị toàn bộ sản phẩm vào list view
                products = productService.GetProducts();
            }
            else if (data is Category)
            {//người dùng nhấn vào node Cate
             //==> hiển thị sản phẩm của Danh mục vào list view
                Category cate=data as Category;
                products = productService.GetProductsByCategory(cate.CategoryId);
            }
            else if (data is Product)
            {//hiển thị sản phẩm này vào listview
                Product product=data as Product;
                products = new List<Product>();
                products.Add(product);
            }
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource = products;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
