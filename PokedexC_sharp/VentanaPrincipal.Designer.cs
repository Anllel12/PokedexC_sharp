namespace PokedexC_sharp
{
    partial class VentanaPrincipal
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
            this.imagen = new System.Windows.Forms.PictureBox();
            this.anterior = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Button();
            this.especie = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.Button();
            this.habilidad = new System.Windows.Forms.Button();
            this.habitat = new System.Windows.Forms.Button();
            this.Altura = new System.Windows.Forms.Button();
            this.movimiento2_3 = new System.Windows.Forms.Button();
            this.posEvolucion = new System.Windows.Forms.Button();
            this.movimiento1_2 = new System.Windows.Forms.Button();
            this.preEvolucion = new System.Windows.Forms.Button();
            this.peso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(94, 267);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(420, 275);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 0;
            this.imagen.TabStop = false;
            // 
            // anterior
            // 
            this.anterior.BackColor = System.Drawing.Color.Transparent;
            this.anterior.FlatAppearance.BorderSize = 0;
            this.anterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anterior.Location = new System.Drawing.Point(367, 682);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(41, 38);
            this.anterior.TabIndex = 1;
            this.anterior.UseVisualStyleBackColor = false;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // siguiente
            // 
            this.siguiente.BackColor = System.Drawing.Color.Transparent;
            this.siguiente.FlatAppearance.BorderSize = 0;
            this.siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siguiente.ForeColor = System.Drawing.Color.Black;
            this.siguiente.Location = new System.Drawing.Point(445, 682);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(43, 38);
            this.siguiente.TabIndex = 2;
            this.siguiente.UseVisualStyleBackColor = false;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(711, 294);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(428, 108);
            this.label.TabIndex = 3;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Transparent;
            this.descripcion.FlatAppearance.BorderSize = 0;
            this.descripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.descripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.descripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(94, 710);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(197, 47);
            this.descripcion.TabIndex = 4;
            this.descripcion.Text = "Descripcion";
            this.descripcion.UseVisualStyleBackColor = false;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Transparent;
            this.especie.FlatAppearance.BorderSize = 0;
            this.especie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.especie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.especie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.especie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.Location = new System.Drawing.Point(716, 418);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(79, 47);
            this.especie.TabIndex = 5;
            this.especie.Text = "Especie";
            this.especie.UseVisualStyleBackColor = false;
            this.especie.Click += new System.EventHandler(this.especie_Click);
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.Transparent;
            this.tipo.FlatAppearance.BorderSize = 0;
            this.tipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.tipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(801, 418);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(79, 47);
            this.tipo.TabIndex = 6;
            this.tipo.Text = "Tipo";
            this.tipo.UseVisualStyleBackColor = false;
            this.tipo.Click += new System.EventHandler(this.tipo_Click);
            // 
            // habilidad
            // 
            this.habilidad.BackColor = System.Drawing.Color.Transparent;
            this.habilidad.FlatAppearance.BorderSize = 0;
            this.habilidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.habilidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.habilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidad.Location = new System.Drawing.Point(886, 418);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(79, 47);
            this.habilidad.TabIndex = 7;
            this.habilidad.Text = "Habilidad";
            this.habilidad.UseVisualStyleBackColor = false;
            this.habilidad.Click += new System.EventHandler(this.habilidad_Click);
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.Color.Transparent;
            this.habitat.FlatAppearance.BorderSize = 0;
            this.habitat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.habitat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.habitat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.habitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitat.Location = new System.Drawing.Point(969, 418);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(79, 47);
            this.habitat.TabIndex = 8;
            this.habitat.Text = "Habitat";
            this.habitat.UseVisualStyleBackColor = false;
            this.habitat.Click += new System.EventHandler(this.habitat_Click);
            // 
            // Altura
            // 
            this.Altura.BackColor = System.Drawing.Color.Transparent;
            this.Altura.FlatAppearance.BorderSize = 0;
            this.Altura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Altura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Altura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Altura.Location = new System.Drawing.Point(1054, 418);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(79, 47);
            this.Altura.TabIndex = 9;
            this.Altura.Text = "Altura";
            this.Altura.UseVisualStyleBackColor = false;
            this.Altura.Click += new System.EventHandler(this.Altura_Click);
            // 
            // movimiento2_3
            // 
            this.movimiento2_3.BackColor = System.Drawing.Color.Transparent;
            this.movimiento2_3.FlatAppearance.BorderSize = 0;
            this.movimiento2_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.movimiento2_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.movimiento2_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movimiento2_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento2_3.Location = new System.Drawing.Point(861, 574);
            this.movimiento2_3.Name = "movimiento2_3";
            this.movimiento2_3.Size = new System.Drawing.Size(126, 40);
            this.movimiento2_3.TabIndex = 14;
            this.movimiento2_3.Text = "Movimiento 2 y 3";
            this.movimiento2_3.UseVisualStyleBackColor = false;
            this.movimiento2_3.Click += new System.EventHandler(this.movimiento2_Click);
            // 
            // posEvolucion
            // 
            this.posEvolucion.BackColor = System.Drawing.Color.Transparent;
            this.posEvolucion.FlatAppearance.BorderSize = 0;
            this.posEvolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.posEvolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.posEvolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.posEvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posEvolucion.Location = new System.Drawing.Point(969, 471);
            this.posEvolucion.Name = "posEvolucion";
            this.posEvolucion.Size = new System.Drawing.Size(164, 62);
            this.posEvolucion.TabIndex = 13;
            this.posEvolucion.Text = "posEvolucion";
            this.posEvolucion.UseVisualStyleBackColor = false;
            this.posEvolucion.Click += new System.EventHandler(this.posEvolucion_Click);
            // 
            // movimiento1_2
            // 
            this.movimiento1_2.BackColor = System.Drawing.Color.Transparent;
            this.movimiento1_2.FlatAppearance.BorderSize = 0;
            this.movimiento1_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.movimiento1_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.movimiento1_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movimiento1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento1_2.Location = new System.Drawing.Point(716, 574);
            this.movimiento1_2.Name = "movimiento1_2";
            this.movimiento1_2.Size = new System.Drawing.Size(125, 40);
            this.movimiento1_2.TabIndex = 12;
            this.movimiento1_2.Text = "Movimiento 1 y 2";
            this.movimiento1_2.UseVisualStyleBackColor = false;
            this.movimiento1_2.Click += new System.EventHandler(this.movimiento1_Click);
            // 
            // preEvolucion
            // 
            this.preEvolucion.BackColor = System.Drawing.Color.Transparent;
            this.preEvolucion.FlatAppearance.BorderSize = 0;
            this.preEvolucion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.preEvolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.preEvolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preEvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preEvolucion.Location = new System.Drawing.Point(801, 471);
            this.preEvolucion.Name = "preEvolucion";
            this.preEvolucion.Size = new System.Drawing.Size(164, 62);
            this.preEvolucion.TabIndex = 11;
            this.preEvolucion.Text = "PreEvolucion";
            this.preEvolucion.UseVisualStyleBackColor = false;
            this.preEvolucion.Click += new System.EventHandler(this.preEvolucion_Click);
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.Color.Transparent;
            this.peso.FlatAppearance.BorderSize = 0;
            this.peso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.peso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.peso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(716, 471);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(79, 62);
            this.peso.TabIndex = 10;
            this.peso.Text = "Peso";
            this.peso.UseVisualStyleBackColor = false;
            this.peso.Click += new System.EventHandler(this.peso_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokedexC_sharp.Properties.Resources.Pokedex;
            this.ClientSize = new System.Drawing.Size(1217, 838);
            this.Controls.Add(this.movimiento2_3);
            this.Controls.Add(this.posEvolucion);
            this.Controls.Add(this.movimiento1_2);
            this.Controls.Add(this.preEvolucion);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.siguiente);
            this.Controls.Add(this.label);
            this.Controls.Add(this.anterior);
            this.Controls.Add(this.imagen);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button descripcion;
        private System.Windows.Forms.Button especie;
        private System.Windows.Forms.Button tipo;
        private System.Windows.Forms.Button habilidad;
        private System.Windows.Forms.Button habitat;
        private System.Windows.Forms.Button Altura;
        private System.Windows.Forms.Button movimiento2_3;
        private System.Windows.Forms.Button posEvolucion;
        private System.Windows.Forms.Button movimiento1_2;
        private System.Windows.Forms.Button preEvolucion;
        private System.Windows.Forms.Button peso;
    }
}

