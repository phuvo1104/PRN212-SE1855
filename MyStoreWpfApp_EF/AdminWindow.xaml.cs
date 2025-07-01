using MyStoreWpfApp_EF.Models;
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

namespace MyStoreWpfApp_EF
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        MyStoreContext context = new MyStoreContext();
        public AdminWindow()
        {
            InitializeComponent();
            LoadCategoriesIntoTreeView();
        }

        private void LoadCategoriesIntoTreeView()
        {
            //Tạo Gốc cây:
            tvCategory.Items.Clear();
            TreeViewItem root=new TreeViewItem();
            root.Header = "Kho Cát Lái";
            tvCategory.Items.Add(root);
            //Dùng EF Truy vấn toàn bộ danh mục và nạp lên Tree:
            var categories=context.Categories.ToList();
            foreach (var category in categories)
            {
                //Tạo node cho Danh mục:
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);

                //nạp danh sách Sản phẩm vào node danh mục:
                var products=context.Products
                    .Where(x=>x.CategoryId==category.CategoryId)
                    .ToList();
                foreach(var product in products)
                {
                    //Tạo Product node:
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header=product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                }    
            }
            root.ExpandSubtree();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue == null)
                return;
            TreeViewItem item=e.NewValue as TreeViewItem;
            Category category = item.Tag as Category;
            if (category != null)
            {
                LoadProductsIntoListView(category);
            }    
            Product product = item.Tag as Product;
            if (product != null)
            {
                var products = new List<Product>();
                products.Add(product);
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }
        }
        private void LoadProductsIntoListView(Category category)
        {
            var products = context.Products
                    .Where(x => x.CategoryId == category.CategoryId)
                    .ToList();
            lvProduct.ItemsSource = null;
            lvProduct.ItemsSource=products;
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count <= 0) return;
            Product product = e.AddedItems[0] as Product;
            if (product == null) return;
            DisplayProductDetail(product);
        }
        private void DisplayProductDetail(Product product)
        {
            if(product == null){
                txtId.Text = "";
                txtName.Text = "";
                txtQuantity.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtId.Focus();
            }
            else{
                txtId.Text = product.ProductId+"";
                txtName.Text = product.ProductName;
                txtQuantity.Text = product.UnitsInStock+"";
                txtPrice.Text = product.UnitPrice+"";
            }    
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            DisplayProductDetail(null);            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Bước 1: Tạo đối tượng Sản phẩm
                //Bước 2: Phải biết Sản phẩm này gán vào Danh mục nào
                //Bước 3: Lưu đối tượng
                //Bước 4: Cập nhật lại TreeView và ListView

                //Chi tiết xử lý:~~~~~~~
                //Bước 1: Tạo đối tượng sản phẩm
                Product product = new Product();
                //ko gán Id vì Id CSDL thiết kế là Tự động tăng
                product.ProductName = txtName.Text;
                product.UnitsInStock = short.Parse(txtQuantity.Text);
                product.UnitPrice = decimal.Parse(txtPrice.Text);
                //Bước 2:Phải biết sản phẩn này gán vào Danh mục nào?
                TreeViewItem cate_node_selected = tvCategory.SelectedItem as TreeViewItem;
                if (cate_node_selected == null)
                {
                    MessageBox.Show(
                        "Thím chưa chọn Danh mục thì làm sao lưu mới sản phẩm?",
                        "Thông báo lưu bị lỗi",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }
                Category category = cate_node_selected.Tag as Category;
                if (category == null)
                {
                    MessageBox.Show(
                        "Thím chưa chọn Danh mục thì làm sao lưu mới sản phẩm?",
                        "Thông báo lưu bị lỗi",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }
                product.CategoryId = category.CategoryId;
                //Bước 3: Lưu đối tượng
                context.Products.Add(product);
                context.SaveChanges();
                //Bước 4: Cập nhật lại TreeView và ListView
                //Bước 4.1. Cập nhật lại TreeView:
                TreeViewItem product_node = new TreeViewItem();
                product_node.Header = product.ProductName;
                product_node.Tag = product;
                cate_node_selected.Items.Add(product_node);
                //Bước 4.2 Cập nhập lại ListView (hiển thị Sản phẩm mới
                //vừa thêm vào CSDL thành công lên giao diện):
                LoadProductsIntoListView(category);
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Lỗi đặc biệt gì đó: "+ex.Message,
                    "Lỗi ngoại lệ",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error 
                   );
            }            
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //Bước 1: Phải tìm được sản phẩm thì mới sửa
            //Bước 2: Tiến hành sửa các giá trị của thuộc tính
            //Bước 3: Lưu cập nhật
            //Bước 4: Cập nhật lại giao diện TreeView và ListView
            //----------CHI TIẾT-------------:
            //Bước 1: Phải tìm được sản phẩm thì mới sửa
            int id=int.Parse(txtId.Text);
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                MessageBox.Show(
                    "Không tìm thấy sản phẩm nào có mã ="+id+" để sửa",
                    "Sửa thất bại",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
            //Bước 2: Tiến hành sửa các giá trị của thuộc tính
            //theo ORM ta học: Sửa giá trị của thuộc tính chính là sửa CELL của 1 row
            //trong bảng
            product.ProductName = txtName.Text;
            product.UnitsInStock = short.Parse(txtQuantity.Text);
            product.UnitPrice = Decimal.Parse(txtPrice.Text);
            //Bước 3: Lưu cập nhật
            context.SaveChanges();
            //Bước 4: Cập nhật lại giao diện TreeView và ListView
            //Bước 4.1. Cập nhật lại giao diện TreeView:
            TreeViewItem cate_node_selected = tvCategory.SelectedItem as TreeViewItem;
            if(cate_node_selected!=null)
            {
                Category category = cate_node_selected.Tag as Category;
                if (category != null)
                {
                    //xóa toàn bộ Node con trong node Danh mục:
                    cate_node_selected.Items.Clear();
                    //Nạp lại toàn bộ Product nodes:
                    //nạp danh sách Sản phẩm vào node danh mục:
                    var products = context.Products
                        .Where(x => x.CategoryId == category.CategoryId)
                        .ToList();
                    foreach (var product_new in products)
                    {
                        //Tạo Product node:
                        TreeViewItem product_node = new TreeViewItem();
                        product_node.Header = product_new.ProductName;
                        product_node.Tag = product_new;
                        cate_node_selected.Items.Add(product_node);
                    }
                    //Bước 4.2. Cập nhật lại giao diện ListView:
                    LoadProductsIntoListView(category);
                }
            }    
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //Bước 1: Tìm sản phẩm để xóa
            //Bước 2: Xác nhận có muốn xóa hay không
            //Bước 3: Tiến hành xóa  nếu đồng ý xóa
            //Bước 4: Nếu xóa thành công thì cập nhật lại giao diện TreeView, ListView

            //--------CHI TIẾT-----------:
            //Bước 1: Tìm sản phẩm để xóa
            int id = int.Parse(txtId.Text);
            Product product = context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product == null)
            {
                MessageBox.Show(
                    "Không tìm thấy sản phẩm nào có mã =" + id + " để XÓA",
                    "Sửa thất bại",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }
            //Bước 2: Xác nhận có muốn xóa hay không
            MessageBoxResult result = MessageBox.Show(
                $"Thím có chắc chắn muốn xóa sản phẩm [{product.ProductName}] này không?",
                "Xác nhận xóa",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
                return;
            //Bước 3: Tiến hành xóa  nếu đồng ý xóa
            context.Products.Remove(product);
            context.SaveChanges();
            //Bước 4: Nếu xóa thành công thì cập nhật lại giao diện TreeView, ListView
            //Bước 4.1. Xóa node Sản phẩm ra khỏi Node danh mục trên TreeView
            TreeViewItem cate_node_selected = tvCategory.SelectedItem as TreeViewItem;
            if (cate_node_selected != null)
            {
                Category category = cate_node_selected.Tag as Category;
                if (category != null)
                {
                    //xóa toàn bộ Node con trong node Danh mục:
                    cate_node_selected.Items.Clear();
                    //Nạp lại toàn bộ Product nodes:
                    //nạp danh sách Sản phẩm vào node danh mục:
                    var products = context.Products
                        .Where(x => x.CategoryId == category.CategoryId)
                        .ToList();
                    foreach (var product_new in products)
                    {
                        //Tạo Product node:
                        TreeViewItem product_node = new TreeViewItem();
                        product_node.Header = product_new.ProductName;
                        product_node.Tag = product_new;
                        cate_node_selected.Items.Add(product_node);
                    }
                    //Bước 4.2. Cập nhật lại giao diện ListView:
                    LoadProductsIntoListView(category);
                    DisplayProductDetail(null);
                }
            }
        }
    }
}
