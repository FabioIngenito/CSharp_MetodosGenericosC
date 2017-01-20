using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace wfaMetodosGenericos
{
    public partial class frmMetodosGenericos : Form
    {
        //Classe de Métodos Genéricos
        //Class of Generic Methods
        clsMetodosGenericos clsMetGen = new clsMetodosGenericos();

        public frmMetodosGenericos()
        {
            InitializeComponent();
        }

        #region "Trocar Valores de Lugar - Swap Place Values"

        private void btnTrocaDeLugar_Click(object sender, EventArgs e)
        {
            string strTexto1 = txtTexto1.Text;
            string strTexto2 = txtTexto2.Text;

            clsMetGen.Trocar<string>(ref strTexto1, ref strTexto2);

            txtTexto1.Text = strTexto1;
            txtTexto2.Text = strTexto2;
        }

        #endregion

        #region "Compara Qualquer - Compare Any"

        private void btnComparaValoresAlfanumericos_Click(object sender, EventArgs e)
        {
            string strValorA1 = txtValorA1.Text;
            string strValorA2 = txtValorA2.Text;

            txtMaiorValorA.Text = clsMetGen.Maximo<string>(strValorA1, strValorA2);
        }

        private void btnComparaValoresNumericos_Click(object sender, EventArgs e)
        {
            long lngValorN1 = Convert.ToUInt32(txtValorN1.Text);
            long lngValorN2 = Convert.ToUInt32(txtValorN2.Text);

            txtMaiorValorN.Text = Convert.ToString(clsMetGen.Maximo<long>(lngValorN1, lngValorN2));
        }

        private void txtValorN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8) e.Handled = true;
        }

        private void txtValorN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8) e.Handled = true;
        }
        #endregion

        #region "Cria Lista"

        private void txtListaValorNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9') && e.KeyChar != 8 && e.KeyChar != 32 && e.KeyChar != 44) e.Handled = true;
        }

        /// <summary>
        /// Botão para Criar uma lista de valores. Create a list of values.
        /// Existe também um método do "Array" chamado "Copy" (Array.Copy), é outra forma de fazer.
        /// There is also an Array method called "Copy" (Array.Copy), that's another way to do it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCriaListaValoresNumerico_Click(object sender, EventArgs e)
        {
            string strListaValorNumerico = txtListaValorNumerico.Text;
            string[] arrstrListaValorNumerico = strListaValorNumerico.Split(',');
            int[] arrIntListaValorNumerico = new int[] { };
            int intTamanho = arrstrListaValorNumerico.GetLength(0);
            int i = 0;
            List<string> strNumeros = clsMetGen.CriaLista<string>(arrstrListaValorNumerico);

            Array.Resize(ref arrIntListaValorNumerico, intTamanho);

            foreach (string strNumero in strNumeros)
            {
                if (strNumero.Trim() != "")
                    arrIntListaValorNumerico[i] = Convert.ToInt32(strNumero.Trim());

                i++;
            }

            // List<int> numeros = clsMetGen.CriaLista<int>(1, 2, 3, 4, 6, 7);
            List<int> numeros = clsMetGen.CriaLista<int>(arrIntListaValorNumerico);

            lvwListaValorNumerico.Items.Clear();

            foreach (int numero in numeros)
            {
                lvwListaValorNumerico.Items.Add(Convert.ToString(numero).Trim());
            }
        }

        private void btnCriaListaValoresAlfanumerico_Click(object sender, EventArgs e)
        {
            string strListaValorAlfanumerico = txtListaValorAlfanumerico.Text;
            string[] arrstrListaValorAlfanumerico = strListaValorAlfanumerico.Split(',');

            List<string> nomes = clsMetGen.CriaLista<string>(arrstrListaValorAlfanumerico);

            lvwListaValorAlfanumerico.Items.Clear();

            foreach (string nome in nomes)
            {
                lvwListaValorAlfanumerico.Items.Add(nome.Trim());
            }
        }

        #endregion

    }
}
