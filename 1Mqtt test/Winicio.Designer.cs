namespace _1Mqtt_test
{
    partial class Winicio
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
            lblsign1 = new Label();
            cmdagregar1 = new Button();
            txtValue1 = new TextBox();
            lblvalue1 = new Label();
            lblvalue2 = new Label();
            txtValue2 = new TextBox();
            cmdagregar2 = new Button();
            lblsign2 = new Label();
            SuspendLayout();
            // 
            // lblsign1
            // 
            lblsign1.AutoSize = true;
            lblsign1.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblsign1.Location = new Point(12, 22);
            lblsign1.Name = "lblsign1";
            lblsign1.Size = new Size(44, 18);
            lblsign1.TabIndex = 0;
            lblsign1.Text = "Value";
            // 
            // cmdagregar1
            // 
            cmdagregar1.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmdagregar1.Location = new Point(303, 82);
            cmdagregar1.Name = "cmdagregar1";
            cmdagregar1.Size = new Size(77, 35);
            cmdagregar1.TabIndex = 1;
            cmdagregar1.Text = "Agregar";
            cmdagregar1.UseVisualStyleBackColor = true;
            cmdagregar1.Click += cmdagregar1_Click;
            // 
            // txtValue1
            // 
            txtValue1.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtValue1.Location = new Point(278, 52);
            txtValue1.Name = "txtValue1";
            txtValue1.Size = new Size(125, 24);
            txtValue1.TabIndex = 2;
            txtValue1.KeyPress += txtValue1_KeyPress;
            // 
            // lblvalue1
            // 
            lblvalue1.AutoSize = true;
            lblvalue1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblvalue1.Location = new Point(62, 40);
            lblvalue1.Name = "lblvalue1";
            lblvalue1.Size = new Size(64, 73);
            lblvalue1.TabIndex = 3;
            lblvalue1.Text = "0";
            // 
            // lblvalue2
            // 
            lblvalue2.AutoSize = true;
            lblvalue2.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblvalue2.Location = new Point(62, 177);
            lblvalue2.Name = "lblvalue2";
            lblvalue2.Size = new Size(64, 73);
            lblvalue2.TabIndex = 7;
            lblvalue2.Text = "0";
            // 
            // txtValue2
            // 
            txtValue2.Font = new Font("Microsoft Sans Serif", 11.25F);
            txtValue2.Location = new Point(278, 189);
            txtValue2.Name = "txtValue2";
            txtValue2.Size = new Size(125, 24);
            txtValue2.TabIndex = 6;
            txtValue2.KeyPress += txtValue2_KeyPress;
            // 
            // cmdagregar2
            // 
            cmdagregar2.Font = new Font("Microsoft Sans Serif", 11.25F);
            cmdagregar2.Location = new Point(303, 219);
            cmdagregar2.Name = "cmdagregar2";
            cmdagregar2.Size = new Size(77, 35);
            cmdagregar2.TabIndex = 5;
            cmdagregar2.Text = "Agregar";
            cmdagregar2.UseVisualStyleBackColor = true;
            cmdagregar2.Click += cmdagregar2_Click;
            // 
            // lblsign2
            // 
            lblsign2.AutoSize = true;
            lblsign2.Font = new Font("Microsoft Sans Serif", 11.25F);
            lblsign2.Location = new Point(12, 159);
            lblsign2.Name = "lblsign2";
            lblsign2.Size = new Size(44, 18);
            lblsign2.TabIndex = 4;
            lblsign2.Text = "Value";
            // 
            // Winicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 355);
            Controls.Add(lblvalue2);
            Controls.Add(txtValue2);
            Controls.Add(cmdagregar2);
            Controls.Add(lblsign2);
            Controls.Add(lblvalue1);
            Controls.Add(txtValue1);
            Controls.Add(cmdagregar1);
            Controls.Add(lblsign1);
            Name = "Winicio";
            Text = "Inicio";
            FormClosing += Winicio_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsign1;
        private Button cmdagregar1;
        private TextBox txtValue1;
        private Label lblvalue1;
        private Label lblvalue2;
        private TextBox txtValue2;
        private Button cmdagregar2;
        private Label lblsign2;
    }
}
