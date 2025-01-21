namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // กำหนดราคาเริ่มต้นให้กับแต่ละเมนู
        private Item coffee = new Item("Coffee", 50);      // ราคาค่าเริ่มต้นสำหรับกาแฟ
        private Item greenTea = new Item("Green Tea", 100);  // ราคาค่าเริ่มต้นสำหรับชาเขียว
        private Item noodle = new Item("Noodle", 25);       // ราคาค่าเริ่มต้นสำหรับบะหมี่
        private Item pizza = new Item("Pizza", 150);        // ราคาค่าเริ่มต้นสำหรับพิซซ่า

        public Form1()
        {
            InitializeComponent();
            // กำหนดราคาเริ่มต้นในแต่ละ TextBox
            tbCoffeePrice.Text = coffee.Price.ToString("F2");
            tbGreenTeaPrice.Text = greenTea.Price.ToString("F2");
            tbNoodlePrice.Text = noodle.Price.ToString("F2");
            tbPizzaPrice.Text = pizza.Price.ToString("F2");

            tbCoffeeQuantity.Text = "0"; // กำหนดจำนวนเริ่มต้นสำหรับกาแฟ
            tbGreenTeaQuantity.Text = "0"; // กำหนดจำนวนเริ่มต้นสำหรับชาเขียว
            tbNoodleQuantity.Text = "0"; // กำหนดจำนวนเริ่มต้นสำหรับบะหมี่
            tbPizzaQuantity.Text = "0"; // กำหนดจำนวนเริ่มต้นสำหรับพิซซ่า

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            // คำนวณยอดรวมของเครื่องดื่ม
            if (chbCoffee.Checked)
            {
                coffee.Quantity = int.TryParse(tbCoffeeQuantity.Text, out int coffeeQuantity) ? coffeeQuantity : 0;
                coffee.Price = double.TryParse(tbCoffeePrice.Text, out double coffeePrice) ? coffeePrice : 0;
                total += coffee.CalculateTotal();
            }

            if (chbGreenTea.Checked)
            {
                greenTea.Quantity = int.TryParse(tbGreenTeaQuantity.Text, out int greenTeaQuantity) ? greenTeaQuantity : 0;
                greenTea.Price = double.TryParse(tbGreenTeaPrice.Text, out double greenTeaPrice) ? greenTeaPrice : 0;
                total += greenTea.CalculateTotal();
            }

            // คำนวณยอดรวมของอาหาร
            if (chbNoodle.Checked)
            {
                noodle.Quantity = int.TryParse(tbNoodleQuantity.Text, out int noodleQuantity) ? noodleQuantity : 0;
                noodle.Price = double.TryParse(tbNoodlePrice.Text, out double noodlePrice) ? noodlePrice : 0;
                total += noodle.CalculateTotal();
            }

            if (chbPizza.Checked)
            {
                pizza.Quantity = int.TryParse(tbPizzaQuantity.Text, out int pizzaQuantity) ? pizzaQuantity : 0;
                pizza.Price = double.TryParse(tbPizzaPrice.Text, out double pizzaPrice) ? pizzaPrice : 0;
                total += pizza.CalculateTotal();
            }

            double discountAmount = 0;
            double discountRate = 0;

            // ใช้ส่วนลด
            if (chbDcAll.Checked)
            {
                discountRate = รับค่าร้อยละส่วนลด(tbDcAll);
                discountAmount = total * (discountRate / 100);
            }
            else if (chbDcBeverage.Checked)
            {
                double beverageTotal = coffee.CalculateTotal() + greenTea.CalculateTotal();
                discountRate = รับค่าร้อยละส่วนลด(tbDcBeverage);
                discountAmount = beverageTotal * (discountRate / 100);
            }
            else if (chbDcFood.Checked)
            {
                double foodTotal = noodle.CalculateTotal() + pizza.CalculateTotal();
                discountRate = รับค่าร้อยละส่วนลด(tbDcFood);
                discountAmount = foodTotal * (discountRate / 100);
            }

            total -= discountAmount;
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