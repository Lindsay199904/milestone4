using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System

{
    class Inventory
    {
        // The Inventory Class creates an inventory item.
        // Create variables for each item field.
        private string  _itemName;
        private string  _itemDescription;
        private string  _partNumber;
        private string  _unitMeasurement;
        private decimal _unitPrice;
        private int     _quantityOnHand;
        private string  _inventoryLocation;

        // Constructor
        public Inventory()
        {
            _itemName = "";
            _itemDescription = "";
            _partNumber = "";
            _unitMeasurement = "";
            _unitPrice = 0.00m;
            _quantityOnHand = 0;
            _inventoryLocation = "";
        }

        // Name property
        public string ItemName
        { get { return _itemName; } set { _itemName = value; }}

        public string ItemDescription
        { get { return _itemDescription; } set { _itemDescription = value; }}

        public string PartNumber
        { get { return _partNumber; } set { _partNumber = value; }}

        public string UnitMeasurement
        { get { return _unitMeasurement; } set { _unitMeasurement = value; }}

        public decimal UnitPrice
        { get { return _unitPrice; } set { _unitPrice = value; } }

        public int QuantityOnHand
        { get { return _quantityOnHand; } set { _quantityOnHand = value; } }

        public string InventoryLocation
        { get { return _inventoryLocation; } set { _inventoryLocation = value; } }               
    }
}
