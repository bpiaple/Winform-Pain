namespace TP1
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
            menuStrip1 = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            enregistrerToolStripMenuItem = new ToolStripMenuItem();
            outilsToolStripMenuItem = new ToolStripMenuItem();
            ligneToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            ellipseToolStripMenuItem = new ToolStripMenuItem();
            épaisseurDuTraitToolStripMenuItem = new ToolStripMenuItem();
            barreBas = new ToolStrip();
            outil = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            grosseurTrait = new ToolStripLabel();
            epaisseur = new ToolStripLabel();
            espace = new ToolStripLabel();
            choixCouleur = new ToolStripButton();
            tableau = new PictureBox();
            menuClickDroit = new ContextMenuStrip(components);
            couleurToolStripMenu = new ToolStripMenuItem();
            augmenterTraiToolStripMenu = new ToolStripMenuItem();
            diminuerTraitToolStripMenu = new ToolStripMenuItem();
            effacerToutToolStripMenu = new ToolStripMenuItem();
            Outil_nom = new ToolStripLabel();
            menuStrip1.SuspendLayout();
            barreBas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableau).BeginInit();
            menuClickDroit.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem, outilsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvrirToolStripMenuItem, enregistrerToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(172, 26);
            ouvrirToolStripMenuItem.Text = "Ouvrir...";
            ouvrirToolStripMenuItem.Click += Ouvrir;
            // 
            // enregistrerToolStripMenuItem
            // 
            enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            enregistrerToolStripMenuItem.Size = new Size(172, 26);
            enregistrerToolStripMenuItem.Text = "Enregistrer...";
            enregistrerToolStripMenuItem.Click += Enregistrer;
            // 
            // outilsToolStripMenuItem
            // 
            outilsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ligneToolStripMenuItem, rectangleToolStripMenuItem, ellipseToolStripMenuItem, épaisseurDuTraitToolStripMenuItem });
            outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            outilsToolStripMenuItem.Size = new Size(61, 24);
            outilsToolStripMenuItem.Text = "Outils";
            // 
            // ligneToolStripMenuItem
            // 
            ligneToolStripMenuItem.Name = "ligneToolStripMenuItem";
            ligneToolStripMenuItem.Size = new Size(215, 26);
            ligneToolStripMenuItem.Text = "Ligne";
            ligneToolStripMenuItem.Click += SelectionnerLigne;
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(215, 26);
            rectangleToolStripMenuItem.Text = "Rectangle";
            rectangleToolStripMenuItem.Click += SelectionnerRectangle;
            // 
            // ellipseToolStripMenuItem
            // 
            ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            ellipseToolStripMenuItem.Size = new Size(215, 26);
            ellipseToolStripMenuItem.Text = "Ellipse";
            ellipseToolStripMenuItem.Click += SelectionnerEllipse;
            // 
            // épaisseurDuTraitToolStripMenuItem
            // 
            épaisseurDuTraitToolStripMenuItem.Name = "épaisseurDuTraitToolStripMenuItem";
            épaisseurDuTraitToolStripMenuItem.Size = new Size(215, 26);
            épaisseurDuTraitToolStripMenuItem.Text = "Épaisseur du trait...";
            épaisseurDuTraitToolStripMenuItem.Click += ChangerEpaisseur;
            // 
            // barreBas
            // 
            barreBas.Dock = DockStyle.Bottom;
            barreBas.ImageScalingSize = new Size(20, 20);
            barreBas.Items.AddRange(new ToolStripItem[] { Outil_nom, toolStripSeparator1, outil, grosseurTrait, epaisseur, espace, choixCouleur });
            barreBas.Location = new Point(0, 423);
            barreBas.Name = "barreBas";
            barreBas.Size = new Size(800, 27);
            barreBas.TabIndex = 2;
            barreBas.Text = "barreBas";
            // 
            // outil
            // 
            outil.Name = "outil";
            outil.Size = new Size(45, 24);
            outil.Text = "Ligne";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // grosseurTrait
            // 
            grosseurTrait.Name = "grosseurTrait";
            grosseurTrait.Size = new Size(99, 24);
            grosseurTrait.Text = "Grosseur trai :";
            // 
            // epaisseur
            // 
            epaisseur.Name = "epaisseur";
            epaisseur.Size = new Size(17, 24);
            epaisseur.Text = "2";
            // 
            // espace
            // 
            espace.AutoSize = false;
            espace.Name = "espace";
            espace.Size = new Size(29, 24);
            espace.Text = "     ";
            // 
            // choixCouleur
            // 
            choixCouleur.AutoSize = false;
            choixCouleur.BackColor = SystemColors.InfoText;
            choixCouleur.DisplayStyle = ToolStripItemDisplayStyle.Image;
            choixCouleur.ImageTransparentColor = Color.Magenta;
            choixCouleur.Name = "choixCouleur";
            choixCouleur.Size = new Size(29, 24);
            choixCouleur.Text = "choixCouleur";
            choixCouleur.Click += OuvrirPanelCouleur;
            // 
            // tableau
            // 
            tableau.Dock = DockStyle.Fill;
            tableau.Location = new Point(0, 28);
            tableau.Name = "tableau";
            tableau.Size = new Size(800, 395);
            tableau.TabIndex = 3;
            tableau.TabStop = false;
            tableau.Paint += DessinerTableau;
            tableau.MouseDown += SourisBas;
            tableau.MouseMove += SourisDeplace;
            tableau.MouseUp += SourisHaut;
            // 
            // menuClickDroit
            // 
            menuClickDroit.ImageScalingSize = new Size(20, 20);
            menuClickDroit.Items.AddRange(new ToolStripItem[] { couleurToolStripMenu, augmenterTraiToolStripMenu, diminuerTraitToolStripMenu, effacerToutToolStripMenu });
            menuClickDroit.Name = "contextMenuStrip1";
            menuClickDroit.Size = new Size(186, 100);
            // 
            // couleurToolStripMenu
            // 
            couleurToolStripMenu.Name = "couleurToolStripMenu";
            couleurToolStripMenu.Size = new Size(185, 24);
            couleurToolStripMenu.Text = "Couleur";
            couleurToolStripMenu.Click += OuvrirPanelCouleur;
            // 
            // augmenterTraiToolStripMenu
            // 
            augmenterTraiToolStripMenu.Name = "augmenterTraiToolStripMenu";
            augmenterTraiToolStripMenu.Size = new Size(185, 24);
            augmenterTraiToolStripMenu.Text = "Augmenter Trait";
            augmenterTraiToolStripMenu.Click += AugmenterTraiToolStrip;
            // 
            // diminuerTraitToolStripMenu
            // 
            diminuerTraitToolStripMenu.Name = "diminuerTraitToolStripMenu";
            diminuerTraitToolStripMenu.Size = new Size(185, 24);
            diminuerTraitToolStripMenu.Text = "Diminuer Trait";
            diminuerTraitToolStripMenu.Click += DiminuerTraitToolStrip;
            // 
            // effacerToutToolStripMenu
            // 
            effacerToutToolStripMenu.Name = "effacerToutToolStripMenu";
            effacerToutToolStripMenu.Size = new Size(185, 24);
            effacerToutToolStripMenu.Text = "Effacer Tout";
            effacerToutToolStripMenu.Click += EffacerToutToolStrip;
            // 
            // Outil_nom
            // 
            Outil_nom.Name = "Outil_nom";
            Outil_nom.Size = new Size(41, 24);
            Outil_nom.Text = "Outil";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableau);
            Controls.Add(menuStrip1);
            Controls.Add(barreBas);
            Name = "Form1";
            Text = "New Pain 2025";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            barreBas.ResumeLayout(false);
            barreBas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableau).EndInit();
            menuClickDroit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripMenuItem enregistrerToolStripMenuItem;
        private ToolStripMenuItem outilsToolStripMenuItem;
        private ToolStripMenuItem ligneToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem ellipseToolStripMenuItem;
        private ToolStripMenuItem épaisseurDuTraitToolStripMenuItem;
        private ToolStrip barreBas;
        private ToolStripLabel outil;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel grosseurTrait;
        private ToolStripButton choixCouleur;
        private PictureBox tableau;
        private ToolStripLabel epaisseur;
        private ToolStripLabel espace;
        private ContextMenuStrip menuClickDroit;
        private ToolStripMenuItem couleurToolStripMenu;
        private ToolStripMenuItem augmenterTraiToolStripMenu;
        private ToolStripMenuItem diminuerTraitToolStripMenu;
        private ToolStripMenuItem effacerToutToolStripMenu;
        private ToolStripLabel Outil_nom;
    }
}
