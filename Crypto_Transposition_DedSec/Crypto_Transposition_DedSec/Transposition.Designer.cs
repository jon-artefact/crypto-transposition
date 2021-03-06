﻿namespace Crypto_Transposition_DedSec
{
    partial class Transposition
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transposition));
            this.lb_crypt = new System.Windows.Forms.Label();
            this.lb_decrypt = new System.Windows.Forms.Label();
            this.lb_key = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.tb_crypt = new System.Windows.Forms.TextBox();
            this.tb_decrypt = new System.Windows.Forms.TextBox();
            this.bt_crypt = new System.Windows.Forms.Button();
            this.bt_decrypt = new System.Windows.Forms.Button();
            this.bt_key = new System.Windows.Forms.Button();
            this.keyGen = new System.Windows.Forms.PictureBox();
            this.cryptPicture = new System.Windows.Forms.PictureBox();
            this.decryptPicture = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.keyGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_crypt
            // 
            this.lb_crypt.AutoSize = true;
            this.lb_crypt.BackColor = System.Drawing.Color.Black;
            this.lb_crypt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_crypt.ForeColor = System.Drawing.Color.White;
            this.lb_crypt.Location = new System.Drawing.Point(52, 343);
            this.lb_crypt.Name = "lb_crypt";
            this.lb_crypt.Size = new System.Drawing.Size(144, 16);
            this.lb_crypt.TabIndex = 0;
            this.lb_crypt.Text = "Texte à crypter :";
            // 
            // lb_decrypt
            // 
            this.lb_decrypt.AutoSize = true;
            this.lb_decrypt.BackColor = System.Drawing.Color.Black;
            this.lb_decrypt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_decrypt.ForeColor = System.Drawing.Color.White;
            this.lb_decrypt.Location = new System.Drawing.Point(52, 377);
            this.lb_decrypt.Name = "lb_decrypt";
            this.lb_decrypt.Size = new System.Drawing.Size(160, 16);
            this.lb_decrypt.TabIndex = 1;
            this.lb_decrypt.Text = "Texte à décrypter :";
            // 
            // lb_key
            // 
            this.lb_key.AutoSize = true;
            this.lb_key.BackColor = System.Drawing.Color.Black;
            this.lb_key.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_key.ForeColor = System.Drawing.Color.White;
            this.lb_key.Location = new System.Drawing.Point(90, 473);
            this.lb_key.Name = "lb_key";
            this.lb_key.Size = new System.Drawing.Size(56, 16);
            this.lb_key.TabIndex = 6;
            this.lb_key.Text = "Clef :";
            // 
            // tb_key
            // 
            this.tb_key.BackColor = System.Drawing.Color.Black;
            this.tb_key.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_key.ForeColor = System.Drawing.Color.White;
            this.tb_key.Location = new System.Drawing.Point(152, 470);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(428, 22);
            this.tb_key.TabIndex = 7;
            // 
            // tb_crypt
            // 
            this.tb_crypt.BackColor = System.Drawing.Color.Black;
            this.tb_crypt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_crypt.ForeColor = System.Drawing.Color.White;
            this.tb_crypt.Location = new System.Drawing.Point(202, 340);
            this.tb_crypt.Name = "tb_crypt";
            this.tb_crypt.Size = new System.Drawing.Size(442, 22);
            this.tb_crypt.TabIndex = 8;
            // 
            // tb_decrypt
            // 
            this.tb_decrypt.BackColor = System.Drawing.Color.Black;
            this.tb_decrypt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_decrypt.ForeColor = System.Drawing.Color.White;
            this.tb_decrypt.Location = new System.Drawing.Point(218, 374);
            this.tb_decrypt.Name = "tb_decrypt";
            this.tb_decrypt.Size = new System.Drawing.Size(426, 22);
            this.tb_decrypt.TabIndex = 9;
            // 
            // bt_crypt
            // 
            this.bt_crypt.BackColor = System.Drawing.Color.Black;
            this.bt_crypt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_crypt.ForeColor = System.Drawing.Color.White;
            this.bt_crypt.Location = new System.Drawing.Point(650, 340);
            this.bt_crypt.Name = "bt_crypt";
            this.bt_crypt.Size = new System.Drawing.Size(89, 23);
            this.bt_crypt.TabIndex = 10;
            this.bt_crypt.Text = "Crypter";
            this.bt_crypt.UseVisualStyleBackColor = false;
            this.bt_crypt.Click += new System.EventHandler(this.crypt);
            // 
            // bt_decrypt
            // 
            this.bt_decrypt.BackColor = System.Drawing.Color.Black;
            this.bt_decrypt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_decrypt.ForeColor = System.Drawing.Color.White;
            this.bt_decrypt.Location = new System.Drawing.Point(650, 374);
            this.bt_decrypt.Name = "bt_decrypt";
            this.bt_decrypt.Size = new System.Drawing.Size(89, 23);
            this.bt_decrypt.TabIndex = 11;
            this.bt_decrypt.Text = "Décrypter";
            this.bt_decrypt.UseVisualStyleBackColor = false;
            this.bt_decrypt.Click += new System.EventHandler(this.decrypt);
            // 
            // bt_key
            // 
            this.bt_key.BackColor = System.Drawing.Color.Black;
            this.bt_key.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_key.ForeColor = System.Drawing.Color.White;
            this.bt_key.Location = new System.Drawing.Point(586, 470);
            this.bt_key.Name = "bt_key";
            this.bt_key.Size = new System.Drawing.Size(89, 23);
            this.bt_key.TabIndex = 12;
            this.bt_key.Text = "Générer";
            this.bt_key.UseVisualStyleBackColor = false;
            this.bt_key.Click += new System.EventHandler(this.key_generate);
            // 
            // keyGen
            // 
            this.keyGen.Image = global::Crypto_Transposition_DedSec.Properties.Resources.tumblr_n6s8peOt8J1ql7hdyo1_500;
            this.keyGen.InitialImage = global::Crypto_Transposition_DedSec.Properties.Resources.initial;
            this.keyGen.Location = new System.Drawing.Point(12, 7);
            this.keyGen.Name = "keyGen";
            this.keyGen.Size = new System.Drawing.Size(759, 273);
            this.keyGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.keyGen.TabIndex = 13;
            this.keyGen.TabStop = false;
            this.keyGen.Visible = false;
            // 
            // cryptPicture
            // 
            this.cryptPicture.Image = global::Crypto_Transposition_DedSec.Properties.Resources.cryptPicture;
            this.cryptPicture.InitialImage = global::Crypto_Transposition_DedSec.Properties.Resources.initial;
            this.cryptPicture.Location = new System.Drawing.Point(12, 7);
            this.cryptPicture.Name = "cryptPicture";
            this.cryptPicture.Size = new System.Drawing.Size(759, 273);
            this.cryptPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cryptPicture.TabIndex = 14;
            this.cryptPicture.TabStop = false;
            this.cryptPicture.Visible = false;
            // 
            // decryptPicture
            // 
            this.decryptPicture.Image = global::Crypto_Transposition_DedSec.Properties.Resources.decryptPicture;
            this.decryptPicture.InitialImage = global::Crypto_Transposition_DedSec.Properties.Resources.initial;
            this.decryptPicture.Location = new System.Drawing.Point(12, 7);
            this.decryptPicture.Name = "decryptPicture";
            this.decryptPicture.Size = new System.Drawing.Size(759, 273);
            this.decryptPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.decryptPicture.TabIndex = 15;
            this.decryptPicture.TabStop = false;
            this.decryptPicture.Visible = false;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Black;
            this.exit.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(751, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(18, 18);
            this.exit.TabIndex = 16;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.quit);
            // 
            // Transposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Crypto_Transposition_DedSec.Properties.Resources.fond;
            this.ClientSize = new System.Drawing.Size(779, 517);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.decryptPicture);
            this.Controls.Add(this.cryptPicture);
            this.Controls.Add(this.keyGen);
            this.Controls.Add(this.bt_key);
            this.Controls.Add(this.bt_decrypt);
            this.Controls.Add(this.bt_crypt);
            this.Controls.Add(this.tb_decrypt);
            this.Controls.Add(this.tb_crypt);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.lb_key);
            this.Controls.Add(this.lb_decrypt);
            this.Controls.Add(this.lb_crypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(799, 559);
            this.Name = "Transposition";
            this.Text = "CRYP70 7R4NSP051710N By D3D55C - J0HN & B4TR0";
            this.Load += new System.EventHandler(this.charger);
            ((System.ComponentModel.ISupportInitialize)(this.keyGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cryptPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.decryptPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_crypt;
        private System.Windows.Forms.Label lb_decrypt;
        private System.Windows.Forms.Label lb_key;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.TextBox tb_crypt;
        private System.Windows.Forms.TextBox tb_decrypt;
        private System.Windows.Forms.Button bt_crypt;
        private System.Windows.Forms.Button bt_decrypt;
        private System.Windows.Forms.Button bt_key;
        private System.Windows.Forms.PictureBox keyGen;
        private System.Windows.Forms.PictureBox cryptPicture;
        private System.Windows.Forms.PictureBox decryptPicture;
        private System.Windows.Forms.Label exit;
    }
}

