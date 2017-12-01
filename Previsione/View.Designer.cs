namespace Previsione
{
    partial class View
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.rbSQLite = new System.Windows.Forms.RadioButton();
            this.rbSQLServer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevisione = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.normalRead = new System.Windows.Forms.RadioButton();
            this.factoryRead = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(157, 62);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(2);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsole.Size = new System.Drawing.Size(440, 219);
            this.txtConsole.TabIndex = 1;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(8, 34);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(108, 23);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read View";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // rbSQLite
            // 
            this.rbSQLite.AutoSize = true;
            this.rbSQLite.Location = new System.Drawing.Point(10, 19);
            this.rbSQLite.Name = "rbSQLite";
            this.rbSQLite.Size = new System.Drawing.Size(57, 17);
            this.rbSQLite.TabIndex = 3;
            this.rbSQLite.Text = "SQLite";
            this.rbSQLite.UseVisualStyleBackColor = true;
            // 
            // rbSQLServer
            // 
            this.rbSQLServer.AutoSize = true;
            this.rbSQLServer.Location = new System.Drawing.Point(101, 19);
            this.rbSQLServer.Name = "rbSQLServer";
            this.rbSQLServer.Size = new System.Drawing.Size(77, 17);
            this.rbSQLServer.TabIndex = 4;
            this.rbSQLServer.TabStop = true;
            this.rbSQLServer.Text = "SQLServer";
            this.rbSQLServer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSQLite);
            this.groupBox1.Controls.Add(this.rbSQLServer);
            this.groupBox1.Location = new System.Drawing.Point(157, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DBMS";
            // 
            // clientID
            // 
            this.clientID.Location = new System.Drawing.Point(65, 8);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(51, 20);
            this.clientID.TabIndex = 6;
            this.clientID.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client id:";
            // 
            // btnPrevisione
            // 
            this.btnPrevisione.Location = new System.Drawing.Point(8, 62);
            this.btnPrevisione.Name = "btnPrevisione";
            this.btnPrevisione.Size = new System.Drawing.Size(108, 23);
            this.btnPrevisione.TabIndex = 10;
            this.btnPrevisione.Text = "Previsione dati";
            this.btnPrevisione.UseVisualStyleBackColor = true;
            this.btnPrevisione.Click += new System.EventHandler(this.btnPrevisione_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.normalRead);
            this.groupBox2.Controls.Add(this.factoryRead);
            this.groupBox2.Location = new System.Drawing.Point(381, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 46);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Read via";
            // 
            // normalRead
            // 
            this.normalRead.AutoSize = true;
            this.normalRead.Checked = true;
            this.normalRead.Location = new System.Drawing.Point(10, 19);
            this.normalRead.Name = "normalRead";
            this.normalRead.Size = new System.Drawing.Size(58, 17);
            this.normalRead.TabIndex = 3;
            this.normalRead.TabStop = true;
            this.normalRead.Text = "Normal";
            this.normalRead.UseVisualStyleBackColor = true;
            // 
            // factoryRead
            // 
            this.factoryRead.AutoSize = true;
            this.factoryRead.Location = new System.Drawing.Point(101, 19);
            this.factoryRead.Name = "factoryRead";
            this.factoryRead.Size = new System.Drawing.Size(60, 17);
            this.factoryRead.TabIndex = 4;
            this.factoryRead.TabStop = true;
            this.factoryRead.Text = "Factory";
            this.factoryRead.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPrevisione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtConsole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RadioButton rbSQLite;
        private System.Windows.Forms.RadioButton rbSQLServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrevisione;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton normalRead;
        private System.Windows.Forms.RadioButton factoryRead;
    }
}

