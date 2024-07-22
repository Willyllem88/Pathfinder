
namespace AppPathFinding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_startprogram = new System.Windows.Forms.Button();
            this.lbl_Speaker1 = new System.Windows.Forms.Label();
            this.btn_CreateGrill = new System.Windows.Forms.Button();
            this.btn_ChooseGrill = new System.Windows.Forms.Button();
            this.btn_RandomGrill = new System.Windows.Forms.Button();
            this.lbl_Speaker2 = new System.Windows.Forms.Label();
            this.num_Xcages = new System.Windows.Forms.NumericUpDown();
            this.num_Ycages = new System.Windows.Forms.NumericUpDown();
            this.lbl_Speaker3 = new System.Windows.Forms.Label();
            this.Grill = new System.Windows.Forms.DataGridView();
            this.btn_ProceedCreateGrill = new System.Windows.Forms.Button();
            this.btn_GrillProceed = new System.Windows.Forms.Button();
            this.btn_GrillRepeat = new System.Windows.Forms.Button();
            this.btn_InputWallVoid = new System.Windows.Forms.Button();
            this.btn_InputAPoint = new System.Windows.Forms.Button();
            this.btn_InputBPoint = new System.Windows.Forms.Button();
            this.lbl_OnlyOneA = new System.Windows.Forms.Label();
            this.lbl_OnlyOneB = new System.Windows.Forms.Label();
            this.lbl_BelowGrill = new System.Windows.Forms.Label();
            this.btn_SetGrill1 = new System.Windows.Forms.Button();
            this.btn_SetGrill2 = new System.Windows.Forms.Button();
            this.btn_SetGrill3 = new System.Windows.Forms.Button();
            this.lbl_SetGrillOptions = new System.Windows.Forms.Label();
            this.btn_RepetirApp = new System.Windows.Forms.Button();
            this.SeeIA = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_Xcages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ycages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grill)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_startprogram
            // 
            this.btn_startprogram.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_startprogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_startprogram.Location = new System.Drawing.Point(12, 4);
            this.btn_startprogram.Name = "btn_startprogram";
            this.btn_startprogram.Size = new System.Drawing.Size(143, 23);
            this.btn_startprogram.TabIndex = 0;
            this.btn_startprogram.Text = "Començar PathFinding";
            this.btn_startprogram.UseVisualStyleBackColor = false;
            this.btn_startprogram.Click += new System.EventHandler(this.btn_startprogram_Click);
            // 
            // lbl_Speaker1
            // 
            this.lbl_Speaker1.AutoSize = true;
            this.lbl_Speaker1.Location = new System.Drawing.Point(12, 9);
            this.lbl_Speaker1.Name = "lbl_Speaker1";
            this.lbl_Speaker1.Size = new System.Drawing.Size(0, 13);
            this.lbl_Speaker1.TabIndex = 1;
            // 
            // btn_CreateGrill
            // 
            this.btn_CreateGrill.Location = new System.Drawing.Point(25, 33);
            this.btn_CreateGrill.Name = "btn_CreateGrill";
            this.btn_CreateGrill.Size = new System.Drawing.Size(130, 23);
            this.btn_CreateGrill.TabIndex = 2;
            this.btn_CreateGrill.Text = "Crear graella";
            this.btn_CreateGrill.UseVisualStyleBackColor = true;
            this.btn_CreateGrill.Visible = false;
            this.btn_CreateGrill.Click += new System.EventHandler(this.btn_CreateGrill_Click);
            // 
            // btn_ChooseGrill
            // 
            this.btn_ChooseGrill.Location = new System.Drawing.Point(25, 63);
            this.btn_ChooseGrill.Name = "btn_ChooseGrill";
            this.btn_ChooseGrill.Size = new System.Drawing.Size(130, 23);
            this.btn_ChooseGrill.TabIndex = 3;
            this.btn_ChooseGrill.Text = "Escollir predeterminada";
            this.btn_ChooseGrill.UseVisualStyleBackColor = true;
            this.btn_ChooseGrill.Visible = false;
            this.btn_ChooseGrill.Click += new System.EventHandler(this.btn_ChooseGrill_Click_1);
            // 
            // btn_RandomGrill
            // 
            this.btn_RandomGrill.Location = new System.Drawing.Point(25, 93);
            this.btn_RandomGrill.Name = "btn_RandomGrill";
            this.btn_RandomGrill.Size = new System.Drawing.Size(130, 23);
            this.btn_RandomGrill.TabIndex = 4;
            this.btn_RandomGrill.Text = "Triar aletòriament";
            this.btn_RandomGrill.UseVisualStyleBackColor = true;
            this.btn_RandomGrill.Visible = false;
            this.btn_RandomGrill.Click += new System.EventHandler(this.btn_RandomGrill_Click);
            // 
            // lbl_Speaker2
            // 
            this.lbl_Speaker2.AutoSize = true;
            this.lbl_Speaker2.Location = new System.Drawing.Point(12, 42);
            this.lbl_Speaker2.Name = "lbl_Speaker2";
            this.lbl_Speaker2.Size = new System.Drawing.Size(0, 13);
            this.lbl_Speaker2.TabIndex = 5;
            // 
            // num_Xcages
            // 
            this.num_Xcages.BackColor = System.Drawing.SystemColors.Window;
            this.num_Xcages.InterceptArrowKeys = false;
            this.num_Xcages.Location = new System.Drawing.Point(239, 40);
            this.num_Xcages.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_Xcages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Xcages.Name = "num_Xcages";
            this.num_Xcages.Size = new System.Drawing.Size(67, 20);
            this.num_Xcages.TabIndex = 6;
            this.num_Xcages.Tag = "";
            this.num_Xcages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Xcages.Visible = false;
            this.num_Xcages.ValueChanged += new System.EventHandler(this.num_Xcages_ValueChanged);
            // 
            // num_Ycages
            // 
            this.num_Ycages.InterceptArrowKeys = false;
            this.num_Ycages.Location = new System.Drawing.Point(239, 70);
            this.num_Ycages.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_Ycages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Ycages.Name = "num_Ycages";
            this.num_Ycages.Size = new System.Drawing.Size(67, 20);
            this.num_Ycages.TabIndex = 7;
            this.num_Ycages.Tag = "";
            this.num_Ycages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Ycages.Visible = false;
            this.num_Ycages.ValueChanged += new System.EventHandler(this.num_Ycages_ValueChanged);
            // 
            // lbl_Speaker3
            // 
            this.lbl_Speaker3.AutoSize = true;
            this.lbl_Speaker3.Location = new System.Drawing.Point(12, 72);
            this.lbl_Speaker3.Name = "lbl_Speaker3";
            this.lbl_Speaker3.Size = new System.Drawing.Size(0, 13);
            this.lbl_Speaker3.TabIndex = 8;
            // 
            // Grill
            // 
            this.Grill.AllowUserToAddRows = false;
            this.Grill.AllowUserToDeleteRows = false;
            this.Grill.AllowUserToResizeColumns = false;
            this.Grill.AllowUserToResizeRows = false;
            this.Grill.BackgroundColor = System.Drawing.Color.LightGray;
            this.Grill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grill.ColumnHeadersVisible = false;
            this.Grill.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grill.GridColor = System.Drawing.Color.DimGray;
            this.Grill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grill.Location = new System.Drawing.Point(25, 52);
            this.Grill.MultiSelect = false;
            this.Grill.Name = "Grill";
            this.Grill.ReadOnly = true;
            this.Grill.RowHeadersVisible = false;
            this.Grill.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grill.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Grill.Size = new System.Drawing.Size(400, 400);
            this.Grill.TabIndex = 10;
            this.Grill.Visible = false;
            // 
            // btn_ProceedCreateGrill
            // 
            this.btn_ProceedCreateGrill.Location = new System.Drawing.Point(25, 122);
            this.btn_ProceedCreateGrill.Name = "btn_ProceedCreateGrill";
            this.btn_ProceedCreateGrill.Size = new System.Drawing.Size(130, 23);
            this.btn_ProceedCreateGrill.TabIndex = 11;
            this.btn_ProceedCreateGrill.Text = "Continuar...";
            this.btn_ProceedCreateGrill.UseVisualStyleBackColor = true;
            this.btn_ProceedCreateGrill.Visible = false;
            this.btn_ProceedCreateGrill.Click += new System.EventHandler(this.btn_ProceedCreateGrill_Click);
            // 
            // btn_GrillProceed
            // 
            this.btn_GrillProceed.Location = new System.Drawing.Point(25, 484);
            this.btn_GrillProceed.Name = "btn_GrillProceed";
            this.btn_GrillProceed.Size = new System.Drawing.Size(75, 23);
            this.btn_GrillProceed.TabIndex = 12;
            this.btn_GrillProceed.Text = "Continuar";
            this.btn_GrillProceed.UseVisualStyleBackColor = true;
            this.btn_GrillProceed.Visible = false;
            this.btn_GrillProceed.Click += new System.EventHandler(this.btn_GrillProceed_Click);
            // 
            // btn_GrillRepeat
            // 
            this.btn_GrillRepeat.Location = new System.Drawing.Point(106, 484);
            this.btn_GrillRepeat.Name = "btn_GrillRepeat";
            this.btn_GrillRepeat.Size = new System.Drawing.Size(75, 23);
            this.btn_GrillRepeat.TabIndex = 13;
            this.btn_GrillRepeat.Text = "Repetir";
            this.btn_GrillRepeat.UseVisualStyleBackColor = true;
            this.btn_GrillRepeat.Visible = false;
            this.btn_GrillRepeat.Click += new System.EventHandler(this.btn_GrillRepeat_Click);
            // 
            // btn_InputWallVoid
            // 
            this.btn_InputWallVoid.BackColor = System.Drawing.Color.DarkGray;
            this.btn_InputWallVoid.Location = new System.Drawing.Point(454, 52);
            this.btn_InputWallVoid.Name = "btn_InputWallVoid";
            this.btn_InputWallVoid.Size = new System.Drawing.Size(75, 23);
            this.btn_InputWallVoid.TabIndex = 15;
            this.btn_InputWallVoid.Text = "Paret/Buit";
            this.btn_InputWallVoid.UseVisualStyleBackColor = false;
            this.btn_InputWallVoid.Visible = false;
            this.btn_InputWallVoid.Click += new System.EventHandler(this.btn_InputWallVoid_Click);
            // 
            // btn_InputAPoint
            // 
            this.btn_InputAPoint.BackColor = System.Drawing.Color.Red;
            this.btn_InputAPoint.Location = new System.Drawing.Point(454, 81);
            this.btn_InputAPoint.Name = "btn_InputAPoint";
            this.btn_InputAPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_InputAPoint.TabIndex = 16;
            this.btn_InputAPoint.Text = "Punt A";
            this.btn_InputAPoint.UseVisualStyleBackColor = false;
            this.btn_InputAPoint.Visible = false;
            this.btn_InputAPoint.Click += new System.EventHandler(this.btn_InputAPoint_Click);
            // 
            // btn_InputBPoint
            // 
            this.btn_InputBPoint.BackColor = System.Drawing.Color.Green;
            this.btn_InputBPoint.Location = new System.Drawing.Point(454, 110);
            this.btn_InputBPoint.Name = "btn_InputBPoint";
            this.btn_InputBPoint.Size = new System.Drawing.Size(75, 23);
            this.btn_InputBPoint.TabIndex = 17;
            this.btn_InputBPoint.Text = "Punt B";
            this.btn_InputBPoint.UseVisualStyleBackColor = false;
            this.btn_InputBPoint.Visible = false;
            this.btn_InputBPoint.Click += new System.EventHandler(this.btn_InputBPoint_Click);
            // 
            // lbl_OnlyOneA
            // 
            this.lbl_OnlyOneA.AutoSize = true;
            this.lbl_OnlyOneA.Location = new System.Drawing.Point(425, 150);
            this.lbl_OnlyOneA.Name = "lbl_OnlyOneA";
            this.lbl_OnlyOneA.Size = new System.Drawing.Size(157, 39);
            this.lbl_OnlyOneA.TabIndex = 18;
            this.lbl_OnlyOneA.Text = "No pot introduir dos punts \r\nd\'inici. Per borrar l\'anterior \r\nselecciona\'l i prem" +
    "\"Pared/Buit\".";
            this.lbl_OnlyOneA.Visible = false;
            // 
            // lbl_OnlyOneB
            // 
            this.lbl_OnlyOneB.AutoSize = true;
            this.lbl_OnlyOneB.Location = new System.Drawing.Point(425, 150);
            this.lbl_OnlyOneB.Name = "lbl_OnlyOneB";
            this.lbl_OnlyOneB.Size = new System.Drawing.Size(157, 39);
            this.lbl_OnlyOneB.TabIndex = 19;
            this.lbl_OnlyOneB.Text = "No pot introduir dos punts \r\nfinals. Per borrar l\'anterior \r\nselecciona\'l i prem\"" +
    "Pared/Buit\".";
            this.lbl_OnlyOneB.Visible = false;
            // 
            // lbl_BelowGrill
            // 
            this.lbl_BelowGrill.AutoSize = true;
            this.lbl_BelowGrill.Location = new System.Drawing.Point(25, 465);
            this.lbl_BelowGrill.Name = "lbl_BelowGrill";
            this.lbl_BelowGrill.Size = new System.Drawing.Size(0, 13);
            this.lbl_BelowGrill.TabIndex = 20;
            // 
            // btn_SetGrill1
            // 
            this.btn_SetGrill1.Location = new System.Drawing.Point(454, 292);
            this.btn_SetGrill1.Name = "btn_SetGrill1";
            this.btn_SetGrill1.Size = new System.Drawing.Size(75, 23);
            this.btn_SetGrill1.TabIndex = 21;
            this.btn_SetGrill1.Text = "Opció 1";
            this.btn_SetGrill1.UseVisualStyleBackColor = true;
            this.btn_SetGrill1.Visible = false;
            this.btn_SetGrill1.Click += new System.EventHandler(this.btn_SetGrill1_Click);
            // 
            // btn_SetGrill2
            // 
            this.btn_SetGrill2.Location = new System.Drawing.Point(454, 321);
            this.btn_SetGrill2.Name = "btn_SetGrill2";
            this.btn_SetGrill2.Size = new System.Drawing.Size(75, 23);
            this.btn_SetGrill2.TabIndex = 22;
            this.btn_SetGrill2.Text = "Opció 2";
            this.btn_SetGrill2.UseVisualStyleBackColor = true;
            this.btn_SetGrill2.Visible = false;
            this.btn_SetGrill2.Click += new System.EventHandler(this.btn_SetGrill2_Click);
            // 
            // btn_SetGrill3
            // 
            this.btn_SetGrill3.Location = new System.Drawing.Point(454, 350);
            this.btn_SetGrill3.Name = "btn_SetGrill3";
            this.btn_SetGrill3.Size = new System.Drawing.Size(75, 23);
            this.btn_SetGrill3.TabIndex = 23;
            this.btn_SetGrill3.Text = "Opció 3";
            this.btn_SetGrill3.UseVisualStyleBackColor = true;
            this.btn_SetGrill3.Visible = false;
            this.btn_SetGrill3.Click += new System.EventHandler(this.btn_SetGrill3_Click);
            // 
            // lbl_SetGrillOptions
            // 
            this.lbl_SetGrillOptions.AutoSize = true;
            this.lbl_SetGrillOptions.Location = new System.Drawing.Point(425, 251);
            this.lbl_SetGrillOptions.Name = "lbl_SetGrillOptions";
            this.lbl_SetGrillOptions.Size = new System.Drawing.Size(115, 26);
            this.lbl_SetGrillOptions.TabIndex = 24;
            this.lbl_SetGrillOptions.Text = "Selecciona una de les \r\nopcions ja creades:\r\n";
            this.lbl_SetGrillOptions.Visible = false;
            // 
            // btn_RepetirApp
            // 
            this.btn_RepetirApp.Location = new System.Drawing.Point(206, 458);
            this.btn_RepetirApp.Name = "btn_RepetirApp";
            this.btn_RepetirApp.Size = new System.Drawing.Size(75, 23);
            this.btn_RepetirApp.TabIndex = 25;
            this.btn_RepetirApp.Text = "Repetir";
            this.btn_RepetirApp.UseVisualStyleBackColor = true;
            this.btn_RepetirApp.Visible = false;
            this.btn_RepetirApp.Click += new System.EventHandler(this.btn_RepetirApp_Click);
            // 
            // SeeIA
            // 
            this.SeeIA.AutoSize = true;
            this.SeeIA.Location = new System.Drawing.Point(25, 122);
            this.SeeIA.Name = "SeeIA";
            this.SeeIA.Size = new System.Drawing.Size(158, 17);
            this.SeeIA.TabIndex = 26;
            this.SeeIA.Text = "Vols veure l\'avenç de la IA?";
            this.SeeIA.UseVisualStyleBackColor = true;
            this.SeeIA.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.SeeIA);
            this.Controls.Add(this.btn_RepetirApp);
            this.Controls.Add(this.lbl_SetGrillOptions);
            this.Controls.Add(this.btn_SetGrill3);
            this.Controls.Add(this.btn_SetGrill2);
            this.Controls.Add(this.btn_SetGrill1);
            this.Controls.Add(this.lbl_BelowGrill);
            this.Controls.Add(this.lbl_OnlyOneB);
            this.Controls.Add(this.lbl_OnlyOneA);
            this.Controls.Add(this.btn_InputBPoint);
            this.Controls.Add(this.btn_InputAPoint);
            this.Controls.Add(this.btn_InputWallVoid);
            this.Controls.Add(this.btn_GrillRepeat);
            this.Controls.Add(this.btn_GrillProceed);
            this.Controls.Add(this.btn_ProceedCreateGrill);
            this.Controls.Add(this.lbl_Speaker3);
            this.Controls.Add(this.num_Ycages);
            this.Controls.Add(this.num_Xcages);
            this.Controls.Add(this.lbl_Speaker2);
            this.Controls.Add(this.btn_RandomGrill);
            this.Controls.Add(this.btn_ChooseGrill);
            this.Controls.Add(this.btn_CreateGrill);
            this.Controls.Add(this.lbl_Speaker1);
            this.Controls.Add(this.btn_startprogram);
            this.Controls.Add(this.Grill);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GCabré_PathFinding";
            ((System.ComponentModel.ISupportInitialize)(this.num_Xcages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Ycages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startprogram;
        private System.Windows.Forms.Label lbl_Speaker1;
        private System.Windows.Forms.Button btn_CreateGrill;
        private System.Windows.Forms.Button btn_ChooseGrill;
        private System.Windows.Forms.Button btn_RandomGrill;
        private System.Windows.Forms.Label lbl_Speaker2;
        private System.Windows.Forms.NumericUpDown num_Xcages;
        private System.Windows.Forms.NumericUpDown num_Ycages;
        private System.Windows.Forms.Label lbl_Speaker3;
        private System.Windows.Forms.DataGridView Grill;
        private System.Windows.Forms.Button btn_ProceedCreateGrill;
        private System.Windows.Forms.Button btn_GrillProceed;
        private System.Windows.Forms.Button btn_GrillRepeat;
        private System.Windows.Forms.Button btn_InputWallVoid;
        private System.Windows.Forms.Button btn_InputAPoint;
        private System.Windows.Forms.Button btn_InputBPoint;
        private System.Windows.Forms.Label lbl_OnlyOneA;
        private System.Windows.Forms.Label lbl_OnlyOneB;
        private System.Windows.Forms.Label lbl_BelowGrill;
        private System.Windows.Forms.Button btn_SetGrill1;
        private System.Windows.Forms.Button btn_SetGrill2;
        private System.Windows.Forms.Button btn_SetGrill3;
        private System.Windows.Forms.Label lbl_SetGrillOptions;
        private System.Windows.Forms.Button btn_RepetirApp;
        private System.Windows.Forms.CheckBox SeeIA;
    }
}

