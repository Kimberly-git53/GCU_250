using CarClassLibrary;

namespace CarStoreGUIApp
{
    public partial class frmCarStore : Form
    {
        // Create a store object to hold the car inventory
        Store Store = new Store();

        // Create two BindingSources to bind the car inventory and shopping list to the listboxes
        BindingSource bindingSourceInventory = new BindingSource();
        BindingSource bindingSourceShoppingList = new BindingSource();
        public frmCarStore()
        {
            InitializeComponent();
            // Set the Datasource of the BindingSources to the CarList and ShoppingList properties of the store
            bindingSourceInventory.DataSource = Store.CarList;
            bindingSourceShoppingList.DataSource = Store.ShoppingList;

            // Set the Datasource of the listboxes to the BindingSources
            listInventory.DataSource = bindingSourceInventory;
            listShoppingCart.DataSource = bindingSourceShoppingList;

        }
        // Create a car instance from the textboxes and add it to the inventory list
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // Get the properties of the car from the textboxes
            string Make = txtMake.Text;
            string Model = txtModel.Text;
            int Year = int.Parse(txtYear.Text);
            decimal Price = decimal.Parse(txtPrice.Text);

            // create a car and add it to the store's inventory
            Car car = new Car(Make, Model, Year, Price);
            Store.CarList.Add(car);


            MessageBox.Show(car + " added to inventory which now has " + Store.CarList.Count() + " items.");

            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();

            bindingSourceInventory.ResetBindings(false); // Refresh the inventory listbox

        }
        // copy the selected car from the inventory list to the shopping list
        private void BtnAddToCart_Click(object sender, EventArgs e)
        {
            // Get the car from the selected item in the inventory listbox and add it to the shopping list
            Store.ShoppingList.Add((Car)listInventory.SelectedItem);
            // Refresh the shopping listbox
            bindingSourceShoppingList.ResetBindings(false);
        }
        // add the value of items in the shopping list. Display the total in a label
        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            // calculate the total price of the shopping list
            decimal total = Store.Checkout();
            // Use label6 to display the total
            lblTotal.Text = total.ToString("C");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            // Get the search term from the textbox
            string searchTerm = txtSearch.Text;


            // Search the inventory for cars that contain the search term in the Make, Model, or Color properties
            List<Car> searchResults = Store.Search(searchTerm);
            // Display the search results in the inventory listbox
            bindingSourceInventory.DataSource = searchResults;

            // Refresh the inventory listbox
            bindingSourceInventory.ResetBindings(false);
            return;

        }
        private bool isAscending = true;
        private void BtnSortAToZ_Click(object sender, EventArgs e)
        {
            if (isAscending) 
            {
                // Sort the inventory by Make ascending
                Store.CarList.Sort((x, y) => x.Make.CompareTo(y.Make));
                isAscending = false;
            }
            else
            {
                // Sort the inventory by Make descending
                Store.CarList.Sort((x, y) => y.Make.CompareTo(x.Make));
                isAscending = true;
            }

            // Refresh the inventory listbox
            bindingSourceInventory.ResetBindings(false);

            return;
        }
    }
}
