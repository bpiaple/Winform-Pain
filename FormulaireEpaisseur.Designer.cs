namespace TP1
{
    partial class FormulaireEpaisseur
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
            changeurEpaisseur = new NumericUpDown();
            epaisseurLabel = new Label();
            boutonAnnuler = new Button();
            boutonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)changeurEpaisseur).BeginInit();
            SuspendLayout();
            // 
            // changeurEpaisseur
            // 
            changeurEpaisseur.Location = new Point(295, 186);
            changeurEpaisseur.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            changeurEpaisseur.Name = "changeurEpaisseur";
            changeurEpaisseur.Size = new Size(154, 27);
            changeurEpaisseur.TabIndex = 1;
            changeurEpaisseur.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // epaisseurLabel
            // 
            epaisseurLabel.AutoSize = true;
            epaisseurLabel.Location = new Point(107, 193);
            epaisseurLabel.Name = "epaisseurLabel";
            epaisseurLabel.Size = new Size(130, 20);
            epaisseurLabel.TabIndex = 2;
            epaisseurLabel.Text = "Épaisseur du trait :";
            // 
            // boutonAnnuler
            // 
            boutonAnnuler.DialogResult = DialogResult.Cancel;
            boutonAnnuler.Location = new Point(107, 326);
            boutonAnnuler.Name = "boutonAnnuler";
            boutonAnnuler.Size = new Size(127, 57);
            boutonAnnuler.TabIndex = 3;
            boutonAnnuler.Text = "Annuler";
            boutonAnnuler.UseVisualStyleBackColor = true;
            // 
            // boutonOK
            // 
            boutonOK.DialogResult = DialogResult.OK;
            boutonOK.Location = new Point(322, 326);
            boutonOK.Name = "boutonOK";
            boutonOK.Size = new Size(127, 57);
            boutonOK.TabIndex = 4;
            boutonOK.Text = "Valider";
            boutonOK.UseVisualStyleBackColor = true;
            // 
            // FormulaireEpaisseur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 446);
            Controls.Add(boutonOK);
            Controls.Add(boutonAnnuler);
            Controls.Add(epaisseurLabel);
            Controls.Add(changeurEpaisseur);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormulaireEpaisseur";
            ShowIcon = false;
            Text = "Modifier l'épaisseur";
            ((System.ComponentModel.ISupportInitialize)changeurEpaisseur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown changeurEpaisseur;
        private Label epaisseurLabel;
        private Button boutonAnnuler;
        private Button boutonOK;
    }
}