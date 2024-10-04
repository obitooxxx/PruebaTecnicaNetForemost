namespace PruebaTecnicaNetForemost
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_Gestores = new DataGridView();
            btn_AsignarSaldos = new Button();
            btn_ConexToDB = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Gestores).BeginInit();
            SuspendLayout();
            // 
            // dgv_Gestores
            // 
            dgv_Gestores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Gestores.Location = new Point(33, 45);
            dgv_Gestores.Name = "dgv_Gestores";
            dgv_Gestores.Size = new Size(572, 169);
            dgv_Gestores.TabIndex = 0;
            // 
            // btn_AsignarSaldos
            // 
            btn_AsignarSaldos.Location = new Point(239, 327);
            btn_AsignarSaldos.Name = "btn_AsignarSaldos";
            btn_AsignarSaldos.Size = new Size(131, 44);
            btn_AsignarSaldos.TabIndex = 1;
            btn_AsignarSaldos.Text = "Asignar Saldos";
            btn_AsignarSaldos.UseVisualStyleBackColor = true;
            btn_AsignarSaldos.Click += button1_Click;
            // 
            // btn_ConexToDB
            // 
            btn_ConexToDB.Location = new Point(239, 243);
            btn_ConexToDB.Name = "btn_ConexToDB";
            btn_ConexToDB.Size = new Size(131, 44);
            btn_ConexToDB.TabIndex = 2;
            btn_ConexToDB.Text = "Conectar Base de Datos";
            btn_ConexToDB.UseVisualStyleBackColor = true;
            btn_ConexToDB.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 427);
            Controls.Add(btn_ConexToDB);
            Controls.Add(btn_AsignarSaldos);
            Controls.Add(dgv_Gestores);
            Name = "Form1";
            Text = "Gestores";
            ((System.ComponentModel.ISupportInitialize)dgv_Gestores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Gestores;
        private Button btn_AsignarSaldos;
        private Button btn_ConexToDB;
    }
}
