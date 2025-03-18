using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Tootedjakatekooriad
{
    public partial class MainForm : Form
    {
        private ProductsContext _productscontext;
        public MainForm()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this._productscontext = new ProductsContext();
            this._productscontext.Database.EnsureCreated();
            this._productscontext.Categories.Load();
            this.categoryBindingSource.DataSource = _productscontext.Categories.Local.ToBindingList();

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this._productscontext?.Dispose();
            this._productscontext = null;
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (this._productscontext != null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;

                if (category != null)
                {
                    this._productscontext.Entry(category).Collection(e => e.Products).Load();
                    this.dataGridViewProducts.DataSource = category.Products;
                }
            }
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this._productscontext!.SaveChanges();
            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();
        }
    }
}
