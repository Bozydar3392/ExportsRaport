namespace ExportRaport
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cbDateEnd = new System.Windows.Forms.ComboBox();
            this.cbDateStart = new System.Windows.Forms.ComboBox();
            this.cbLokal = new System.Windows.Forms.ComboBox();
            this.btZatwierdz = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDatabase = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Controls.Add(this.cbDateEnd);
            this.groupBox1.Controls.Add(this.cbDateStart);
            this.groupBox1.Controls.Add(this.cbLokal);
            this.groupBox1.Controls.Add(this.btZatwierdz);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raport";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(167, 20);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(500, 460);
            this.dataGridView.TabIndex = 4;
            // 
            // cbDateEnd
            // 
            this.cbDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDateEnd.FormattingEnabled = true;
            this.cbDateEnd.Location = new System.Drawing.Point(25, 100);
            this.cbDateEnd.Name = "cbDateEnd";
            this.cbDateEnd.Size = new System.Drawing.Size(121, 21);
            this.cbDateEnd.TabIndex = 3;
            this.cbDateEnd.Text = "Do:";
            this.cbDateEnd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbDateEnd_MouseClick);
            // 
            // cbDateStart
            // 
            this.cbDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDateStart.FormattingEnabled = true;
            this.cbDateStart.Location = new System.Drawing.Point(25, 60);
            this.cbDateStart.Name = "cbDateStart";
            this.cbDateStart.Size = new System.Drawing.Size(121, 21);
            this.cbDateStart.TabIndex = 2;
            this.cbDateStart.Text = "Od:";
            this.cbDateStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbDateStart_MouseClick);
            // 
            // cbLokal
            // 
            this.cbLokal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbLokal.FormattingEnabled = true;
            this.cbLokal.Location = new System.Drawing.Point(25, 20);
            this.cbLokal.Name = "cbLokal";
            this.cbLokal.Size = new System.Drawing.Size(121, 21);
            this.cbLokal.TabIndex = 1;
            this.cbLokal.Text = "Lokal:";
            this.cbLokal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbLokal_MouseClick);
            // 
            // btZatwierdz
            // 
            this.btZatwierdz.Enabled = false;
            this.btZatwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btZatwierdz.Location = new System.Drawing.Point(25, 150);
            this.btZatwierdz.Name = "btZatwierdz";
            this.btZatwierdz.Size = new System.Drawing.Size(75, 23);
            this.btZatwierdz.TabIndex = 0;
            this.btZatwierdz.Text = "Zatwierdź";
            this.btZatwierdz.UseVisualStyleBackColor = true;
            this.btZatwierdz.Click += new System.EventHandler(this.btZatwierdz_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbDatabase);
            this.groupBox2.Controls.Add(this.tbServer);
            this.groupBox2.Controls.Add(this.btConnect);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baza danych";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(212, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa bazy danych";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa serwera";
            // 
            // tbDatabase
            // 
            this.tbDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDatabase.Location = new System.Drawing.Point(212, 38);
            this.tbDatabase.Name = "tbDatabase";
            this.tbDatabase.Size = new System.Drawing.Size(200, 20);
            this.tbDatabase.TabIndex = 2;
            // 
            // tbServer
            // 
            this.tbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbServer.Location = new System.Drawing.Point(6, 38);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(200, 20);
            this.tbServer.TabIndex = 1;
            // 
            // btConnect
            // 
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btConnect.Location = new System.Drawing.Point(592, 38);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Połącz";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(734, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDateEnd;
        private System.Windows.Forms.ComboBox cbDateStart;
        private System.Windows.Forms.ComboBox cbLokal;
        private System.Windows.Forms.Button btZatwierdz;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDatabase;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

