namespace PokedexC_sharp
{
    partial class BusquedaFiltro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaFiltro));
            this.especie = new System.Windows.Forms.CheckedListBox();
            this.filtrar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.CheckedListBox();
            this.habilidad = new System.Windows.Forms.CheckedListBox();
            this.habitat = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // especie
            // 
            this.especie.FormattingEnabled = true;
            this.especie.Items.AddRange(new object[] {
            "Semilla",
            "Lagartija",
            "Llama",
            "Tortuguita",
            "Tortuga",
            "Marisco",
            "Gusano",
            "Capullo",
            "Mariposa",
            "Oruga",
            "Abeja Asesina",
            "Pajarito",
            "Pajaro",
            "Pico",
            "Serpiente",
            "Cobra",
            "Raton",
            "Pin Veneno",
            "Taladro",
            "Hada",
            "Zorro",
            "Globo",
            "Murcielago",
            "Hierbajo",
            "Hongo",
            "Insecto",
            "Polilla Venenosa",
            "Topo",
            "Gato Araña",
            "Gato Fino",
            "Pato",
            "Mono Cerdo",
            "Perrito",
            "Legendario",
            "Renacuajo",
            "Psi",
            "Superpoder",
            "Flor",
            "Matamoscas",
            "Medusa",
            "Roca",
            "Megaton",
            "Caballo Fuego",
            "Atontado",
            "Ermitaño",
            "Iman",
            "Pato Salvaje",
            "Ave Gemela",
            "Ave Triple",
            "Leon Marino",
            "Lodo",
            "Bivalvo",
            "Gas",
            "Sombra",
            "Serpiente Roca",
            "Hipnosis",
            "Cangrejo",
            "Tenaza",
            "Bola",
            "Huevo",
            "Coco",
            "Solitario",
            "Apilahueso",
            "Patada",
            "Puñetazo",
            "Lametazo",
            "Gas Veneno",
            "Clavos",
            "Huevo",
            "Enredadera",
            "Padres",
            "Pez Color",
            "Misterioso",
            "Barrera",
            "Mantis",
            "Forma Humana",
            "Electrico",
            "Escupe Fuego",
            "Escarabajo",
            "Toro Bravo",
            "Pez",
            "Atrocidad",
            "Transporte",
            "Transformacion",
            "Evolucion",
            "Burbuja",
            "Relampago",
            "Virtual",
            "Espiral",
            "Marisco",
            "Fosil",
            "Dormilon",
            "Congelar",
            "Dragon",
            "Genetico",
            "Nueva Especie"});
            this.especie.Location = new System.Drawing.Point(12, 62);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(140, 244);
            this.especie.TabIndex = 2;
            // 
            // filtrar
            // 
            this.filtrar.BackColor = System.Drawing.Color.Transparent;
            this.filtrar.FlatAppearance.BorderSize = 0;
            this.filtrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.filtrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrar.Location = new System.Drawing.Point(596, 12);
            this.filtrar.Name = "filtrar";
            this.filtrar.Size = new System.Drawing.Size(98, 50);
            this.filtrar.TabIndex = 20;
            this.filtrar.Text = "Filtrar";
            this.filtrar.UseVisualStyleBackColor = false;
            this.filtrar.Click += new System.EventHandler(this.filtrar_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(140, 50);
            this.label.TabIndex = 21;
            this.label.Text = "Especie";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(450, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 50);
            this.label2.TabIndex = 24;
            this.label2.Text = "Habitat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 50);
            this.label3.TabIndex = 23;
            this.label3.Text = "Habilidad";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Agua",
            "Bicho",
            "Dragon",
            "Electrico",
            "Fantasma",
            "Fuego",
            "Hielo",
            "Lucha",
            "Normal",
            "Planta",
            "Psiquico",
            "Roca",
            "Tierra",
            "Veneno",
            "Volador"});
            this.tipo.Location = new System.Drawing.Point(158, 62);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(140, 244);
            this.tipo.TabIndex = 26;
            // 
            // habilidad
            // 
            this.habilidad.FormattingEnabled = true;
            this.habilidad.Items.AddRange(new object[] {
            "Aborbe agua",
            "Absor. elec.",
            "Absorbe Agua",
            "Absorbe Fuego",
            "Aclimatacion",
            "Agallas",
            "Armad.Bat",
            "Cabeza Roca",
            "Caparazon",
            "Clorofila",
            "Corte Fuerte",
            "Cuerpo Llama",
            "Cuerpo Maldito",
            "Cuerpo Puro",
            "Cura Natural",
            "Despiste",
            "Electricidad Estatica",
            "Enjambre",
            "Espesura",
            "Espiritu Vital",
            "Flexibilidad",
            "Foco Interno",
            "Fuga",
            "Gran Encanto",
            "Hedor",
            "Humedad",
            "Iman",
            "Insomnio",
            "Insonorizar",
            "Intimidacion",
            "Levitacion",
            "Madrugar",
            "Mar llamas",
            "Mudar",
            "Nado Rapido",
            "OjoCompuesto",
            "Pararrayos",
            "Polvo Escudo",
            "Presion",
            "Punto Toxico",
            "Rastro",
            "Recogida",
            "Sebo",
            "Sincronia",
            "Torrente",
            "Velo Arena",
            "Vista Lince"});
            this.habilidad.Location = new System.Drawing.Point(304, 62);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(140, 244);
            this.habilidad.TabIndex = 27;
            // 
            // habitat
            // 
            this.habitat.FormattingEnabled = true;
            this.habitat.Items.AddRange(new object[] {
            "Agua Dulce",
            "Agua Salada",
            "Bosque",
            "Campo",
            "Caverna",
            "Ciudad",
            "Montaña",
            "Pradera",
            "RARO"});
            this.habitat.Location = new System.Drawing.Point(450, 62);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(140, 244);
            this.habitat.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(615, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(621, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "label7";
            // 
            // BusquedaFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 314);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.filtrar);
            this.Controls.Add(this.especie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaFiltro";
            this.Text = "BusquedaFiltro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox especie;
        private System.Windows.Forms.Button filtrar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox tipo;
        private System.Windows.Forms.CheckedListBox habilidad;
        private System.Windows.Forms.CheckedListBox habitat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}