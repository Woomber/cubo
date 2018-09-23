namespace Cubo
{
    partial class FormCubo
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
            this.lblÁngulo = new System.Windows.Forms.Label();
            this.trackÁngulo = new System.Windows.Forms.TrackBar();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.nudRotZ = new System.Windows.Forms.NumericUpDown();
            this.lblRotZ = new System.Windows.Forms.Label();
            this.nudRotY = new System.Windows.Forms.NumericUpDown();
            this.lblRotY = new System.Windows.Forms.Label();
            this.nudRotX = new System.Windows.Forms.NumericUpDown();
            this.lblRotX = new System.Windows.Forms.Label();
            this.nudZoom = new System.Windows.Forms.NumericUpDown();
            this.lblZoom = new System.Windows.Forms.Label();
            this.nudÁngulo = new System.Windows.Forms.NumericUpDown();
            this.tablelpControles = new System.Windows.Forms.TableLayoutPanel();
            this.groupProyección = new System.Windows.Forms.GroupBox();
            this.groupAmpliación = new System.Windows.Forms.GroupBox();
            this.groupRotación = new System.Windows.Forms.GroupBox();
            this.btnRotZ = new System.Windows.Forms.Button();
            this.btnRotY = new System.Windows.Forms.Button();
            this.btnRotX = new System.Windows.Forms.Button();
            this.groupPosición = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDecZ = new System.Windows.Forms.Button();
            this.btnDecY = new System.Windows.Forms.Button();
            this.btnDecX = new System.Windows.Forms.Button();
            this.btnIncZ = new System.Windows.Forms.Button();
            this.btnIncY = new System.Windows.Forms.Button();
            this.btnIncX = new System.Windows.Forms.Button();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackÁngulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudÁngulo)).BeginInit();
            this.tablelpControles.SuspendLayout();
            this.groupProyección.SuspendLayout();
            this.groupAmpliación.SuspendLayout();
            this.groupRotación.SuspendLayout();
            this.groupPosición.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblÁngulo
            // 
            this.lblÁngulo.AutoSize = true;
            this.lblÁngulo.Location = new System.Drawing.Point(11, 22);
            this.lblÁngulo.Name = "lblÁngulo";
            this.lblÁngulo.Size = new System.Drawing.Size(110, 13);
            this.lblÁngulo.TabIndex = 0;
            this.lblÁngulo.Text = "Ángulo de proyección";
            // 
            // trackÁngulo
            // 
            this.trackÁngulo.LargeChange = 15;
            this.trackÁngulo.Location = new System.Drawing.Point(11, 38);
            this.trackÁngulo.Maximum = 360;
            this.trackÁngulo.Name = "trackÁngulo";
            this.trackÁngulo.Size = new System.Drawing.Size(154, 45);
            this.trackÁngulo.SmallChange = 10;
            this.trackÁngulo.TabIndex = 1;
            this.trackÁngulo.TickFrequency = 30;
            this.trackÁngulo.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackÁngulo.Value = 30;
            this.trackÁngulo.Scroll += new System.EventHandler(this.trackÁngulo_Scroll);
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(11, 38);
            this.trackZoom.Maximum = 50;
            this.trackZoom.Minimum = 1;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(154, 45);
            this.trackZoom.TabIndex = 4;
            this.trackZoom.TickFrequency = 10;
            this.trackZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackZoom.Value = 15;
            this.trackZoom.Scroll += new System.EventHandler(this.trackZoom_Scroll);
            // 
            // nudRotZ
            // 
            this.nudRotZ.Location = new System.Drawing.Point(171, 173);
            this.nudRotZ.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRotZ.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudRotZ.Name = "nudRotZ";
            this.nudRotZ.Size = new System.Drawing.Size(66, 20);
            this.nudRotZ.TabIndex = 14;
            this.nudRotZ.ValueChanged += new System.EventHandler(this.nudRotZ_ValueChanged);
            // 
            // lblRotZ
            // 
            this.lblRotZ.AutoSize = true;
            this.lblRotZ.Location = new System.Drawing.Point(11, 148);
            this.lblRotZ.Name = "lblRotZ";
            this.lblRotZ.Size = new System.Drawing.Size(60, 13);
            this.lblRotZ.TabIndex = 13;
            this.lblRotZ.Text = "Rotación Z";
            // 
            // nudRotY
            // 
            this.nudRotY.Location = new System.Drawing.Point(171, 111);
            this.nudRotY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRotY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudRotY.Name = "nudRotY";
            this.nudRotY.Size = new System.Drawing.Size(66, 20);
            this.nudRotY.TabIndex = 11;
            this.nudRotY.ValueChanged += new System.EventHandler(this.nudRotY_ValueChanged);
            // 
            // lblRotY
            // 
            this.lblRotY.AutoSize = true;
            this.lblRotY.Location = new System.Drawing.Point(11, 84);
            this.lblRotY.Name = "lblRotY";
            this.lblRotY.Size = new System.Drawing.Size(60, 13);
            this.lblRotY.TabIndex = 10;
            this.lblRotY.Text = "Rotación Y";
            // 
            // nudRotX
            // 
            this.nudRotX.Location = new System.Drawing.Point(171, 51);
            this.nudRotX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRotX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudRotX.Name = "nudRotX";
            this.nudRotX.Size = new System.Drawing.Size(66, 20);
            this.nudRotX.TabIndex = 8;
            this.nudRotX.ValueChanged += new System.EventHandler(this.nudRotX_ValueChanged);
            // 
            // lblRotX
            // 
            this.lblRotX.AutoSize = true;
            this.lblRotX.Location = new System.Drawing.Point(11, 24);
            this.lblRotX.Name = "lblRotX";
            this.lblRotX.Size = new System.Drawing.Size(60, 13);
            this.lblRotX.TabIndex = 7;
            this.lblRotX.Text = "Rotación X";
            // 
            // nudZoom
            // 
            this.nudZoom.Location = new System.Drawing.Point(171, 48);
            this.nudZoom.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudZoom.Name = "nudZoom";
            this.nudZoom.Size = new System.Drawing.Size(66, 20);
            this.nudZoom.TabIndex = 6;
            this.nudZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudZoom.ValueChanged += new System.EventHandler(this.nudZoom_ValueChanged);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(11, 22);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(105, 13);
            this.lblZoom.TabIndex = 5;
            this.lblZoom.Text = "Factor de ampliación";
            // 
            // nudÁngulo
            // 
            this.nudÁngulo.Location = new System.Drawing.Point(171, 49);
            this.nudÁngulo.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudÁngulo.Name = "nudÁngulo";
            this.nudÁngulo.Size = new System.Drawing.Size(66, 20);
            this.nudÁngulo.TabIndex = 2;
            this.nudÁngulo.ValueChanged += new System.EventHandler(this.nudÁngulo_ValueChanged);
            // 
            // tablelpControles
            // 
            this.tablelpControles.ColumnCount = 1;
            this.tablelpControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelpControles.Controls.Add(this.groupProyección, 0, 1);
            this.tablelpControles.Controls.Add(this.groupAmpliación, 0, 2);
            this.tablelpControles.Controls.Add(this.groupRotación, 0, 3);
            this.tablelpControles.Controls.Add(this.groupPosición, 0, 0);
            this.tablelpControles.Controls.Add(this.btnDefaults, 0, 4);
            this.tablelpControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablelpControles.Location = new System.Drawing.Point(0, 0);
            this.tablelpControles.Name = "tablelpControles";
            this.tablelpControles.RowCount = 5;
            this.tablelpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablelpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablelpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tablelpControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablelpControles.Size = new System.Drawing.Size(250, 661);
            this.tablelpControles.TabIndex = 6;
            // 
            // groupProyección
            // 
            this.groupProyección.Controls.Add(this.lblÁngulo);
            this.groupProyección.Controls.Add(this.trackÁngulo);
            this.groupProyección.Controls.Add(this.nudÁngulo);
            this.groupProyección.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupProyección.Location = new System.Drawing.Point(3, 168);
            this.groupProyección.Name = "groupProyección";
            this.groupProyección.Size = new System.Drawing.Size(244, 93);
            this.groupProyección.TabIndex = 1;
            this.groupProyección.TabStop = false;
            this.groupProyección.Text = "Proyección";
            // 
            // groupAmpliación
            // 
            this.groupAmpliación.Controls.Add(this.btnZoomOut);
            this.groupAmpliación.Controls.Add(this.btnZoomIn);
            this.groupAmpliación.Controls.Add(this.lblZoom);
            this.groupAmpliación.Controls.Add(this.trackZoom);
            this.groupAmpliación.Controls.Add(this.nudZoom);
            this.groupAmpliación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAmpliación.Location = new System.Drawing.Point(3, 267);
            this.groupAmpliación.Name = "groupAmpliación";
            this.groupAmpliación.Size = new System.Drawing.Size(244, 93);
            this.groupAmpliación.TabIndex = 1;
            this.groupAmpliación.TabStop = false;
            this.groupAmpliación.Text = "Ampliación";
            // 
            // groupRotación
            // 
            this.groupRotación.Controls.Add(this.btnRotZ);
            this.groupRotación.Controls.Add(this.btnRotY);
            this.groupRotación.Controls.Add(this.btnRotX);
            this.groupRotación.Controls.Add(this.lblRotX);
            this.groupRotación.Controls.Add(this.nudRotZ);
            this.groupRotación.Controls.Add(this.nudRotX);
            this.groupRotación.Controls.Add(this.lblRotZ);
            this.groupRotación.Controls.Add(this.lblRotY);
            this.groupRotación.Controls.Add(this.nudRotY);
            this.groupRotación.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupRotación.Location = new System.Drawing.Point(3, 366);
            this.groupRotación.Name = "groupRotación";
            this.groupRotación.Size = new System.Drawing.Size(244, 225);
            this.groupRotación.TabIndex = 1;
            this.groupRotación.TabStop = false;
            this.groupRotación.Text = "Rotación";
            // 
            // btnRotZ
            // 
            this.btnRotZ.Location = new System.Drawing.Point(14, 170);
            this.btnRotZ.Name = "btnRotZ";
            this.btnRotZ.Size = new System.Drawing.Size(146, 23);
            this.btnRotZ.TabIndex = 16;
            this.btnRotZ.Text = "Rotar en Z";
            this.btnRotZ.UseVisualStyleBackColor = true;
            this.btnRotZ.Click += new System.EventHandler(this.btnRotZ_Click);
            // 
            // btnRotY
            // 
            this.btnRotY.Location = new System.Drawing.Point(14, 111);
            this.btnRotY.Name = "btnRotY";
            this.btnRotY.Size = new System.Drawing.Size(146, 23);
            this.btnRotY.TabIndex = 15;
            this.btnRotY.Text = "Rotar en Y";
            this.btnRotY.UseVisualStyleBackColor = true;
            this.btnRotY.Click += new System.EventHandler(this.btnRotY_Click);
            // 
            // btnRotX
            // 
            this.btnRotX.Location = new System.Drawing.Point(14, 48);
            this.btnRotX.Name = "btnRotX";
            this.btnRotX.Size = new System.Drawing.Size(146, 23);
            this.btnRotX.TabIndex = 7;
            this.btnRotX.Text = "Rotar en X";
            this.btnRotX.UseVisualStyleBackColor = true;
            this.btnRotX.Click += new System.EventHandler(this.btnRotX_Click);
            // 
            // groupPosición
            // 
            this.groupPosición.Controls.Add(this.tableLayoutPanel1);
            this.groupPosición.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPosición.Location = new System.Drawing.Point(3, 3);
            this.groupPosición.Name = "groupPosición";
            this.groupPosición.Size = new System.Drawing.Size(244, 159);
            this.groupPosición.TabIndex = 0;
            this.groupPosición.TabStop = false;
            this.groupPosición.Text = "Posición";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDecZ, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDecY, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDecX, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnIncZ, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIncY, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIncX, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(238, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDecZ
            // 
            this.btnDecZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecZ.Location = new System.Drawing.Point(161, 73);
            this.btnDecZ.Name = "btnDecZ";
            this.btnDecZ.Size = new System.Drawing.Size(74, 64);
            this.btnDecZ.TabIndex = 13;
            this.btnDecZ.Text = "Z-";
            this.btnDecZ.UseVisualStyleBackColor = true;
            this.btnDecZ.Click += new System.EventHandler(this.btnDecZ_Click);
            // 
            // btnDecY
            // 
            this.btnDecY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecY.Location = new System.Drawing.Point(82, 73);
            this.btnDecY.Name = "btnDecY";
            this.btnDecY.Size = new System.Drawing.Size(73, 64);
            this.btnDecY.TabIndex = 12;
            this.btnDecY.Text = "Y-";
            this.btnDecY.UseVisualStyleBackColor = true;
            this.btnDecY.Click += new System.EventHandler(this.btnDecY_Click);
            // 
            // btnDecX
            // 
            this.btnDecX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecX.Location = new System.Drawing.Point(3, 73);
            this.btnDecX.Name = "btnDecX";
            this.btnDecX.Size = new System.Drawing.Size(73, 64);
            this.btnDecX.TabIndex = 11;
            this.btnDecX.Text = "X-";
            this.btnDecX.UseVisualStyleBackColor = true;
            this.btnDecX.Click += new System.EventHandler(this.btnDecX_Click);
            // 
            // btnIncZ
            // 
            this.btnIncZ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncZ.Location = new System.Drawing.Point(161, 3);
            this.btnIncZ.Name = "btnIncZ";
            this.btnIncZ.Size = new System.Drawing.Size(74, 64);
            this.btnIncZ.TabIndex = 10;
            this.btnIncZ.Text = "Z+";
            this.btnIncZ.UseVisualStyleBackColor = true;
            this.btnIncZ.Click += new System.EventHandler(this.btnIncZ_Click);
            // 
            // btnIncY
            // 
            this.btnIncY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncY.Location = new System.Drawing.Point(82, 3);
            this.btnIncY.Name = "btnIncY";
            this.btnIncY.Size = new System.Drawing.Size(73, 64);
            this.btnIncY.TabIndex = 9;
            this.btnIncY.Text = "Y+";
            this.btnIncY.UseVisualStyleBackColor = true;
            this.btnIncY.Click += new System.EventHandler(this.btnIncY_Click);
            // 
            // btnIncX
            // 
            this.btnIncX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncX.Location = new System.Drawing.Point(3, 3);
            this.btnIncX.Name = "btnIncX";
            this.btnIncX.Size = new System.Drawing.Size(73, 64);
            this.btnIncX.TabIndex = 8;
            this.btnIncX.Text = "X+";
            this.btnIncX.UseVisualStyleBackColor = true;
            this.btnIncX.Click += new System.EventHandler(this.btnIncX_Click);
            // 
            // btnDefaults
            // 
            this.btnDefaults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefaults.Location = new System.Drawing.Point(3, 597);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(244, 61);
            this.btnDefaults.TabIndex = 2;
            this.btnDefaults.Text = "Valores por defecto";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(171, 22);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(26, 23);
            this.btnZoomIn.TabIndex = 17;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(203, 22);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(26, 23);
            this.btnZoomOut.TabIndex = 18;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // FormCubo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tablelpControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormCubo";
            this.Text = "Cubo";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormCubo_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackÁngulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudÁngulo)).EndInit();
            this.tablelpControles.ResumeLayout(false);
            this.groupProyección.ResumeLayout(false);
            this.groupProyección.PerformLayout();
            this.groupAmpliación.ResumeLayout(false);
            this.groupAmpliación.PerformLayout();
            this.groupRotación.ResumeLayout(false);
            this.groupRotación.PerformLayout();
            this.groupPosición.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblÁngulo;
        private System.Windows.Forms.TrackBar trackÁngulo;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.NumericUpDown nudÁngulo;
        private System.Windows.Forms.NumericUpDown nudZoom;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.NumericUpDown nudRotZ;
        private System.Windows.Forms.Label lblRotZ;
        private System.Windows.Forms.NumericUpDown nudRotY;
        private System.Windows.Forms.Label lblRotY;
        private System.Windows.Forms.NumericUpDown nudRotX;
        private System.Windows.Forms.Label lblRotX;
        private System.Windows.Forms.TableLayoutPanel tablelpControles;
        private System.Windows.Forms.GroupBox groupProyección;
        private System.Windows.Forms.GroupBox groupAmpliación;
        private System.Windows.Forms.GroupBox groupRotación;
        private System.Windows.Forms.GroupBox groupPosición;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Button btnRotX;
        private System.Windows.Forms.Button btnRotZ;
        private System.Windows.Forms.Button btnRotY;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDecZ;
        private System.Windows.Forms.Button btnDecY;
        private System.Windows.Forms.Button btnDecX;
        private System.Windows.Forms.Button btnIncZ;
        private System.Windows.Forms.Button btnIncY;
        private System.Windows.Forms.Button btnIncX;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
    }
}

