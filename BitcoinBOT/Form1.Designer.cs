namespace BitcoinBOT
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_start = new Button();
            btn_comprar = new Button();
            notify = new NotifyIcon(components);
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.Transparent;
            btn_start.BackgroundImage = (Image)resources.GetObject("btn_start.BackgroundImage");
            btn_start.BackgroundImageLayout = ImageLayout.Stretch;
            btn_start.FlatAppearance.BorderSize = 0;
            btn_start.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_start.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Font = new Font("Segoe UI", 9F);
            btn_start.ForeColor = SystemColors.Control;
            btn_start.Location = new Point(66, 77);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(197, 64);
            btn_start.TabIndex = 0;
            btn_start.Text = "Iniciar Robô de Leitura";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += btn_start_Click;
            // 
            // btn_comprar
            // 
            btn_comprar.BackColor = Color.Transparent;
            btn_comprar.BackgroundImage = (Image)resources.GetObject("btn_comprar.BackgroundImage");
            btn_comprar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_comprar.FlatAppearance.BorderSize = 0;
            btn_comprar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_comprar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_comprar.FlatStyle = FlatStyle.Flat;
            btn_comprar.Font = new Font("Segoe UI", 12F);
            btn_comprar.ForeColor = SystemColors.Control;
            btn_comprar.Location = new Point(66, 165);
            btn_comprar.Name = "btn_comprar";
            btn_comprar.Size = new Size(197, 64);
            btn_comprar.TabIndex = 1;
            btn_comprar.Text = "Comprar Bitcoin";
            btn_comprar.UseVisualStyleBackColor = false;
            btn_comprar.Click += btn_comprar_Click;
            // 
            // notify
            // 
            notify.Text = "notifyIcon1";
            notify.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(340, 330);
            Controls.Add(btn_comprar);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "BitcoinBot";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_start;
        private Button btn_comprar;
        private NotifyIcon notify;
    }
}