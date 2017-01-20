namespace wfaMetodosGenericos
{
    partial class frmMetodosGenericos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExemplo1 = new System.Windows.Forms.TabPage();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.btnTrocaDeLugar = new System.Windows.Forms.Button();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.lblTrocaDeLugar = new System.Windows.Forms.Label();
            this.tabExemplo2 = new System.Windows.Forms.TabPage();
            this.lblMaiorValorNumerico = new System.Windows.Forms.Label();
            this.txtMaiorValorN = new System.Windows.Forms.TextBox();
            this.btnComparaValoresNumericos = new System.Windows.Forms.Button();
            this.lblValorN2 = new System.Windows.Forms.Label();
            this.lblValorN1 = new System.Windows.Forms.Label();
            this.txtValorN2 = new System.Windows.Forms.TextBox();
            this.txtValorN1 = new System.Windows.Forms.TextBox();
            this.lblComparaValoresNumericos = new System.Windows.Forms.Label();
            this.lblMaiorValorAlfanumerico = new System.Windows.Forms.Label();
            this.txtMaiorValorA = new System.Windows.Forms.TextBox();
            this.btnComparaValoresAlfanumericos = new System.Windows.Forms.Button();
            this.lblValorA2 = new System.Windows.Forms.Label();
            this.lblValorA1 = new System.Windows.Forms.Label();
            this.txtValorA2 = new System.Windows.Forms.TextBox();
            this.txtValorA1 = new System.Windows.Forms.TextBox();
            this.lblComparaValoresAlfanumericos = new System.Windows.Forms.Label();
            this.tabExemplo3 = new System.Windows.Forms.TabPage();
            this.btnCriaListaValoresNumerico = new System.Windows.Forms.Button();
            this.btnCriaListaValoresAlfanumerico = new System.Windows.Forms.Button();
            this.lblListaValoresAlfanumericos = new System.Windows.Forms.Label();
            this.lvwListaValorAlfanumerico = new System.Windows.Forms.ListView();
            this.lblListaValoresNumericos = new System.Windows.Forms.Label();
            this.lvwListaValorNumerico = new System.Windows.Forms.ListView();
            this.lblListaValorAlfanumerico = new System.Windows.Forms.Label();
            this.lblListaValorNumerico = new System.Windows.Forms.Label();
            this.txtListaValorAlfanumerico = new System.Windows.Forms.TextBox();
            this.txtListaValorNumerico = new System.Windows.Forms.TextBox();
            this.lblCriaLista = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabExemplo1.SuspendLayout();
            this.tabExemplo2.SuspendLayout();
            this.tabExemplo3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExemplo1);
            this.tabControl1.Controls.Add(this.tabExemplo2);
            this.tabControl1.Controls.Add(this.tabExemplo3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 349);
            this.tabControl1.TabIndex = 17;
            // 
            // tabExemplo1
            // 
            this.tabExemplo1.Controls.Add(this.lblTexto2);
            this.tabExemplo1.Controls.Add(this.lblTexto1);
            this.tabExemplo1.Controls.Add(this.btnTrocaDeLugar);
            this.tabExemplo1.Controls.Add(this.txtTexto2);
            this.tabExemplo1.Controls.Add(this.txtTexto1);
            this.tabExemplo1.Controls.Add(this.lblTrocaDeLugar);
            this.tabExemplo1.Location = new System.Drawing.Point(4, 22);
            this.tabExemplo1.Name = "tabExemplo1";
            this.tabExemplo1.Padding = new System.Windows.Forms.Padding(3);
            this.tabExemplo1.Size = new System.Drawing.Size(478, 323);
            this.tabExemplo1.TabIndex = 0;
            this.tabExemplo1.Text = "Exemplo 1 - Sample 1";
            this.tabExemplo1.UseVisualStyleBackColor = true;
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Location = new System.Drawing.Point(3, 64);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(46, 13);
            this.lblTexto2.TabIndex = 12;
            this.lblTexto2.Text = "Texto 2:";
            // 
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Location = new System.Drawing.Point(3, 38);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(46, 13);
            this.lblTexto1.TabIndex = 11;
            this.lblTexto1.Text = "Texto 1:";
            // 
            // btnTrocaDeLugar
            // 
            this.btnTrocaDeLugar.Location = new System.Drawing.Point(55, 87);
            this.btnTrocaDeLugar.Name = "btnTrocaDeLugar";
            this.btnTrocaDeLugar.Size = new System.Drawing.Size(216, 23);
            this.btnTrocaDeLugar.TabIndex = 10;
            this.btnTrocaDeLugar.Text = "&Troca de Lugar - Change of Location";
            this.btnTrocaDeLugar.UseVisualStyleBackColor = true;
            this.btnTrocaDeLugar.Click += new System.EventHandler(this.btnTrocaDeLugar_Click);
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(55, 61);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(398, 20);
            this.txtTexto2.TabIndex = 9;
            this.txtTexto2.Text = "Teste2";
            // 
            // txtTexto1
            // 
            this.txtTexto1.Location = new System.Drawing.Point(55, 35);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(398, 20);
            this.txtTexto1.TabIndex = 8;
            this.txtTexto1.Text = "Teste1";
            // 
            // lblTrocaDeLugar
            // 
            this.lblTrocaDeLugar.AutoSize = true;
            this.lblTrocaDeLugar.Location = new System.Drawing.Point(3, 12);
            this.lblTrocaDeLugar.Name = "lblTrocaDeLugar";
            this.lblTrocaDeLugar.Size = new System.Drawing.Size(188, 13);
            this.lblTrocaDeLugar.TabIndex = 7;
            this.lblTrocaDeLugar.Text = "Troca de Lugar: - Change of Location:";
            // 
            // tabExemplo2
            // 
            this.tabExemplo2.Controls.Add(this.lblMaiorValorNumerico);
            this.tabExemplo2.Controls.Add(this.txtMaiorValorN);
            this.tabExemplo2.Controls.Add(this.btnComparaValoresNumericos);
            this.tabExemplo2.Controls.Add(this.lblValorN2);
            this.tabExemplo2.Controls.Add(this.lblValorN1);
            this.tabExemplo2.Controls.Add(this.txtValorN2);
            this.tabExemplo2.Controls.Add(this.txtValorN1);
            this.tabExemplo2.Controls.Add(this.lblComparaValoresNumericos);
            this.tabExemplo2.Controls.Add(this.lblMaiorValorAlfanumerico);
            this.tabExemplo2.Controls.Add(this.txtMaiorValorA);
            this.tabExemplo2.Controls.Add(this.btnComparaValoresAlfanumericos);
            this.tabExemplo2.Controls.Add(this.lblValorA2);
            this.tabExemplo2.Controls.Add(this.lblValorA1);
            this.tabExemplo2.Controls.Add(this.txtValorA2);
            this.tabExemplo2.Controls.Add(this.txtValorA1);
            this.tabExemplo2.Controls.Add(this.lblComparaValoresAlfanumericos);
            this.tabExemplo2.Location = new System.Drawing.Point(4, 22);
            this.tabExemplo2.Name = "tabExemplo2";
            this.tabExemplo2.Padding = new System.Windows.Forms.Padding(3);
            this.tabExemplo2.Size = new System.Drawing.Size(478, 323);
            this.tabExemplo2.TabIndex = 1;
            this.tabExemplo2.Text = "Exemplo 2 - Sample 2";
            this.tabExemplo2.UseVisualStyleBackColor = true;
            // 
            // lblMaiorValorNumerico
            // 
            this.lblMaiorValorNumerico.AutoSize = true;
            this.lblMaiorValorNumerico.Location = new System.Drawing.Point(9, 287);
            this.lblMaiorValorNumerico.Name = "lblMaiorValorNumerico";
            this.lblMaiorValorNumerico.Size = new System.Drawing.Size(47, 13);
            this.lblMaiorValorNumerico.TabIndex = 27;
            this.lblMaiorValorNumerico.Text = "Maior N:";
            // 
            // txtMaiorValorN
            // 
            this.txtMaiorValorN.Location = new System.Drawing.Point(58, 284);
            this.txtMaiorValorN.Name = "txtMaiorValorN";
            this.txtMaiorValorN.Size = new System.Drawing.Size(395, 20);
            this.txtMaiorValorN.TabIndex = 26;
            // 
            // btnComparaValoresNumericos
            // 
            this.btnComparaValoresNumericos.Location = new System.Drawing.Point(58, 255);
            this.btnComparaValoresNumericos.Name = "btnComparaValoresNumericos";
            this.btnComparaValoresNumericos.Size = new System.Drawing.Size(395, 23);
            this.btnComparaValoresNumericos.TabIndex = 25;
            this.btnComparaValoresNumericos.Text = "&Compara Valores Numéricos - Compare Numeric Values";
            this.btnComparaValoresNumericos.UseVisualStyleBackColor = true;
            this.btnComparaValoresNumericos.Click += new System.EventHandler(this.btnComparaValoresNumericos_Click);
            // 
            // lblValorN2
            // 
            this.lblValorN2.AutoSize = true;
            this.lblValorN2.Location = new System.Drawing.Point(6, 232);
            this.lblValorN2.Name = "lblValorN2";
            this.lblValorN2.Size = new System.Drawing.Size(51, 13);
            this.lblValorN2.TabIndex = 24;
            this.lblValorN2.Text = "Valor N2:";
            // 
            // lblValorN1
            // 
            this.lblValorN1.AutoSize = true;
            this.lblValorN1.Location = new System.Drawing.Point(6, 206);
            this.lblValorN1.Name = "lblValorN1";
            this.lblValorN1.Size = new System.Drawing.Size(51, 13);
            this.lblValorN1.TabIndex = 23;
            this.lblValorN1.Text = "Valor N1:";
            // 
            // txtValorN2
            // 
            this.txtValorN2.Location = new System.Drawing.Point(58, 229);
            this.txtValorN2.Name = "txtValorN2";
            this.txtValorN2.Size = new System.Drawing.Size(395, 20);
            this.txtValorN2.TabIndex = 22;
            this.txtValorN2.Text = "23";
            this.txtValorN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorN2_KeyPress);
            // 
            // txtValorN1
            // 
            this.txtValorN1.Location = new System.Drawing.Point(58, 203);
            this.txtValorN1.Name = "txtValorN1";
            this.txtValorN1.Size = new System.Drawing.Size(395, 20);
            this.txtValorN1.TabIndex = 21;
            this.txtValorN1.Text = "199999";
            this.txtValorN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorN1_KeyPress);
            // 
            // lblComparaValoresNumericos
            // 
            this.lblComparaValoresNumericos.AutoSize = true;
            this.lblComparaValoresNumericos.Location = new System.Drawing.Point(6, 180);
            this.lblComparaValoresNumericos.Name = "lblComparaValoresNumericos";
            this.lblComparaValoresNumericos.Size = new System.Drawing.Size(379, 13);
            this.lblComparaValoresNumericos.TabIndex = 20;
            this.lblComparaValoresNumericos.Text = "Compara Qualquer Numérico (Valor Cheio): - Compare Any Number (Full Value):";
            // 
            // lblMaiorValorAlfanumerico
            // 
            this.lblMaiorValorAlfanumerico.AutoSize = true;
            this.lblMaiorValorAlfanumerico.Location = new System.Drawing.Point(6, 139);
            this.lblMaiorValorAlfanumerico.Name = "lblMaiorValorAlfanumerico";
            this.lblMaiorValorAlfanumerico.Size = new System.Drawing.Size(46, 13);
            this.lblMaiorValorAlfanumerico.TabIndex = 19;
            this.lblMaiorValorAlfanumerico.Text = "Maior A:";
            // 
            // txtMaiorValorA
            // 
            this.txtMaiorValorA.Location = new System.Drawing.Point(55, 136);
            this.txtMaiorValorA.Name = "txtMaiorValorA";
            this.txtMaiorValorA.Size = new System.Drawing.Size(398, 20);
            this.txtMaiorValorA.TabIndex = 18;
            // 
            // btnComparaValoresAlfanumericos
            // 
            this.btnComparaValoresAlfanumericos.Location = new System.Drawing.Point(55, 107);
            this.btnComparaValoresAlfanumericos.Name = "btnComparaValoresAlfanumericos";
            this.btnComparaValoresAlfanumericos.Size = new System.Drawing.Size(398, 23);
            this.btnComparaValoresAlfanumericos.TabIndex = 17;
            this.btnComparaValoresAlfanumericos.Text = "&Compara Valores Alfanuméricos - Compares Alphanumeric Values";
            this.btnComparaValoresAlfanumericos.UseVisualStyleBackColor = true;
            this.btnComparaValoresAlfanumericos.Click += new System.EventHandler(this.btnComparaValoresAlfanumericos_Click);
            // 
            // lblValorA2
            // 
            this.lblValorA2.AutoSize = true;
            this.lblValorA2.Location = new System.Drawing.Point(3, 84);
            this.lblValorA2.Name = "lblValorA2";
            this.lblValorA2.Size = new System.Drawing.Size(50, 13);
            this.lblValorA2.TabIndex = 16;
            this.lblValorA2.Text = "Valor A2:";
            // 
            // lblValorA1
            // 
            this.lblValorA1.AutoSize = true;
            this.lblValorA1.Location = new System.Drawing.Point(3, 58);
            this.lblValorA1.Name = "lblValorA1";
            this.lblValorA1.Size = new System.Drawing.Size(50, 13);
            this.lblValorA1.TabIndex = 15;
            this.lblValorA1.Text = "Valor A1:";
            // 
            // txtValorA2
            // 
            this.txtValorA2.Location = new System.Drawing.Point(55, 81);
            this.txtValorA2.Name = "txtValorA2";
            this.txtValorA2.Size = new System.Drawing.Size(398, 20);
            this.txtValorA2.TabIndex = 14;
            this.txtValorA2.Text = "Teste23";
            // 
            // txtValorA1
            // 
            this.txtValorA1.Location = new System.Drawing.Point(55, 55);
            this.txtValorA1.Name = "txtValorA1";
            this.txtValorA1.Size = new System.Drawing.Size(398, 20);
            this.txtValorA1.TabIndex = 13;
            this.txtValorA1.Text = "Teste199999";
            // 
            // lblComparaValoresAlfanumericos
            // 
            this.lblComparaValoresAlfanumericos.Location = new System.Drawing.Point(3, 12);
            this.lblComparaValoresAlfanumericos.Name = "lblComparaValoresAlfanumericos";
            this.lblComparaValoresAlfanumericos.Size = new System.Drawing.Size(279, 31);
            this.lblComparaValoresAlfanumericos.TabIndex = 12;
            this.lblComparaValoresAlfanumericos.Text = "Compara Qualquer Alfanumérico (Caracter por Caracter): - Compare Any Alphanumeric" +
    " (Character by Character):";
            // 
            // tabExemplo3
            // 
            this.tabExemplo3.Controls.Add(this.btnCriaListaValoresNumerico);
            this.tabExemplo3.Controls.Add(this.btnCriaListaValoresAlfanumerico);
            this.tabExemplo3.Controls.Add(this.lblListaValoresAlfanumericos);
            this.tabExemplo3.Controls.Add(this.lvwListaValorAlfanumerico);
            this.tabExemplo3.Controls.Add(this.lblListaValoresNumericos);
            this.tabExemplo3.Controls.Add(this.lvwListaValorNumerico);
            this.tabExemplo3.Controls.Add(this.lblListaValorAlfanumerico);
            this.tabExemplo3.Controls.Add(this.lblListaValorNumerico);
            this.tabExemplo3.Controls.Add(this.txtListaValorAlfanumerico);
            this.tabExemplo3.Controls.Add(this.txtListaValorNumerico);
            this.tabExemplo3.Controls.Add(this.lblCriaLista);
            this.tabExemplo3.Location = new System.Drawing.Point(4, 22);
            this.tabExemplo3.Name = "tabExemplo3";
            this.tabExemplo3.Size = new System.Drawing.Size(478, 323);
            this.tabExemplo3.TabIndex = 2;
            this.tabExemplo3.Text = "Exemplo 3 - Sample 3";
            this.tabExemplo3.UseVisualStyleBackColor = true;
            // 
            // btnCriaListaValoresNumerico
            // 
            this.btnCriaListaValoresNumerico.Location = new System.Drawing.Point(55, 292);
            this.btnCriaListaValoresNumerico.Name = "btnCriaListaValoresNumerico";
            this.btnCriaListaValoresNumerico.Size = new System.Drawing.Size(192, 23);
            this.btnCriaListaValoresNumerico.TabIndex = 27;
            this.btnCriaListaValoresNumerico.Text = "&Cria Lista de Valores Numéricos";
            this.btnCriaListaValoresNumerico.UseVisualStyleBackColor = true;
            this.btnCriaListaValoresNumerico.Click += new System.EventHandler(this.btnCriaListaValoresNumerico_Click);
            // 
            // btnCriaListaValoresAlfanumerico
            // 
            this.btnCriaListaValoresAlfanumerico.Location = new System.Drawing.Point(261, 292);
            this.btnCriaListaValoresAlfanumerico.Name = "btnCriaListaValoresAlfanumerico";
            this.btnCriaListaValoresAlfanumerico.Size = new System.Drawing.Size(192, 23);
            this.btnCriaListaValoresAlfanumerico.TabIndex = 26;
            this.btnCriaListaValoresAlfanumerico.Text = "&Cria Lista de Valores Alfanuméricos";
            this.btnCriaListaValoresAlfanumerico.UseVisualStyleBackColor = true;
            this.btnCriaListaValoresAlfanumerico.Click += new System.EventHandler(this.btnCriaListaValoresAlfanumerico_Click);
            // 
            // lblListaValoresAlfanumericos
            // 
            this.lblListaValoresAlfanumericos.AutoSize = true;
            this.lblListaValoresAlfanumericos.Location = new System.Drawing.Point(258, 103);
            this.lblListaValoresAlfanumericos.Name = "lblListaValoresAlfanumericos";
            this.lblListaValoresAlfanumericos.Size = new System.Drawing.Size(139, 13);
            this.lblListaValoresAlfanumericos.TabIndex = 25;
            this.lblListaValoresAlfanumericos.Text = "Lista Valores Alfanuméricos:";
            // 
            // lvwListaValorAlfanumerico
            // 
            this.lvwListaValorAlfanumerico.Location = new System.Drawing.Point(261, 119);
            this.lvwListaValorAlfanumerico.Name = "lvwListaValorAlfanumerico";
            this.lvwListaValorAlfanumerico.Size = new System.Drawing.Size(192, 167);
            this.lvwListaValorAlfanumerico.TabIndex = 24;
            this.lvwListaValorAlfanumerico.UseCompatibleStateImageBehavior = false;
            this.lvwListaValorAlfanumerico.View = System.Windows.Forms.View.List;
            // 
            // lblListaValoresNumericos
            // 
            this.lblListaValoresNumericos.AutoSize = true;
            this.lblListaValoresNumericos.Location = new System.Drawing.Point(52, 103);
            this.lblListaValoresNumericos.Name = "lblListaValoresNumericos";
            this.lblListaValoresNumericos.Size = new System.Drawing.Size(123, 13);
            this.lblListaValoresNumericos.TabIndex = 23;
            this.lblListaValoresNumericos.Text = "Lista Valores Numéricos:";
            // 
            // lvwListaValorNumerico
            // 
            this.lvwListaValorNumerico.Location = new System.Drawing.Point(55, 119);
            this.lvwListaValorNumerico.MultiSelect = false;
            this.lvwListaValorNumerico.Name = "lvwListaValorNumerico";
            this.lvwListaValorNumerico.Size = new System.Drawing.Size(192, 167);
            this.lvwListaValorNumerico.TabIndex = 22;
            this.lvwListaValorNumerico.UseCompatibleStateImageBehavior = false;
            this.lvwListaValorNumerico.View = System.Windows.Forms.View.List;
            // 
            // lblListaValorAlfanumerico
            // 
            this.lblListaValorAlfanumerico.AutoSize = true;
            this.lblListaValorAlfanumerico.Location = new System.Drawing.Point(3, 78);
            this.lblListaValorAlfanumerico.Name = "lblListaValorAlfanumerico";
            this.lblListaValorAlfanumerico.Size = new System.Drawing.Size(44, 13);
            this.lblListaValorAlfanumerico.TabIndex = 21;
            this.lblListaValorAlfanumerico.Text = "Valor A:";
            // 
            // lblListaValorNumerico
            // 
            this.lblListaValorNumerico.AutoSize = true;
            this.lblListaValorNumerico.Location = new System.Drawing.Point(3, 52);
            this.lblListaValorNumerico.Name = "lblListaValorNumerico";
            this.lblListaValorNumerico.Size = new System.Drawing.Size(45, 13);
            this.lblListaValorNumerico.TabIndex = 20;
            this.lblListaValorNumerico.Text = "Valor N:";
            // 
            // txtListaValorAlfanumerico
            // 
            this.txtListaValorAlfanumerico.Location = new System.Drawing.Point(55, 75);
            this.txtListaValorAlfanumerico.Name = "txtListaValorAlfanumerico";
            this.txtListaValorAlfanumerico.Size = new System.Drawing.Size(398, 20);
            this.txtListaValorAlfanumerico.TabIndex = 19;
            this.txtListaValorAlfanumerico.Text = "Macoratti,Jefferson, Miriam ,Janice , ,   Tunusat , FoxMan, 42";
            // 
            // txtListaValorNumerico
            // 
            this.txtListaValorNumerico.Location = new System.Drawing.Point(55, 49);
            this.txtListaValorNumerico.Name = "txtListaValorNumerico";
            this.txtListaValorNumerico.Size = new System.Drawing.Size(398, 20);
            this.txtListaValorNumerico.TabIndex = 18;
            this.txtListaValorNumerico.Text = "1,2, 3 ,4 , , 6, 7,,, 8";
            this.txtListaValorNumerico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtListaValorNumerico_KeyPress);
            // 
            // lblCriaLista
            // 
            this.lblCriaLista.Location = new System.Drawing.Point(3, 9);
            this.lblCriaLista.Name = "lblCriaLista";
            this.lblCriaLista.Size = new System.Drawing.Size(437, 26);
            this.lblCriaLista.TabIndex = 17;
            this.lblCriaLista.Text = "Cria Lista (coloque os valores separados por vírgula e não se preocupe com os esp" +
    "aços): - Create List (enter values separated by commas and do not worry about sp" +
    "aces):";
            // 
            // frmMetodosGenericos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 373);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMetodosGenericos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Métodos Genéricos - 3 Exemplos - http://www.macoratti.net/15/04/c_mgen1.htm";
            this.tabControl1.ResumeLayout(false);
            this.tabExemplo1.ResumeLayout(false);
            this.tabExemplo1.PerformLayout();
            this.tabExemplo2.ResumeLayout(false);
            this.tabExemplo2.PerformLayout();
            this.tabExemplo3.ResumeLayout(false);
            this.tabExemplo3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExemplo1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Button btnTrocaDeLugar;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.Label lblTrocaDeLugar;
        private System.Windows.Forms.TabPage tabExemplo2;
        private System.Windows.Forms.Button btnComparaValoresAlfanumericos;
        private System.Windows.Forms.Label lblValorA2;
        private System.Windows.Forms.Label lblValorA1;
        private System.Windows.Forms.TextBox txtValorA2;
        private System.Windows.Forms.TextBox txtValorA1;
        private System.Windows.Forms.Label lblComparaValoresAlfanumericos;
        private System.Windows.Forms.TabPage tabExemplo3;
        private System.Windows.Forms.Label lblListaValoresAlfanumericos;
        private System.Windows.Forms.ListView lvwListaValorAlfanumerico;
        private System.Windows.Forms.Label lblListaValoresNumericos;
        private System.Windows.Forms.ListView lvwListaValorNumerico;
        private System.Windows.Forms.Label lblListaValorAlfanumerico;
        private System.Windows.Forms.Label lblListaValorNumerico;
        private System.Windows.Forms.TextBox txtListaValorAlfanumerico;
        private System.Windows.Forms.TextBox txtListaValorNumerico;
        private System.Windows.Forms.Label lblCriaLista;
        private System.Windows.Forms.Button btnCriaListaValoresAlfanumerico;
        private System.Windows.Forms.Label lblMaiorValorAlfanumerico;
        private System.Windows.Forms.TextBox txtMaiorValorA;
        private System.Windows.Forms.Label lblMaiorValorNumerico;
        private System.Windows.Forms.TextBox txtMaiorValorN;
        private System.Windows.Forms.Button btnComparaValoresNumericos;
        private System.Windows.Forms.Label lblValorN2;
        private System.Windows.Forms.Label lblValorN1;
        private System.Windows.Forms.TextBox txtValorN2;
        private System.Windows.Forms.TextBox txtValorN1;
        private System.Windows.Forms.Label lblComparaValoresNumericos;
        private System.Windows.Forms.Button btnCriaListaValoresNumerico;

    }
}

