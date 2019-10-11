using System;
using System.IO;
using System.Windows.Forms;
using WordsCount.BL;

namespace WordsCount
{
    public partial class WordsCountForm : Form
    {

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public WordsCountForm()
        {
            InitializeComponent();
        }

        private void rbText_CheckedChanged(object sender, EventArgs e)
        {
            tbText.Text = tbFajl.Text = tbBaza.Text = label1.Text = string.Empty;
            gridIzBaze.DataSource = null;

            string name = ((RadioButton)sender).Name;
            switch (name)
            {
                case "rbText":
                    tbText.Enabled = true;
                    btnFajl.Enabled = tbFajl.Enabled = tbBaza.Enabled = false;
                    break;
                case "rbFajl":
                    tbText.Enabled = tbBaza.Enabled = false;
                    btnFajl.Enabled = tbFajl.Enabled = true;
                    tbFajl.ReadOnly = true;
                    break;
                case "rbBaza":
                    tbText.Enabled = btnFajl.Enabled = tbFajl.Enabled = false;
                    tbBaza.Enabled = true;
                    tbBaza.ReadOnly = true;
                    BL.BL obj = new BL.BL();
                    gridIzBaze.DataSource = obj.GetAllCategories().Tables[0];
                    break;
            }
        }

        private void btnBrojReci_Click(object sender, EventArgs e)
        {
            int brojReci;

            if (rbText.Checked)
            {
                if (string.IsNullOrEmpty(tbText.Text))
                {
                    MessageBox.Show("Morate uneti tekst!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                brojReci = client.GetWordsCount(tbText.Text);
                label1.Text = brojReci.ToString();
            }
            if (rbFajl.Checked)
            {
                if (string.IsNullOrEmpty(tbFajl.Text))
                {
                    MessageBox.Show("Morate uneti tekst!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                brojReci = client.GetWordsCount(tbFajl.Text);
                label1.Text = brojReci.ToString();
            }
            if (rbBaza.Checked)
            {
                if (string.IsNullOrEmpty(tbBaza.Text))
                {
                    MessageBox.Show("Morate uneti tekst!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                brojReci = client.GetWordsCount(tbBaza.Text);
                label1.Text = brojReci.ToString();
            }

        }

        private void btnFajl_Click(object sender, EventArgs e)
        {
            traziFajl.Filter = "Text files|*.txt";
            traziFajl.FileName = "";

            DialogResult result = traziFajl.ShowDialog();

            if (result == DialogResult.OK)
            {
                BL.BL obj = new BL.BL();
                tbFajl.Text = obj.GetTextFromFile(traziFajl.FileName);
            }
        }



        private void gridIzBaze_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (rbBaza.Checked)
            {
                if (gridIzBaze.Rows.Count > 0)
                {
                    tbBaza.Text = gridIzBaze[2, e.RowIndex].Value.ToString();
                }
                
            }

        }
    }
}
