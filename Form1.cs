using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class Form1 : Form
    {
        ComputerOrder order;
        ComputerBuilder builder;

        public Form1()
        {
            InitializeComponent();

            order = new ComputerOrder();
        }

        private void btn_laptop_Click(object sender, EventArgs e)
        {
            String display;

            builder = new LaptopBuilder();
            order.ConstructComputer(builder);

            display = builder.Product.ToString() + "Costs: " + builder.Product.Cost;
            txtBox_display.Text = display;
        }

        private void btn_desktop_Click(object sender, EventArgs e)
        {
            String display;

            builder = new DesktopBuilder();
            order.ConstructComputer(builder);

            display = builder.Product.ToString() + "Costs: " + builder.Product.Cost;
            txtBox_display.Text = display;
        }
    }
}
