using RepositoryPatternWithDapper.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepositoryPatternWithDapper
{
    public partial class prdFrm : Form
    {
        IProductRepository productRepository;
        public prdFrm()
        {
            InitializeComponent();
        }

        private void prdFrm_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            prdDtGrd.DataSource = productRepository.GetProducts();
            lblTotalRec.Text = $"Total Records{prdDtGrd.RowCount}";
        }
    }
}
