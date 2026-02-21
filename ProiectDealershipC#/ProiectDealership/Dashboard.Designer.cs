namespace ProiectDealership
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ResultData = new System.Windows.Forms.DataGridView();
            this.Cauta = new System.Windows.Forms.Label();
            this.Cautare = new System.Windows.Forms.TextBox();
            this.btnShowCar = new System.Windows.Forms.Button();
            this.btnCloseTab = new System.Windows.Forms.Button();
            this.btnSearchCar = new System.Windows.Forms.Button();
            this.btnSearchClients = new System.Windows.Forms.Button();
            this.btnShowClients = new System.Windows.Forms.Button();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.btnShowTestDrive = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultData)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultData
            // 
            this.ResultData.AllowUserToOrderColumns = true;
            this.ResultData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultData.Location = new System.Drawing.Point(275, 24);
            this.ResultData.Name = "ResultData";
            this.ResultData.RowHeadersWidth = 51;
            this.ResultData.RowTemplate.Height = 24;
            this.ResultData.Size = new System.Drawing.Size(612, 365);
            this.ResultData.TabIndex = 0;
            // 
            // Cauta
            // 
            this.Cauta.AutoSize = true;
            this.Cauta.BackColor = System.Drawing.Color.Transparent;
            this.Cauta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cauta.ForeColor = System.Drawing.Color.OrangeRed;
            this.Cauta.Location = new System.Drawing.Point(3, 55);
            this.Cauta.Name = "Cauta";
            this.Cauta.Size = new System.Drawing.Size(64, 20);
            this.Cauta.TabIndex = 4;
            this.Cauta.Text = "Cauta:";
            // 
            // Cautare
            // 
            this.Cautare.Location = new System.Drawing.Point(82, 53);
            this.Cautare.Name = "Cautare";
            this.Cautare.Size = new System.Drawing.Size(153, 22);
            this.Cautare.TabIndex = 5;
            // 
            // btnShowCar
            // 
            this.btnShowCar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCar.Location = new System.Drawing.Point(35, 422);
            this.btnShowCar.Name = "btnShowCar";
            this.btnShowCar.Size = new System.Drawing.Size(152, 53);
            this.btnShowCar.TabIndex = 6;
            this.btnShowCar.Text = "Afiseaza autovehiculele";
            this.btnShowCar.UseVisualStyleBackColor = false;
            this.btnShowCar.Click += new System.EventHandler(this.btnShowCar_Click);
            // 
            // btnCloseTab
            // 
            this.btnCloseTab.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCloseTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTab.Location = new System.Drawing.Point(803, 422);
            this.btnCloseTab.Name = "btnCloseTab";
            this.btnCloseTab.Size = new System.Drawing.Size(99, 53);
            this.btnCloseTab.TabIndex = 7;
            this.btnCloseTab.Text = "Close tab";
            this.btnCloseTab.UseVisualStyleBackColor = false;
            this.btnCloseTab.Click += new System.EventHandler(this.btnCloseTab_Click);
            // 
            // btnSearchCar
            // 
            this.btnSearchCar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearchCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCar.Location = new System.Drawing.Point(35, 116);
            this.btnSearchCar.Name = "btnSearchCar";
            this.btnSearchCar.Size = new System.Drawing.Size(152, 53);
            this.btnSearchCar.TabIndex = 8;
            this.btnSearchCar.Text = "Cauta masini dupa marca";
            this.btnSearchCar.UseVisualStyleBackColor = false;
            this.btnSearchCar.Click += new System.EventHandler(this.btnSearchCar_Click);
            // 
            // btnSearchClients
            // 
            this.btnSearchClients.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearchClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClients.Location = new System.Drawing.Point(35, 215);
            this.btnSearchClients.Name = "btnSearchClients";
            this.btnSearchClients.Size = new System.Drawing.Size(152, 53);
            this.btnSearchClients.TabIndex = 9;
            this.btnSearchClients.Text = "Cauta clienti dupa e-mail";
            this.btnSearchClients.UseVisualStyleBackColor = false;
            this.btnSearchClients.Click += new System.EventHandler(this.btnSearchClients_Click);
            // 
            // btnShowClients
            // 
            this.btnShowClients.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowClients.Location = new System.Drawing.Point(634, 422);
            this.btnShowClients.Name = "btnShowClients";
            this.btnShowClients.Size = new System.Drawing.Size(128, 53);
            this.btnShowClients.TabIndex = 11;
            this.btnShowClients.Text = "Afiseaza clienti";
            this.btnShowClients.UseVisualStyleBackColor = false;
            this.btnShowClients.Click += new System.EventHandler(this.btnShowClients_Click);
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEmployee.Location = new System.Drawing.Point(442, 422);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(140, 53);
            this.btnShowEmployee.TabIndex = 12;
            this.btnShowEmployee.Text = "Afiseaza angajati";
            this.btnShowEmployee.UseVisualStyleBackColor = false;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // btnShowTestDrive
            // 
            this.btnShowTestDrive.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShowTestDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTestDrive.Location = new System.Drawing.Point(250, 422);
            this.btnShowTestDrive.Name = "btnShowTestDrive";
            this.btnShowTestDrive.Size = new System.Drawing.Size(139, 53);
            this.btnShowTestDrive.TabIndex = 13;
            this.btnShowTestDrive.Text = "Afiseaza programari";
            this.btnShowTestDrive.UseVisualStyleBackColor = false;
            this.btnShowTestDrive.Click += new System.EventHandler(this.btnShowTestDrive_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Programeaza Test-Drive";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowTestDrive);
            this.Controls.Add(this.btnShowEmployee);
            this.Controls.Add(this.btnShowClients);
            this.Controls.Add(this.btnSearchClients);
            this.Controls.Add(this.btnSearchCar);
            this.Controls.Add(this.btnCloseTab);
            this.Controls.Add(this.btnShowCar);
            this.Controls.Add(this.Cautare);
            this.Controls.Add(this.Cauta);
            this.Controls.Add(this.ResultData);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultData;
        private System.Windows.Forms.Label Cauta;
        private System.Windows.Forms.TextBox Cautare;
        private System.Windows.Forms.Button btnShowCar;
        private System.Windows.Forms.Button btnCloseTab;
        private System.Windows.Forms.Button btnSearchCar;
        private System.Windows.Forms.Button btnSearchClients;
        private System.Windows.Forms.Button btnShowClients;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Button btnShowTestDrive;
        private System.Windows.Forms.Button button1;
    }
}