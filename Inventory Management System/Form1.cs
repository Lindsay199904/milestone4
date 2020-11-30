using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {
        // List to hold Inventory objects
        List<Inventory> itemList = new List<Inventory>();

        public Form1()
        {
            InitializeComponent();
        }
        // The InventoryData method accepts a Inventory object
        // as an argument. It assigns the data entered by the
        // user to the object's properties.

        private void InventoryData(Inventory item)
        {
            // Get the item's name.
            item.ItemName = itemNameTextBox.Text;

            // Get the item description.
            item.ItemDescription = descriptionTextBox.Text;

            // Get the item part number.
            item.PartNumber = partNumberTextBox.Text;

            // Get the item unit measurement.
            item.UnitMeasurement = unitMeasurementTextBox.Text;

            // Get the item unit Price. 
            if (decimal.TryParse(unitPriceTextBox.Text, out decimal price))
            {
                item.UnitPrice = price;
            }
            else
            {
                // Display error message.
                MessageBox.Show("Invalid Price");
            }

            // Get the quantity on hand.
            if (int.TryParse(quantityOnHandTextBox.Text, out int quantity))
            {
                item.QuantityOnHand = quantity;
            }
            else
            {
                // Display error message.
                MessageBox.Show("Invalid Quantity");
            }

            // Get the inventory location.
            item.InventoryLocation = inventoryLocationTextBox.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Create an Inventory object.
            Inventory item = new Inventory();

            // Get the item data.
            InventoryData(item);

            // Add the Inventory item object to the List.
            itemList.Add(item);

            // Add an entry to the list box.
            itemListBox.Items.Add(item.ItemName);

            // Add an entry to the dataGrid box.
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = itemNameTextBox.Text;
            dataGridView1.Rows[n].Cells[1].Value = descriptionTextBox.Text;
            dataGridView1.Rows[n].Cells[2].Value = partNumberTextBox.Text;
            dataGridView1.Rows[n].Cells[3].Value = unitMeasurementTextBox.Text;
            dataGridView1.Rows[n].Cells[4].Value = unitPriceTextBox.Text;
            dataGridView1.Rows[n].Cells[5].Value = quantityOnHandTextBox.Text;
            dataGridView1.Rows[n].Cells[6].Value = inventoryLocationTextBox.Text;

            // Clear the text boxes.
            ClearTextBoxes();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close this form.
            this.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = itemListBox.SelectedIndex;

            if (itemListBox.SelectedIndex == -1)
                MessageBox.Show("Please select an Item first!");

            // Bring up fields to edit.
            if (itemNameTextBox.Text != itemList[index].ItemName)
            { itemList[index].ItemName = itemNameTextBox.Text; }

            if (descriptionTextBox.Text != itemList[index].ItemDescription)
            { itemList[index].ItemDescription = descriptionTextBox.Text; }

            if (partNumberTextBox.Text != itemList[index].PartNumber)
            { itemList[index].PartNumber = partNumberTextBox.Text; }

            if (unitMeasurementTextBox.Text != itemList[index].UnitMeasurement)
            { itemList[index].UnitMeasurement = unitMeasurementTextBox.Text; }

            if (unitPriceTextBox.Text != (itemList[index].UnitPrice.ToString()))
            {
                if (decimal.TryParse(unitPriceTextBox.Text, out decimal price))
                { itemList[index].UnitPrice = price; }
                else
                {   // Display error message.
                    MessageBox.Show("Invalid Quantity");
                }
            }

            if (quantityOnHandTextBox.Text != itemList[index].QuantityOnHand.ToString())
            {
                if (int.TryParse(quantityOnHandTextBox.Text, out int quantity))
                { itemList[index].QuantityOnHand = quantity; }
                else
                {   // Display error message.
                    MessageBox.Show("Invalid Quantity");
                }
            }
            inventoryLocationTextBox.Text = itemList[index].InventoryLocation;

            // Clear the text boxes.
            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = itemListBox.SelectedIndex;

            if (itemListBox.SelectedIndex == -1)
                MessageBox.Show("Please select an Item first!");

            // Clear the fields of data.
            itemList[index].ItemName = "";
            itemList[index].ItemDescription = "";
            itemList[index].PartNumber = "";
            itemList[index].UnitMeasurement = "";
            itemList[index].UnitPrice = 0;
            itemList[index].QuantityOnHand = 0;
            itemList[index].InventoryLocation = "";

            // Delete entry from the list box.
            itemListBox.Items.Remove(itemList[index].ItemName);

            // Delete row from datagrid.
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows.RemoveAt(0);

            // Clear the text boxes.
            ClearTextBoxes();
        }

        private void ItemSelectButton_Click(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = itemListBox.SelectedIndex;

            if (itemListBox.SelectedIndex == -1)
                MessageBox.Show("Please select an Item first!");

            // Bring up fields to edit.
            itemNameTextBox.Text = itemList[index].ItemName;
            descriptionTextBox.Text = itemList[index].ItemDescription;
            partNumberTextBox.Text = itemList[index].PartNumber;
            unitMeasurementTextBox.Text = itemList[index].UnitMeasurement;
            unitPriceTextBox.Text = (itemList[index].UnitPrice.ToString("c"));
            quantityOnHandTextBox.Text = (itemList[index].QuantityOnHand.ToString());
            inventoryLocationTextBox.Text = itemList[index].InventoryLocation;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Please enter a item name.");
            }
            
            if (!String.IsNullOrEmpty(descriptionTextBox.Text))
            {
                TextBox1_TextChanged();
            }
            else if (!String.IsNullOrEmpty(partNumberTextBox.Text))
            {
                TextBox1_TextChanged();
            }
            else if (!String.IsNullOrEmpty(unitMeasurementTextBox.Text))
            {
                TextBox1_TextChanged();
            }
            else if (!decimal.TryParse(unitPriceTextBox.Text, out decimal price) && (price > 0))
            {
                TextBox1_TextChanged();
            }
            else if (!int.TryParse(quantityOnHandTextBox.Text, out int quantity) && (quantity > 0))
            {
                TextBox1_TextChanged();
            }            
            else if (!String.IsNullOrEmpty(inventoryLocationTextBox.Text))
            {
                TextBox1_TextChanged();
            }
            else
            {
                MessageBox.Show("Please enter at least 1 more critera");
            }
        }                            

        private void TextBox1_TextChanged()

        {
            int index = itemListBox.FindString(this.itemNameTextBox.Text);
            if (0 <= index)
            {
                itemListBox.SelectedIndex = index;

                // Bring up fields for searched item.
                itemNameTextBox.Text = itemList[index].ItemName;
                descriptionTextBox.Text = itemList[index].ItemDescription;
                partNumberTextBox.Text = itemList[index].PartNumber;
                unitMeasurementTextBox.Text = itemList[index].UnitMeasurement;
                unitPriceTextBox.Text = (itemList[index].UnitPrice.ToString("c"));
                quantityOnHandTextBox.Text = (itemList[index].QuantityOnHand.ToString());
                inventoryLocationTextBox.Text = itemList[index].InventoryLocation;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear the text boxes.
            ClearTextBoxes();
        }

        private void ReOrderButton_Click(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = itemListBox.SelectedIndex;

            if (itemListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item first!");
            }
            else
            {
                if (int.TryParse(quantityOnHandTextBox.Text, out int quantity))
                {
                    if (int.TryParse(reorderTextBox.Text, out int amount))
                    {
                        itemList[index].QuantityOnHand = quantity + amount;

                        // Update an entry to the dataGrid box.                         
                        dataGridView1.Rows[0].Cells[5].Value = quantity + amount;

                        ClearTextBoxes();
                    }
                    else
                    {   // Display error message.
                        MessageBox.Show("Invalid ReOrder Quantity");
                    }
                }
            }                        
        }
        private void ClearTextBoxes()
        {


            // Clear the text boxes.
            itemNameTextBox.Clear();
            descriptionTextBox.Clear();
            partNumberTextBox.Clear();
            unitMeasurementTextBox.Clear();
            unitPriceTextBox.Clear();
            quantityOnHandTextBox.Clear();
            inventoryLocationTextBox.Clear();

            // Reset the focus.
            itemNameTextBox.Focus();
        }

        private void itemNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void unitMeasurementTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
