namespace Grocery_Inventory
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void bttnAddItem_Click(object sender, EventArgs e)
		{
			AddItem addItem = new AddItem();
			addItem.Show();
			this.Hide();
		}

		private void bttnRemoveItem_Click(object sender, EventArgs e)
		{
			RemoveItem removeItem = new RemoveItem();
			removeItem.Show();
			this.Hide();
		}

		private void bttnDisplayInformation_Click(object sender, EventArgs e)
		{
			Display displayItem = new Display();
			displayItem.Show();
			this.Hide();
		}

		private void bttnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
