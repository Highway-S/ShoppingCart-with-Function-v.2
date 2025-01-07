namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            // คำนวณยอดรวมของเครื่องดื่ม
            if (chbCoffee.Checked)
            {
                total += คำนวณราคาสินค้า(tbCoffeePrice, tbCoffeeQuantity, "Coffee");
            }

            if (chbGreenTea.Checked)
            {
                total += คำนวณราคาสินค้า(tbGreenTeaPrice, tbGreenTeaQuantity, "Green Tea");
            }

            // คำนวณยอดรวมของอาหาร
            if (chbNoodle.Checked)
            {
                total += คำนวณราคาสินค้า(tbNoodlePrice, tbNoodleQuantity, "Noodle");
            }

            if (chbPizza.Checked)
            {
                total += คำนวณราคาสินค้า(tbPizzaPrice, tbPizzaQuantity, "Pizza");
            }

            double discountAmount = 0;

            // ใช้ส่วนลด
            if (chbDcAll.Checked)
            {
                // ส่วนลดจากยอดรวมทั้งหมด
                discountAmount = total * (รับค่าร้อยละส่วนลด(tbDcAll) / 100);
            }
            else if (chbDcBeverage.Checked)
            {
                // ส่วนลดจากยอดเฉพาะเครื่องดื่ม
                double beverageTotal = 0;

                if (chbCoffee.Checked)
                {
                    beverageTotal += คำนวณราคาสินค้า(tbCoffeePrice, tbCoffeeQuantity, "Coffee");
                }
                if (chbGreenTea.Checked)
                {
                    beverageTotal += คำนวณราคาสินค้า(tbGreenTeaPrice, tbGreenTeaQuantity, "Green Tea");
                }

                discountAmount = beverageTotal * (รับค่าร้อยละส่วนลด(tbDcBeverage) / 100);
            }
            else if (chbDcFood.Checked)
            {
                // ส่วนลดจากยอดเฉพาะอาหาร
                double foodTotal = 0;

                if (chbNoodle.Checked)
                {
                    foodTotal += คำนวณราคาสินค้า(tbNoodlePrice, tbNoodleQuantity, "Noodle");
                }
                if (chbPizza.Checked)
                {
                    foodTotal += คำนวณราคาสินค้า(tbPizzaPrice, tbPizzaQuantity, "Pizza");
                }

                discountAmount = foodTotal * (รับค่าร้อยละส่วนลด(tbDcFood) / 100);
            }

            total -= discountAmount;

            // แสดงยอดรวมหลังหักส่วนลด
            tbTotal.Text = total.ToString("F2");

            // ประมวลผลเงินสดและเงินทอน
            if (double.TryParse(tbCash.Text, out double cash))
            {
                if (cash >= total)
                {
                    double change = cash - total;
                    tbChange.Text = change.ToString("F2");

                    // คำนวณเงินทอนแยกตามธนบัตรและเหรียญ
                    คำนวณเงินทอน(change);
                }
                else
                {
                    MessageBox.Show("เงินสดไม่พอชำระค่าสินค้า");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินสด (Cash) ให้ถูกต้อง");
            }
        }

        private double คำนวณราคาสินค้า(TextBox priceTextBox, TextBox quantityTextBox, string itemName)
        {
            if (double.TryParse(priceTextBox.Text, out double price) && int.TryParse(quantityTextBox.Text, out int quantity))
            {
                return price * quantity;
            }
            else
            {
                MessageBox.Show($"กรุณากรอกราคาหรือจำนวนของ {itemName} ให้ถูกต้อง");
                return 0;
            }
        }

        private double รับค่าร้อยละส่วนลด(TextBox discountTextBox)
        {
            if (double.TryParse(discountTextBox.Text, out double discountPercent))
            {
                return discountPercent; // คืนค่าร้อยละส่วนลด
            }
            return 0; // กรณีที่กรอกส่วนลดไม่ถูกต้อง
        }

        private void คำนวณเงินทอน(double change)
        {
            int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            TextBox[] changeTextBoxes = { tb1000, tb500, tb100, tb50, tb20, tb10, tb5, tb2, tb1 };

            for (int i = 0; i < denominations.Length; i++)
            {
                int count = (int)(change / denominations[i]);
                changeTextBoxes[i].Text = count.ToString();
                change %= denominations[i];
            }
        }
    }
}
