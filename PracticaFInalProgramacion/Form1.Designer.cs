
namespace PracticaFInalProgramacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.InsertarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.Estado = new System.Windows.Forms.StatusBarPanel();
            this.Time = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(672, 29);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 29);
            this.BuscarBtn.TabIndex = 1;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(566, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Location = new System.Drawing.Point(567, 343);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(87, 41);
            this.EditarBtn.TabIndex = 3;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            // 
            // InsertarBtn
            // 
            this.InsertarBtn.Location = new System.Drawing.Point(474, 343);
            this.InsertarBtn.Name = "InsertarBtn";
            this.InsertarBtn.Size = new System.Drawing.Size(87, 41);
            this.InsertarBtn.TabIndex = 4;
            this.InsertarBtn.Text = "Insertar";
            this.InsertarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(660, 343);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(87, 41);
            this.EliminarBtn.TabIndex = 5;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tabla de datos";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 395);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.Estado,
            this.Time});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(759, 22);
            this.statusBar1.TabIndex = 7;
            this.statusBar1.Text = "statusBar1";
            // 
            // Estado
            // 
            this.Estado.Name = "Estado";
            this.Estado.Text = "Usuario Logeado";
            this.Estado.Width = 500;
            // 
            // Time
            // 
            this.Time.Name = "Time";
            this.Time.Text = "ffa";
            this.Time.Width = 300;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 417);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.InsertarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button InsertarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel Estado;
        private System.Windows.Forms.StatusBarPanel Time;
        private System.Windows.Forms.Timer timer1;
    }
}

