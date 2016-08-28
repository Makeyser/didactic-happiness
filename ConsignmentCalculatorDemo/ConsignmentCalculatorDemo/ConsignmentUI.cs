using ConsignmentClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentCalculatorDemo
{
    public partial class ConsignmentUI : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource cartBinding = new BindingSource();
        BindingSource itemsBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;

        public ConsignmentUI()
        {
            InitializeComponent();
            SetupData();

            itemsBinding.DataSource = store.Items.Where(x=> x.Sold ==false).ToList();
            itemListBox.DataSource = itemsBinding;

            itemListBox.DisplayMember = "Display";
            itemListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            shoppingCartListBox.DataSource = cartBinding;

            shoppingCartListBox.DisplayMember = "Display";
            shoppingCartListBox.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            vendorsListbox.DataSource = vendorsBinding;

            vendorsListbox.DisplayMember = "Display";
            vendorsListbox.ValueMember = "Display";
        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { firstName = "Bill", lastName = "Smith" });
            store.Vendors.Add(new Vendor { firstName = "Sue", lastName = "Smith", });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "a book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Tale of Two Cities",
                Description = "a book about a revolution",
                Price = 3.50M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "a book about a wizzard",
                Price = 5.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "a book about a lady",
                Price = 1.50M,
                Owner = store.Vendors[1]
            });

            store.Name = "Seconds are Better";
        }

        private void addToCart_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)itemListBox.SelectedItem;

            MessageBox.Show(selectedItem.Title);

            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            foreach (Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.paymentDue += (decimal)item.Owner.commission * item.Price;
                storeProfit += (1- (decimal)item.Owner.commission) * item.Price;
            }
            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storePayText.Text = string.Format("{0}", storeProfit.ToString("c"));

            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }

        private void storePayText_Click(object sender, EventArgs e)
        {

        }
    }
}
