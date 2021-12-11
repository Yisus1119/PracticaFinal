
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
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.BuscarTxt = new System.Windows.Forms.TextBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.InsertarBtn = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.Estado = new System.Windows.Forms.StatusBarPanel();
            this.TimeBar = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(812, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tabla de datos";
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBtn.Location = new System.Drawing.Point(717, 29);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(105, 27);
            this.BuscarBtn.TabIndex = 9;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(606, 32);
            this.BuscarTxt.Name = "BuscarTxt";
            this.BuscarTxt.Size = new System.Drawing.Size(105, 20);
            this.BuscarTxt.TabIndex = 8;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Location = new System.Drawing.Point(717, 349);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(105, 35);
            this.EliminarBtn.TabIndex = 12;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBtn.Location = new System.Drawing.Point(606, 349);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(105, 35);
            this.EditarBtn.TabIndex = 11;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            // 
            // InsertarBtn
            // 
            this.InsertarBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertarBtn.Location = new System.Drawing.Point(495, 349);
            this.InsertarBtn.Name = "InsertarBtn";
            this.InsertarBtn.Size = new System.Drawing.Size(105, 35);
            this.InsertarBtn.TabIndex = 10;
            this.InsertarBtn.Text = "Insertar";
            this.InsertarBtn.UseVisualStyleBackColor = true;
            this.InsertarBtn.Click += new System.EventHandler(this.InsertarBtn_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 429);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.Estado,
            this.TimeBar});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(834, 22);
            this.statusBar.TabIndex = 13;
            this.statusBar.Text = "statusBar";
            // 
            // Estado
            // 
            this.Estado.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Estado.Name = "Estado";
            this.Estado.Text = "Usuario: logueado";
            // 
            // TimeBar
            // 
            this.TimeBar.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Width = 715;
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
            this.ClientSize = new System.Drawing.Size(834, 451);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.InsertarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.BuscarTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.TextBox BuscarTxt;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button InsertarBtn;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.StatusBarPanel Estado;
        internal System.Windows.Forms.StatusBarPanel TimeBar;
        private System.Windows.Forms.Timer timer1;
    }
}

